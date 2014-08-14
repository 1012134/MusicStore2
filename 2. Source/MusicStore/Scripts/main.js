$(document).ready(function () {
    $('.bxslider').bxSlider({
        auto: true,
        autoControls: false
    });
    $("select").addClass("form-control");
    $("input[type=text]").addClass("form-control");
    $("input[type=password]").addClass("form-control");
    $("input[type=datetime]").addClass("form-control");
    $("input[type=email]").addClass("form-control");
    $("input[type=number]").addClass("form-control");
});