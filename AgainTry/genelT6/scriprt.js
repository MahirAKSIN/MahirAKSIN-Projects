// $(document).ready(function () {
//   $("button#btn").click(function () {
//     $("#d").toggle("slow");
//   });
//   $("button#btn1").click(function () {
//     $("#d").show("slow");
//   });
// });

// $(document).ready(function () {
//   $("button#btn").click(function () {
//     $("#div1").fadeIn(3000);
//   });
// $("button#btn").click(function () {
//   $("#div2").fadeOut("slow");
// });
// $("button#btn").click(function () {
//   $("#div3").fadeOut(3000);
// });
// });
// $(document).ready(function () {
//   $("button#btn1").click(function () {
//     $("#div1").fadeOut(3000, function () {
//       $("#div1").fadeIn(3000);
//     });
//   });
//   // $("button#btn1").click(function () {
//   //   $("#div2").hide("slow");
//   // });
//   // $("button#btn1").click(function () {
//   //   $("#div3").hide(3000);
//   // });
// });
$(document).ready(function () {
  $("button#btn").click(function () {
    $("#div1").fadeOut(3000, function () {
      $("#div1").fadeIn(3000);
    });
  });
});
