let form = document.querySelector("#userForm")

form.addEventListener('submit' , formSubmit)

const alert = document.querySelector("#alert")

const ALERT = (title,message,className="warning") =>` 
<div class="alert alert-${className} alert-dismissible fade show" role="alert">
  <strong>${title}</strong> ${message}
  <button type="button" class="close" data-dismiss="alert" aria-label="Close">
    <span aria-hidden="true">&times;</span>
  </button>
</div>`
//uyarı mesajı 


function formSubmit(event){
    event.preventDefault() //default işlemi engelle 
    //console.log("işlem gerçekleşti")

    const  USER_NAME =document.querySelector("#username")
    let SCORE = document.querySelector("#score")

    //console.log(score.value)
    //localStorage.setItem('score' , score.value )
    if (USER_NAME.value && SCORE.value) {
            addItem(USER_NAME.value,SCORE.value)
            USER_NAME.value = ""
            SCORE.value = ""
    }
    else{
        //console.log("Hatalı giriş")
        alert.innerHTML = ALERT(
            "BAŞLIK",
            "HATALI BİLGİ GİRDİNİZ",
            "success")
    }


}

let USER_LİST = document.querySelector("#userList")

const addItem = (username,score) => {
let li = document.createElement("li") //li elemanı oluşturduk atadık
li.innerHTML = `
${username} 
<span class="badge badge-primary badge-pill" style = "color :red">${score}</span>
` //linin içine aldığımız username ve scoru koyduk
li.classList.add('list-group-item','d-flex','justify-content-between', 'align-items-center') //classListesine olması gerekn classları ekledik
USER_LİST.append(li) // USER_LİST İçine li bilgilerini koy

}