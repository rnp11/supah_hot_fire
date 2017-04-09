$(window).load(function () {
    $(".btn-nav").on("click tap", function () {
        $(".nav-container").toggleClass("showNav hideNav").removeClass("hidden");
        $(this).toggleClass("animated");
    });
});