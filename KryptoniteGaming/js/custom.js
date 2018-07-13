/*

Qwilo - Multipurpose Responsive HTML5 Template
Author: iqonicthemes.in
Version: 1.0
Design and Developed by: iqonicthemes.in

*/
/*================================================
[  Table of contents  ]
================================================
:: Page loader
:: Back to top
:: Tooltip
:: Jarallax
:: Searchstyle Bar
:: Menu Bar
:: Sidebar Menu
:: Counters
:: CountdownTimer
:: Isotope
:: Masonry
:: Portfolio move
:: ProgressBar
:: Audiovideo
:: Accordion
:: owl carousel 
:: Wow Animation
:: Magnific Popup
:: typer
:: Contact from


======================================
[ End table content ]
======================================*/

"use strict";

/*************************
Page loader
*************************/
function preloader() {
    
    $("#load").fadeOut();
    $('#loading').delay(2000).fadeOut();

}

/*************************
Back to top
*************************/
function backtotop() {
    $('#back-to-top').fadeOut();
    $(window).scroll(function() {
        if ($(this).scrollTop() > 250) {
            $('#back-to-top').fadeIn(1500);
        } else {
            $('#back-to-top').fadeOut(500);
        }
    });
    // scroll body to 0px on click
    $('#top').on('click', function() {
        $('top').tooltip('hide');
        $('body,html').animate({
            scrollTop: 0
        }, 800);
        return false;
    });
}


/*************************
Tooltip
*************************/
function tooltip() {
    $('[data-toggle="tooltip"]').tooltip()

}


/*************************
Jarallax
*************************/
function jarallax() {
    $('.jarallax').jarallax({
        speed: 0.2
    });

}

/*************************
Menu Bar
*************************/
function megaMenu() {
    jQuery('#menu-1').megaMenu({
        // DESKTOP MODE SETTINGS
        logo_align: 'left', // align the logo left or right. options (left) or (right)
        links_align: 'left', // align the links left or right. options (left) or (right)
        socialBar_align: 'left', // align the socialBar left or right. options (left) or (right)
        searchBar_align: 'right', // align the search bar left or right. options (left) or (right)
        trigger: 'hover', // show drop down using click or hover. options (hover) or (click)
        effect: 'fade', // drop down effects. options (fade), (scale), (expand-top), (expand-bottom), (expand-left), (expand-right)
        effect_speed: 400, // drop down show speed in milliseconds
        sibling: true, // hide the others showing drop downs if this option true. this option works on if the trigger option is "click". options (true) or (false)
        outside_click_close: true, // hide the showing drop downs when user click outside the menu. this option works if the trigger option is "click". options (true) or (false)
        top_fixed: false, // fixed the menu top of the screen. options (true) or (false)
        sticky_header: true, // menu fixed on top when scroll down down. options (true) or (false)
        sticky_header_height: 200, // sticky header height top of the screen. activate sticky header when meet the height. option change the height in px value.
        menu_position: 'horizontal', // change the menu position. options (horizontal), (vertical-left) or (vertical-right)
        full_width: true, // make menu full width. options (true) or (false)
        // MOBILE MODE SETTINGS
        mobile_settings: {
            collapse: true, // collapse the menu on click. options (true) or (false)
            sibling: true, // hide the others showing drop downs when click on current drop down. options (true) or (false)
            scrollBar: true, // enable the scroll bar. options (true) or (false)
            scrollBar_height: 400, // scroll bar height in px value. this option works if the scrollBar option true.
            top_fixed: false, // fixed menu top of the screen. options (true) or (false)
            sticky_header: true, // menu fixed on top when scroll down down. options (true) or (false)
            sticky_header_height: 200 // sticky header height top of the screen. activate sticky header when meet the height. option change the height in px value.
        }
    });
    $('#menu-2').megaMenu({
        // DESKTOP MODE SETTINGS
        logo_align: 'left', // align the logo left or right. options (left) or (right)
        links_align: 'left', // align the links left or right. options (left) or (right)
        socialBar_align: 'left', // align the socialBar left or right. options (left) or (right)
        searchBar_align: 'right', // align the search bar left or right. options (left) or (right)
        trigger: 'hover', // show drop down using click or hover. options (hover) or (click)
        effect: 'fade', // drop down effects. options (fade), (scale), (expand-top), (expand-bottom), (expand-left), (expand-right)
        effect_speed: 400, // drop down show speed in milliseconds
        sibling: true, // hide the others showing drop downs if this option true. this option works on if the trigger option is "click". options (true) or (false)
        outside_click_close: true, // hide the showing drop downs when user click outside the menu. this option works if the trigger option is "click". options (true) or (false)
        top_fixed: false, // fixed the menu top of the screen. options (true) or (false)
        sticky_header: false, // menu fixed on top when scroll down down. options (true) or (false)
        sticky_header_height: 200, // sticky header height top of the screen. activate sticky header when meet the height. option change the height in px value.
        menu_position: 'vertical-right', // change the menu position. options (horizontal), (vertical-left) or (vertical-right)
        full_width: false, // make menu full width. options (true) or (false)
        // MOBILE MODE SETTINGS
        mobile_settings: {
            collapse: true, // collapse the menu on click. options (true) or (false)
            sibling: true, // hide the others showing drop downs when click on current drop down. options (true) or (false)
            scrollBar: true, // enable the scroll bar. options (true) or (false)
            scrollBar_height: 400, // scroll bar height in px value. this option works if the scrollBar option true.
            top_fixed: false, // fixed menu top of the screen. options (true) or (false)
            sticky_header: false, // menu fixed on top when scroll down down. options (true) or (false)
            sticky_header_height: 200 // sticky header height top of the screen. activate sticky header when meet the height. option change the height in px value.
        }
    });
    $('#menu-3').megaMenu({
        // DESKTOP MODE SETTINGS
        logo_align: 'left', // align the logo left or right. options (left) or (right)
        links_align: 'left', // align the links left or right. options (left) or (right)
        socialBar_align: 'left', // align the socialBar left or right. options (left) or (right)
        searchBar_align: 'right', // align the search bar left or right. options (left) or (right)
        trigger: 'hover', // show drop down using click or hover. options (hover) or (click)
        effect: 'fade', // drop down effects. options (fade), (scale), (expand-top), (expand-bottom), (expand-left), (expand-right)
        effect_speed: 400, // drop down show speed in milliseconds
        sibling: true, // hide the others showing drop downs if this option true. this option works on if the trigger option is "click". options (true) or (false)
        outside_click_close: true, // hide the showing drop downs when user click outside the menu. this option works if the trigger option is "click". options (true) or (false)
        top_fixed: false, // fixed the menu top of the screen. options (true) or (false)
        sticky_header: false, // menu fixed on top when scroll down down. options (true) or (false)
        sticky_header_height: 200, // sticky header height top of the screen. activate sticky header when meet the height. option change the height in px value.
        menu_position: 'vertical-left', // change the menu position. options (horizontal), (vertical-left) or (vertical-right)
        full_width: false, // make menu full width. options (true) or (false)
        // MOBILE MODE SETTINGS
        mobile_settings: {
            collapse: true, // collapse the menu on click. options (true) or (false)
            sibling: true, // hide the others showing drop downs when click on current drop down. options (true) or (false)
            scrollBar: true, // enable the scroll bar. options (true) or (false)
            scrollBar_height: 400, // scroll bar height in px value. this option works if the scrollBar option true.
            top_fixed: false, // fixed menu top of the screen. options (true) or (false)
            sticky_header: false, // menu fixed on top when scroll down down. options (true) or (false)
            sticky_header_height: 200 // sticky header height top of the screen. activate sticky header when meet the height. option change the height in px value.
        }
    });
}

