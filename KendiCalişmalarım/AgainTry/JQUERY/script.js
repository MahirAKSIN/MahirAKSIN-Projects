$(document).ready(function () {
  $("ul").click(function () {
    $("ul").hide();
  });
});

// $(document).ready(function () {
//   $("button").click(function () {
//     $("ul li:first-child").hide();
//   });
// });

// $(document).ready(function () {
//   $("button").click(function () {

//     $("a[target=_blank]").hide();
//   });
// });

// $(document).ready(function () {
//   $("button").click(function () {
//     $("tr:even").css("background-color", "grey", "color", "red");
//     $("tr:even").css("color", "red");
//     $("tr:odd").css("background-color", "yellow", "color", "gray");
//     $("tr:odd").css("color", "aqua");

//   });
// });

// $(document).ready(function () {
//   $("button").click(function () {
//     $(":button").css("background-color", "red");
//   });
// });

// $(document).ready(function () {
//   $("button").click(function () {
//     $(":submit").css("background-color", "red");
//   });
// });
// $(document).ready(function(){
//     $("button").click(function(){
//         $(":submit").css("background-color","red").css("width","95px").css("height","50px")
//         $(":reset").css("background-color","red").css("width","95px").css("height","50px")
//     })
// })

// $(document).ready(function () {
//   $("button").click(function () {
//     // alert("Geldim");
//     $(":checkbox").css("background-color", "red").css("width", "100px").css("height","55px");
//   });
// });
// $(document).ready(function () {
//   $("button").click(function () {
//     $(":radio")
//       .css("background-color", "red")
//       .css("width", "100px")
//       .css("height", "55px");
//   });
// });
// $(document).ready(function(){
//     $("button").click(function(){
//         $("a:not(':contains(Yandex)')").css("background-color","red")

//     })
// })
// $(document).ready(function(){
//     $("button").click(function(){
//         $(":empty").css("width","100px").css("height","100px").
//         css("background-color","red")
//     })
// })

// $(document).ready(function () {
//   $("button").click(function () {
//     $("div:has(p)").css("background-color", "red");
//   });
// });

$(document).ready(function () {
  $("button").click(function () {
    $(":image").css("width", "170px").css("height", "170px").
    css("background-color","red");
  });
});

const btn = document.querySelector("#btn");
const btn1 = document.querySelector("button");

btn.addEventListener("click", (p) => {
  const pler = document.querySelectorAll("p");

  pler.forEach((p) => {
    p.style.display = "none";
  });
});

btn1.addEventListener("click", () => {
  const pler = document.querySelectorAll("p");
  pler.forEach((p) => {
    p.style.display = "block";
  });
});
