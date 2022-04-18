//  $(document).ready(function () {
//    $("#btn").click(function () {
//      $("h1,h2,p").addClass("box");
//      $("#result").addClass("content")
//    });
//  });
// $(document).ready(function(){
//   $("button").click(function(){
//     $("<h1>C#</h1>").replaceAll("#d",function(){
//       $("<li>#asa</li>").replaceAll("h2")
//     })
//   })

// })

// $(document).ready(function () {
//   $("button").click(function () {
//     console.log($("div").scrollTop() + "px");
//   });
// });


$(document).ready(function(){
  $("#btn").click(function(){
    $("div").wrap("<p></p>")
  })
})