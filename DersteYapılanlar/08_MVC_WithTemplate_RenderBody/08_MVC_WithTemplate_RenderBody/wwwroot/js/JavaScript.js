$(document).ready(function () {
    
    $("li a").each(function () {
        console.log($(this).attr("href"))
        if ($(this).attr("href") == window.location.pathname) {

            $(this).addClass("active")
        }
    })
})