/*************************
Sidebar Menu
*************************/
function sidebar_menu() {
    $(".sider-bt").on("click", function() {
        $(".sider-bt").toggleClass("cross");
        $(".sidebar-menu").toggleClass("sidebar-open");
    });

}

/*************************
Counters
*************************/
function counters() {
    $('.timer').countTo();

}

/*************************
CountdownTimer
*************************/
function countdownTimer() {
    $('#countdown').countdown({
        date: '10/01/2018 23:59:59',
        offset: -8,
        day: 'Day',
        days: 'Days'
    }, function() {
        alert('Done!');
    });
    $('#iq-countdown1').countdown({
        date: '10/01/2018 23:59:59',
        offset: -8,
        day: 'Day',
        days: 'Days'
    }, function() {
        alert('Done!');
    });

}

/*************************
Isotope
*************************/
function isotope() {
    var $isotope = $(".isotope"),
        $itemElement = '.iq-grid-item',
        $filters = $('.isotope-filters');
    if ($isotope) {
        $isotope.isotope({
            resizable: true,
            itemSelector: $itemElement,
            masonry: {
                gutterWidth: 10
            }
        });
        $filters.on('click', 'button', function() {
            var $val = $(this).attr('data-filter');
            $isotope.isotope({
                filter: $val
            });
            $filters.find('.active').removeClass('active');
            $(this).addClass('active');
        });
    }

}

/*************************
Masonry
*************************/
function masonry() {
    var $masonry = $('.iq-masonry-block .iq-masonry'),
        $itemElement = '.iq-masonry-block .iq-masonry-item',
        $filters = $('.iq-masonry-block .isotope-filters');
    if ($masonry) {
        $masonry.isotope({
            percentPosition: true,
            resizable: true,
            itemSelector: $itemElement,
            masonry: {
                gutterWidth: 0
            }
        });
        // bind filter button click
        $filters.on('click', 'button', function() {
            var filterValue = $(this).attr('data-filter');
            $masonry.isotope({
                filter: filterValue
            });
        });

        $filters.each(function(i, buttonGroup) {
            var $buttonGroup = $(buttonGroup);
            $buttonGroup.on('click', 'button', function() {
                $buttonGroup.find('.active').removeClass('active');
                $(this).addClass('active');
            });
        });
    }

}

