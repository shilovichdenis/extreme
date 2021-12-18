// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
$(document).ready(function () {
    $('.galery__list').slick({
        slidesToShow: 3,
        centerMode: true,
        arrows: false,
        autoplay: true,
        autoplaySpeed: 3000,
    }
    );
    $('.coach__list').slick({
        slidesToShow: 2,
        centerMode: true,
        arrows: false,
    }
    );
});
