///////////////////////
//     FADE OUTS     //
///////////////////////
$('#sign-in-form-container').fadeOut(0);

///////////////////////
//     DOC READY     //
///////////////////////
$(document).ready(function () {
    //SETS WELCOME SCREEN TO USER'S SCREEN SIZE
    var screenHeight = $(window).innerHeight();
    var screenWidth = $(window).width();
    $('.full-screen-container, #price-content-container').css({
        'height': screenHeight,
        'width': screenWidth
    });
});

//////////////////////////
//     WINDOWS SIZE     //
//////////////////////////
$(window).resize(function () {
    //SETS WELCOME SCREEN TO USER'S SCREEN SIZE
    var screenHeight = $(window).height();
    var screenWidth = $(window).width();
    $('.full-screen-container, #price-content-container').css({
        'height': screenHeight,
        'width': screenWidth
    });
});

//HAMBURGUR ICON TOGGLE
$('#ham-icon-container').click(function () {
    if ($('#ham-mid').width() > 0) {
        if ($('.ham:animated').length > 0) {
            //DO NOTHING
        } else {
            $('#ham-mid').animate({
                'width': 0,
                'left': '50%'
            }, 600, 'swing', function () {
                $('#ham-top').css({
                    'transform': 'rotate(-45deg)',
                    'top': 'calc(50% - 2px)'
                });
                $('#ham-bot').css({
                    'transform': 'rotate(45deg)',
                    'bottom': 'calc(50% - 2px)'
                });
            });
            $('#dropdown-menu').css({
                'left': '-5%',
                'opacity': 1
            });
        }
    } else {
        if ($('.ham:animated').length > 0) {
            //DO NOTHING
        } else {
            $('#ham-top').css({
                'transform': 'rotate(0deg)',
                'top': 0
            });
            $('#ham-bot').css({
                'transform': 'rotate(0deg)',
                'bottom': 0
            });
            $('#ham-mid').delay(700).animate({
                'width': '76%',
                'left': '12%'
            }, 600, 'swing');
            $('#dropdown-menu').css({
                'left': '50%',
                'opacity': 0
            });
        }
    }
});

/////////////////////////////
//       QUICK LINKS       //
/////////////////////////////
$('.main-quick-link').hover(function () {
    $(this).find('.quick-link-left-background').css({
        'width': '50%',
        'left' : '0%'
    });
    $(this).find('.quick-link-text-small').css('color', '#272b33');
    $(this).find('.quick-link-text-big').css('color', '#272b33');
    $(this).find('.quick-link-right-background').css('width', '50%');
}, function () {
    $(this).find('.quick-link-left-background').css({
        'width': '0%',
        'left': '50%'
    });
    $(this).find('.quick-link-text-small').css('color', '#e5e6e8');
    $(this).find('.quick-link-text-big').css('color', '#e5e6e8');
    $(this).find('.quick-link-right-background').css('width', '0%');
});

////////////////////////////
//     SIGN IN TOGGLE     //
////////////////////////////
var openToggle = false;
$('#sign-in-link').click(function () {
    if (openToggle == false) {
        $('#sign-in-container').css('height', '100%');
        $('#sign-in-wrapper').css('top', '30%');
        $('#sign-in-form-container').fadeIn(1200);
        $('#main-quick-link-container').fadeOut(600);
        openToggle = true;
    } else if (openToggle == true) {
        $('#sign-in-form-container').fadeOut(400);
        $('#sign-in-wrapper').css('top', '70%');
        $('#sign-in-container').css('height', '10%');
        $('#main-quick-link-container').fadeIn(1200);
        openToggle = false;
    }
});	
