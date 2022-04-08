$(document).ready(function () {
  // alert("Oyun Başliyor Birader!!")
  $("#btn").click(function () {
    $("div#div0").hide("slow", function () {
      $("div#div1").hide("slow", function () {
        $("div#div2").hide("slow", function () {
          $("div#div4").hide("slow", function () {
            $("div#div5").hide("slow", function () {
              $("div#div6").hide("slow");
            });
          });
        });
      });
    });
  });
  $("#btn1").click(function () {
    $("div#div0").show("fast");
    $("div#div1").show("slow", function () {
      $("div#div2").show("slow", function () {
        $("div#div4").show("slow", function () {
          $("div#div5").show("slow", function () {
            $("div#div6").show("slow", function () {
              $("div#div6").show("slow", function () {
                $("div#div5").show("slow", function () {
                  $("div#div4").show("slow", function () {
                    $("div#div2").show("slow", function () {
                      $("div#div1").show("slow", function () {
                        $("div#div0").show("fast");
                      });
                    });
                  });
                });
              });
            });
          });
        });
      });
    });
  });
});
