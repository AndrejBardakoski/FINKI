# Verzija na Alpine base image
ARG ALPINE_VERSION=3.11

FROM alpine:${ALPINE_VERSION} as builder

# Verzii na nginx i nginx RTMP module
ARG  NGINX_VERSION=1.17.5
ARG  NGINX_RTMP_MODULE_VERSION=1.2.1

# Instalacija na potrebni zavisnosti i paketi
RUN apk update	&& \
	apk --no-cache add \
		bash build-base ca-certificates \
		openssl openssl-dev make \
		gcc libgcc libc-dev rtmpdump-dev \
		zlib-dev musl-dev pcre pcre-dev lame-dev \
		yasm pkgconf pkgconfig libtheora-dev \
		libvorbis-dev libvpx-dev freetype-dev  \
		x264-dev x265-dev && \
    rm -rf /var/lib/apt/lists/*	
	
# Instalacija na nginx
RUN mkdir -p /tmp/build && \
	cd /tmp/build && \
	wget https://nginx.org/download/nginx-${NGINX_VERSION}.tar.gz && \
	tar zxf nginx-${NGINX_VERSION}.tar.gz && \
	rm nginx-${NGINX_VERSION}.tar.gz

# Instalacija na rtmp-module
RUN cd /tmp/build && \
    wget https://github.com/arut/nginx-rtmp-module/archive/v${NGINX_RTMP_MODULE_VERSION}.tar.gz && \
    tar zxf v${NGINX_RTMP_MODULE_VERSION}.tar.gz && \
	rm v${NGINX_RTMP_MODULE_VERSION}.tar.gz
	
# Konfiguriranje na nginx zaedno so nginx-rtmp module
RUN cd /tmp/build/nginx-${NGINX_VERSION} && \
    ./configure \
        --sbin-path=/usr/local/sbin/nginx \
        --conf-path=/etc/nginx/nginx.conf \
        --error-log-path=/var/log/nginx/error.log \
        --http-log-path=/var/log/nginx/access.log \		
        --pid-path=/var/run/nginx/nginx.pid \
        --lock-path=/var/lock/nginx.lock \
        --http-client-body-temp-path=/tmp/nginx-client-body \
        --with-http_ssl_module \
        --with-threads \
        --add-module=/tmp/build/nginx-rtmp-module-${NGINX_RTMP_MODULE_VERSION} && \
    make CFLAGS=-Wno-error -j $(getconf _NPROCESSORS_ONLN) && \
    make install

	
# Premestuvanje na stat.xsl datotekata potrebna za informacii za potocite
RUN cp /tmp/build/nginx-rtmp-module-${NGINX_RTMP_MODULE_VERSION}/stat.xsl /usr/local/nginx/html/stat.xsl && \
	rm -rf /tmp/build

# Kreiranje na finalniot image
FROM alpine:${ALPINE_VERSION}

# Zavisnosti
RUN apk update	&& \
	apk --no-cache add \
		bash ca-certificates openssl \
		pcre libtheora libvorbis libvpx \
		librtmp x264-dev x265-dev freetype lame && \
    rm -rf /var/lib/apt/lists/*	

# Kopiranje direktoriumi i datoteki od build stage vo final stage		
COPY --from=builder /usr/local /usr/local
COPY --from=builder /etc/nginx /etc/nginx
COPY --from=builder /var/log/nginx /var/log/nginx
COPY --from=builder /var/lock /var/lock
COPY --from=builder /var/run/nginx /var/run/nginx

# Logovi
RUN ln -sf /dev/stdout /var/log/nginx/access.log && \
    ln -sf /dev/stderr /var/log/nginx/error.log

# Kopiranje na nginx config datoteka vo container
COPY nginx.conf /etc/nginx/nginx.conf

# Kopirane na video vo container za VOD dostava
COPY video.mp4 /usr/local/nginx/html/rtmp-vod/video.mp4

# Kopiranje na hls live player vo container
COPY players/live-player.html /usr/local/nginx/html/

# Kopiranje hls vod folder vo container za HLS VOD
COPY hls-vod usr/local/nginx/html/hls-vod-201149

# Kopiranje na hls vod player vo container
COPY players/hls-vod-player.html /usr/local/nginx/html/

# Kopiranje dash vod folder za DASH VOD
COPY dash-vod usr/local/nginx/html/dash-vod-201149

# Kopiranje na dash vod player vo container
COPY players/dash-vod-player.html /usr/local/nginx/html/

# Otvoranje na potrebnite porti za RTMP (1935), HLS (8080) i DASH (8080)
EXPOSE 1935
EXPOSE 8080

CMD ["nginx", "-g", "daemon off;"]