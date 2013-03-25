$(document).ready(function () {
    // side bar
    $('.side-navigation-list').affix({
//        offset: {
//            top: function () { return $(window).width() <= 980 ? 290 : 210 }
//          , bottom: 270
//        }
    })

    // button state demo
    $('#fat-btn').click(function () {
        var btn = $(this)
        btn.bootstrapButton('loading')
        setTimeout(function () {
            btn.bootstrapButton('reset')
        }, 3000)
    })

});