/*************************
Portfolio move
*************************/
function portfolio_move() {
    $('.iq-portfolio-05').each(function() {
        $(this).hoverdir({});
    });

}


/*************************
ProgressBar
*************************/
function progressBar() {
    jQuery('.progress-bar').each(function(i, elem) {
        var $elem = $(this),
            percent = $elem.attr('data-percent') || "100",
            delay = $elem.attr('data-delay') || "100",
            type = $elem.attr('data-type') || "%";

        if (!$elem.hasClass('progress-animated')) {
            $elem.css({
                'width': '0%'
            });
        }

        var progressBarRun = function() {
            $elem.animate({
                'width': percent + '%'
            }, 'easeInOutCirc').addClass('progress-animated');

            $elem.delay(delay).append('<span class="progress-type animated fadeIn">' + type + '</span><span class="progress-number animated fadeIn">' + percent + '</span>');
        };

        $(elem).appear(function() {
            setTimeout(function() {
                progressBarRun();
            }, delay);
        });
    });
}




/*************************
Audio video
*************************/
function audiovideo() {
    if ($(".audio-video").length != 0) {
        $('audio,video').mediaelementplayer();
    }

}



/*************************
Accordion
*************************/
function accordion() {
    var $acpanel = $(".iq-accordion .iq-ad-block > .ad-details"),
        $acsnav = $(".iq-accordion .iq-ad-block > .ad-title");

    $acpanel.hide().first().slideDown("easeOutExpo");
    $acsnav.first().addClass("iq-active");
    $acsnav.on('click', function() {
        var $this = $(this).next(".ad-details");
        $acsnav.parent().removeClass("iq-active");
        $(this).parent().addClass("iq-active");
        $acpanel.not($this).slideUp("easeInExpo");
        $(this).next().slideDown("easeOutExpo");
        return false;
    });

}


/*************************
Wow Animation
*************************/
function wowanimation() {
    var wow = new WOW({
        boxClass: 'wow',
        animateClass: 'animated',
        offset: 0,
        mobile: false,
        live: true
    });
    wow.init();
}


/*************************
Magnific Popup
*************************/

function popupgallery() {
    $('.popup-gallery').magnificPopup({
        delegate: 'a.popup-img',
        type: 'image',
        tLoading: 'Loading image #%curr%...',
        mainClass: 'mfp-img-mobile',
        gallery: {
            enabled: true,
            navigateByImgClick: true,
            preload: [0, 1] // Will preload 0 - before current, and 1 after the current image
        },
    });

    $('.popup-youtube, .popup-vimeo, .popup-gmaps').magnificPopup({
        disableOn: 700,
        type: 'iframe',
        mainClass: 'mfp-fade',
        removalDelay: 160,
        preloader: false,
        fixedContentPos: false
    });

}

/*************************
  typer
*************************/
function typer() {
    var foo;
    var win = $(window),
        foo = $('#typer');
    if (foo !== undefined)
        foo.typer(['<h6 class="iq-tw-6"><span class="iq-font-green">Web</span> Developer</h6>', '<h6 class="iq-tw-6">Web <span class="iq-font-green">Designer</span></h6>', '<h6 class="iq-tw-6"><span class="iq-font-green">Frontend</span> Developer</h6>']);

}


/*************************
  Contact from
*************************/
function contactfrom() {
    $('#contact').submit(function(e) {
        var flag = 0;
        e.preventDefault(); // Prevent Default Submission
        $('.require').each(function() {
            if ($.trim($(this).val()) == '') {
                $(this).css("border", "1px solid red");
                e.preventDefault(); // Prevent Default Submission
                flag = 1;
            } else {
                $(this).css("border", "1px solid grey");
                flag = 0;
            }
        });

        if (grecaptcha.getResponse() == "") {
            flag = 1;
            alert('Please verify Recaptch');

        } else {
            flag = 0;
        }

        if (flag == 0) {
            $.ajax({
                    url: 'contact-form.php',
                    type: 'POST',
                    data: $("#contact").serialize() // it will serialize the form data
                })
                .done(function(data) {
                    $("#result").html('Form was successfully submitted.');
                    $('#contact')[0].reset();
                })
                .fail(function() {
                    alert('Ajax Submit Failed ...');
                });
        }

    });
}

/*************************
All function are called here 
*************************/
$(document).ready(function() {
    megaMenu(),
    backtotop(),
    tooltip(),
    jarallax(),
    popupgallery(),
    sidebar_menu(),
    counters(),
    countdownTimer(),
    wowanimation(),
    audiovideo(),
    accordion(),
    
    portfolio_move();
});


$(window).on('load', function() {
    preloader(),
    isotope(),
    masonry(),
    contactfrom(),
    progressBar(),
    typer();
});