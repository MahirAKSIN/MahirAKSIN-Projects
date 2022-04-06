const icerk = document.querySelector("p");
console.log(icerk);
console.log(icerk.classList);
icerk.classList.add("topHeader");
// icerk.classList.remove("error")




const content=document.querySelectorAll("p");
console.log(content);

content.forEach(p=>{
if (p.textContent.includes("success")) {
    p.classList.add("success")
    // p.textContent.style.fontSize="100px"
    
}if (p.textContent.includes("error")) {
    p.classList.add("error");
    
}

})


