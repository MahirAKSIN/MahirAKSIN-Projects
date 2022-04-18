// $(document).ready(function () {
//   $("p#pp").on("click", function () {
//     alert("one tıklandı");
//   });
// });

// $(document).ready(function () {
//   $("button").click(function () {
//     // $(":p").style("background-color", "red");
//     $("p").hide();
// //   });
// });
$(document).ready(function () {
  var onj = {
    name: "Mahir",
    surname: "AKSIN",
    age: 21,
    test: function () {
      $("p.pp").text(
        "Isim :" + this.name + "Soyad : " + this.urname + "Yas : " + this.age
      );
    },
  };

  $("input").click($.proxy(onj, "text"));
  alert("MAHİR")

});

// $(document).ready(function () {
//   $("form").submit(function () {
//     alert("kaydıt edildi...");
//   });
// });
// $(document).ready(function () {
//   $("input").select(function () {
//     $("#result").text("Metni Sectiniz");
//   });
//   $("button").click(function () {
//     $("input").trigger("select");
//   });
// })
