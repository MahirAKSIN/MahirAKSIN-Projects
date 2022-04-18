const SMILE = `<svg xmlns="http://www.w3.org/2000/svg" width="30" height="30" fill="currentColor" class="bi bi-emoji-smile-upside-down" viewBox="0 0 16 16">
  <path d="M8 1a7 7 0 1 0 0 14A7 7 0 0 0 8 1zm0-1a8 8 0 1 1 0 16A8 8 0 0 1 8 0z"/>
  <path d="M4.285 6.433a.5.5 0 0 0 .683-.183A3.498 3.498 0 0 1 8 4.5c1.295 0 2.426.703 3.032 1.75a.5.5 0 0 0 .866-.5A4.498 4.498 0 0 0 8 3.5a4.5 4.5 0 0 0-3.898 2.25.5.5 0 0 0 .183.683zM7 9.5C7 8.672 6.552 8 6 8s-1 .672-1 1.5.448 1.5 1 1.5 1-.672 1-1.5zm4 0c0-.828-.448-1.5-1-1.5s-1 .672-1 1.5.448 1.5 1 1.5 1-.672 1-1.5z"/>
</svg>`

var myVar = setInterval(myTimer ,1000); //myTimer fonk çağırdım

let name2 = prompt("İsminiz nedir ?",) //isim aldım
name2 = name2.toUpperCase()

let isimYazdir = document.querySelector("#name")

let smile = document.querySelector("#smile")
smile.innerHTML = `${SMILE}`

let haftaSonu = "Mutlu hafta sonları :)"
let pazartesi = " sendromu :/"
//let haftaIcı =  "hafta içi"

function myTimer() {
    var date = new Date();
    var day = date.getDay();
        if (day == 1) {
                day = `Pazartesi ${pazartesi}`
            } else if (day == 2) {
                day = `Salı`
            } else if (day == 3) {
                day = `Çarşamba`
            } else if (day == 4) {
                day = `Perşembe`
            } else if (day == 5) {
                day = `Cuma`
            } else if (day == 6) {
                day = `Cumartesi ${haftaSonu}`
            } else if (day == 7) {
                day = `Pazar ${haftaSonu}`
            }

    isimYazdir.innerHTML = `Merhaba <span>${name2}</span>` 

    document.querySelector("#date").innerHTML =`<span style="font-size : 20px">Mevcut konumunuzdaki saat :</span><br>
    <span style = "font-size : 100px ;color:orange ;">${date.toLocaleTimeString()}<span>`


    document.querySelector("#day").innerHTML = `<span>Günlerden ${day}</span>`
}

