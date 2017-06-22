var banner = {
    //banner default background html page
    defaultSrc: "/statics/banner/default.html",
        //default animation background html page
        defaultAnimationSrc: "/statics/animation/anim-007-starry-sky.html",
        //banner animation background html page list
        animationList: ["anim-003-particle.html", "anim-004-welcome.html", "anim-005-fireworks.html", "anim-007-starry-sky.html", "anim-008-sky.html", "anim-009-sky.html", "anim-011-starry-sky.html"]
}

$(function () {
    var btnBannerAnimationSwitch = $("#btn_banner_close_animation");
    var isTurnedOn = btnBannerAnimationSwitch.text() === "关闭背景特效";

    initBannerAnimation();

    btnBannerAnimationSwitch.click(function () {
        isTurnedOn = btnBannerAnimationSwitch.text() === "开启背景特效";
        btnBannerAnimationSwitch.text(isTurnedOn ? "关闭背景特效" : "开启背景特效");
        toggleAnimation(isTurnedOn);
    });

    function initBannerAnimation() {
        var src = banner.defaultSrc;
        if (isTurnedOn && util.supportCanvas()) {
            src = banner.defaultAnimationSrc;
        }
        $(".banner").append('<iframe id="banner_animation" class="banner-iframe" src="' + src + '"></iframe>');
    }

    function toggleAnimation(isTurnedOn) {
        var src = banner.defaultSrc;
        if (isTurnedOn && util.supportCanvas()) {
            var rand = Math.floor(Math.random() * banner.animationList.length);
            src = '/statics/animation/' + banner.animationList[rand];
        }
        document.getElementById('banner_animation').src = src;
    }

    $("#txt_keyword").focus(function () {
        $("#searchform").addClass("search-on");
    });
    $("#txt_keyword").blur(function () {
        $("#searchform").removeClass("search-on");
    });
});