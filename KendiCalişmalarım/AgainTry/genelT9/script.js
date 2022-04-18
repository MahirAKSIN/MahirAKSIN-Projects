// $(document).ready(function(){
//   $("li").nextUntil().css({
//     "color":"red",
//     "borde":"2px solid yellow",

//   })
// })

$(document).ready(function () {
  $("button").click(function () {
    $("p").filter(".demo").css("background-color","red");
  });
});
