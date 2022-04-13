
let user = { userName: "Mahir", isActive: "true"   }

console.log(user) // object değerlerine ulaşabiliyoruz

//localStorage.setItem('userInfo',user) //keyword value object olarak oluşuyor

localStorage.setItem('userInfo',JSON.stringify(user)) //JSON.stringfy ile  string hali kullanmaya hazır 

let userInfo = localStorage.getItem('userInfo') //userInfo keyword unu al
userInfo = JSON.parse(userInfo) //  artık bilgilere erişebiliriz

console.log(userInfo) // Object object değrini alıyoruz 


 