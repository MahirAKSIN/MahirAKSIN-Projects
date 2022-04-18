// $(document).ready(function () {
//   $("p").click(function () {
// //     $("h1").hide();
// //   });
// // });
// $(document).ready(function () {
//   $("p").mousedown(function () {
//     alert("hello Word");
//   });
// });

// $(document).ready(function () {
//   $("p").hover(
//     function () {
//       alert("alandasınız");
//     },
//     function () {
//       alert("Alandan çıktınız");
//     }
//   );
// });

// $(document).ready(function () {
//   $("input").focus(function () {
//     $(this).css("background-color", "red");
//   });

//   $("input").blur(function () {
//     $(this).css("background-color", "yellow");
//   });
// });

$(document).ready(function () {
  $("input").keydown(function () {
    $("input").css("backgorund-color", "red");
  });
  $("input").keyup(function () {
    $("imnput").css("backgorund-color", "green");
  });
});
