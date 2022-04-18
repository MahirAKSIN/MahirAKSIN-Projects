let greeting = document.querySelector("#greeting");

greeting.addEventListener("click", domCLick)  //mouseover 

function domCLick(){
    console.log("tiklandi");
    console.log(this.innerHTML = "tiklandiğinda değişir")
    this.style.color == "blue" ?  this.style.color = "red" : this.style.color = "blue" ;

}