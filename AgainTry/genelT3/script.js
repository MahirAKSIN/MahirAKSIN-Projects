const lilim = document.querySelectorAll("li");
console.log(lilim);

// lilim.addEventListener("click",()=>{
//     alert("lilim tıklandi")
// })

// buton.addEventListener("click", () => {
//   alert("Buton tıklandi");
// });

reflesh();

function reflesh() {
  const lilim = document.querySelectorAll("li");

  lilim.forEach((p) => {
    p.addEventListener("click", (e) => {
      e.target.remove();
    });
  });
}
const lu = document.querySelector("ul");

const buton = document.querySelector("button");
buton.addEventListener("click", () => {
  const li = document.createElement("li");

  li.textContent = "JAVASCRİPT";

  lu.prepend(li);
  reflesh();
});
