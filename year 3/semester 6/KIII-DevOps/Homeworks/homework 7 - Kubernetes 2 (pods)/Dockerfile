FROM nginx:latest
LABEL author="andrej.bardakoski@students.finki.ukim.mk"
RUN apt-get update
RUN echo 'Hello World' > /usr/share/nginx/html/index.html
EXPOSE 80
CMD ["nginx", "-g", "daemon off;"]