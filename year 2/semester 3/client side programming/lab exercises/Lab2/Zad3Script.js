document.body.style.fontFamily="Arial";
var span=document.getElementsByTagName("span");
span[0].innerText="Andrej";
span[1].innerText="201149";
span[2].innerText="Skopje";
var li=document.getElementsByTagName("li");
for(var i=0;i<li.length;i++){
    li[i].style.backgroundColor="red";
}