let username ="" // = "hilal"

//let info = document.querySelector("h3#info")  
let info = document.createElement("h3") //h3 etiketi oluşturdum
//ternary kullanımı: 
//kosul ? dogruysa : yanlıssa

info.innerHTML = `${ username ? username : "bilgi yok" }`  //info içeriği
document.body.prepend(info) 
//document body e infoyu ekledim
//username doluysa değeri göster boşsa bilgi yok yazdır
// &gt; greater than büyüktür
// &lt; less than küçüktür
