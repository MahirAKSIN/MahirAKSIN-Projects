// $(document).ready(function () {

//   $("p").on("click mouseleave", function () {

//     $("#topHeader").css("background-color", "yellow").css("height", "115px");
//   });
// });

// $(document).ready(function () {
//   $("p").mousedown(function () {
//     $("p").css("width", "99px");
//   });
// });

$(document).ready(function () {
  $("button").focus(function () {
    $("p").css("background-color", "red");
  });
});

// const pler = document.querySelectorAll("p");
// console.log(pler);

// let html = ``;
// pler.forEach((p) => {
//   // html += `<div>${p}</div>`;
//   console.log(p);

//   p.innerText += "paragraflarım";
//   console.log(p.innerText);
// });
// const btn = document.querySelector("button");
// btn.addEventListener("click", () => {
//   alert("Ben tıkladım,pişman değilim herkes bir kere tıklamalı hayatta");
//   const pler = document.querySelectorAll("p");
//   pler.forEach((p) => {
//     $(document).ready(function () {
//       $("p").ever(function () {
//         $("p").css("background-color", "red");
//       });
//     });
//   });
// });
