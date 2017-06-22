var obj = {};
var g = {
    
}
var _window = $(window);
var timeoutKey = -1;
function showButton() {
    if (timeoutKey) {
        window.clearTimeout(timeoutKey);
    }
    timeoutKey = window.setTimeout(function () {
        if (_window.scrollTop() < 100) {
            obj.backToTop.fadeOut();
        }
        else {
            obj.backToTop.fadeIn();
        }
    }, 100);
};

$(function () {
    //global jquery object begin
    obj.backToTop = $(".back-to-top");//back to top button
    obj.header = $('header');//header
    //global jquery object end
    $('[data-toggle="tooltip"]').tooltip();

    $(window).scroll(function () {
        var distanceY = $(this).scrollTop();
        var shrinkOn = 100;
        if (distanceY > shrinkOn) {
            obj.header.addClass('smaller');
        } else {
            if (obj.header.hasClass("smaller")) {
                obj.header.removeClass('smaller');
            }
        }

        showButton();
        obj.backToTop.click(function () {
            $("html, body").stop().animate({
                scrollTop: 0
            }, 300, "linear");
        });
    });
});

var util = {
    //check if browser support canvas
    supportCanvas: function () {
        var elem = document.createElement('canvas');
        return !!(elem.getContext && elem.getContext('2d'));
    }
};