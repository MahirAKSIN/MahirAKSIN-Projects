const hellofunction = (firstName) => {console.log(`hello ${firstName}`)}
hellofunction("hilal") // Fat Arrow tipi fonksiyon tanımlama



const seriesList = list => {
  
  list.forEach((series, index) => {
    console.log(`${index}. ${series}`) 
  });
};

seriesList(["Firefly", "The Mandalorian","Breaking Bad"]);

// forEach yapısıyla tüm listeyi dolaşıp yazdırdık


let movie = {   // this.name i tanıyan fat arrow fonksiyonu olmuyor 

name: "La la land",

thisInArrow:() => { 
console.log("Movie name is " + this.name); // 'this' window'u referans gösterir. Bu yüzden name'yi bulamaz.
}, 

thisInRegular(){ 
console.log("Movie name is " + this.name); // 'this' kendisini referans gösterir ve çalışır.
} 

};
movie.thisInRegular()
movie.thisInArrow()

function greetings(name, lastName) {

    //console.log(`Merhaba ${name ? name : ""} ${lastName ? lastName : ""}`);
    // name varsa bastır yoksa boş olarak bastır
    let info = `Merhaba ${name} ${lastName}`
    return info
} //default parametre alır

//greetings("hilal", "öztürk"); // 1 kere yazdıracak
//console.log(greetings("hilal","öztürk")); //2 kere yazdıracak 

let info = greetings("Mahir", "AKSIN");

function domIdWriteInfo(id, info2) {
    let domObject = document.querySelector(`#${id}`)
    domObject.innerHTML =`<span style="color:red">${info2}</span>` 

}

domIdWriteInfo('greeting', info)

