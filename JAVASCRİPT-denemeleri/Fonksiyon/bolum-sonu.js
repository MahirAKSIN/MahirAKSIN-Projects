let arttır = document.querySelector("#increase"); 
let azalt = document.querySelector("#decrease"); 

let counter = document.querySelector("#counter");

let sayi = localStorage.getItem('sayi') ? Number(localStorage.getItem('sayi')) : 0
counter.innerHTML = sayi;

arttır.addEventListener("click",function(){
    sayi += 1;
    localStorage.setItem('sayi' , sayi)
    counter.innerHTML = sayi;
})

azalt.addEventListener("click",function(){
    sayi -= 1;
    localStorage.setItem('sayi' , sayi)
    counter.innerHTML = sayi;
})

