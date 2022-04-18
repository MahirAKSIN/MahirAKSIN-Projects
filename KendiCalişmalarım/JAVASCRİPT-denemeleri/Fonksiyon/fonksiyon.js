function helloWorld() {
  console.log("hello world")
}

function hello() {
  console.log("hello")
  helloWorld() //fonksiyon içinde farklı bir fonk çağırılabilir
}


hello()
function printScreen1() {
  console.log("İlk ekran çıktısı");
}

function printScreen2() {
  setTimeout(function () {
    console.log("İkinci ekran çıktısı")
  }, 3000);     //3 sn bekletti js asenkron yapıda bir programlama dilidir
}

function printScreen3() {
  console.log("Üçüncü ekran çıktısı");
}
printScreen1();
printScreen2();
printScreen3();
const carpim = (sayi1, sayi2) => sayi1 * sayi2;   //çarpım isminde fonk tanımladık Fat Arrow
console.log(carpim(2, 10));

