// console.log(paragraflar);
const notlar = [];
for (let i = 0; i < 10; i++) {
  notlar[i] = [Math.trunc(Math.random(100) * 100)];
}
const paragraflar = document.querySelector("#notlar");


html = ``;
notlar.forEach((not) => {
    sinif = "basarili";
    if (not < 50) sinif = "basarisiz";
    html += `<p class=${sinif}>${not} </p>`;
  
});
console.log(html)
paragraflar.innerHTML=html;
