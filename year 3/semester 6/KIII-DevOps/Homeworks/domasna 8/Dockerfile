FROM nginx:latest
LABEL author="andrej.bardakoski@students.finki.ukim.mk"
RUN apt-get update
COPY index.html /usr/share/nginx/html
EXPOSE 8080
CMD ["nginx", "-g", "daemon off;"]