// window.onload=function() {
// 	var preloader = document.getElementById('preloader');
// 	preloader.fadeOut(300)
// };
$(document).ready(function() {
 	$("#preloader").delay(1800).fadeOut(100); //2000, 100
 	setTimeout(function() {
 		$('*').removeClass('hidden');
		$('body').removeClass('no-scroll');
	}, 500);  //1500
	$('.navigation a').on('click', function (e) {
	  if (this.hash !== '') {
	    e.preventDefault();
	    const hash = this.hash;
	    $('html, body')
	      .animate({
	        scrollTop: $(hash).offset().top
	      },800);
	  }
	});



	const menu__items = $('.menu__item');
    menu__items[0].addEventListener("mouseleave", function() {
        menu__items[0].style.animation='myframes10 0.25s ease-in-out 0s forwards';
    });
    menu__items[0].addEventListener("mouseover", function() {
        menu__items[0].style.animation='myframes1 0.25s ease-in-out 0s forwards';
    });
    $(window).scroll(function() {
        if ($(this).scrollTop() > 1){
            menu__items[0].addEventListener("mouseleave", function() {
                menu__items[0].style.animation='myframes10_sticky 0.25s ease-in-out 0s forwards';
        });
            menu__items[0].addEventListener("mouseover", function() {
                menu__items[0].style.animation='myframes1_sticky 0.25s ease-in-out 0s forwards';
            });
        }
        else{
            menu__items[0].addEventListener("mouseleave", function() {
                menu__items[0].style.animation='myframes10 0.25s ease-in-out 0s forwards';
            });
            menu__items[0].addEventListener("mouseover", function() {
                menu__items[0].style.animation='myframes1 0.25s ease-in-out 0s forwards';
            });
        }
    });

    menu__items[1].addEventListener("mouseleave", function() {
        menu__items[1].style.animation='myframes10 0.25s ease-in-out 0s forwards';
    });
    menu__items[1].addEventListener("mouseover", function() {
        menu__items[1].style.animation='myframes1 0.25s ease-in-out 0s forwards';
    });
    $(window).scroll(function() {
        if ($(this).scrollTop() > 1){
            menu__items[1].addEventListener("mouseleave", function() {
                menu__items[1].style.animation='myframes10_sticky 0.25s ease-in-out 0s forwards';
        });
            menu__items[1].addEventListener("mouseover", function() {
                menu__items[1].style.animation='myframes1_sticky 0.25s ease-in-out 0s forwards';
            });
        }
        else{
            menu__items[1].addEventListener("mouseleave", function() {
                menu__items[1].style.animation='myframes10 0.25s ease-in-out 0s forwards';
            });
            menu__items[1].addEventListener("mouseover", function() {
                menu__items[1].style.animation='myframes1 0.25s ease-in-out 0s forwards';
            });
        }
    });

    menu__items[2].addEventListener("mouseleave", function() {
        menu__items[2].style.animation='myframes10 0.25s ease-in-out 0s forwards';
    });
    menu__items[2].addEventListener("mouseover", function() {
        menu__items[2].style.animation='myframes1 0.25s ease-in-out 0s forwards';
    });
    $(window).scroll(function() {
        if ($(this).scrollTop() > 1){
            menu__items[2].addEventListener("mouseleave", function() {
                menu__items[2].style.animation='myframes10_sticky 0.25s ease-in-out 0s forwards';
        });
            menu__items[2].addEventListener("mouseover", function() {
                menu__items[2].style.animation='myframes1_sticky 0.25s ease-in-out 0s forwards';
            });
        }
        else{
            menu__items[2].addEventListener("mouseleave", function() {
                menu__items[2].style.animation='myframes10 0.25s ease-in-out 0s forwards';
            });
            menu__items[2].addEventListener("mouseover", function() {
                menu__items[2].style.animation='myframes1 0.25s ease-in-out 0s forwards';
            });
        }
    });

    menu__items[3].addEventListener("mouseleave", function() {
        menu__items[3].style.animation='myframes10 0.25s ease-in-out 0s forwards';
    });
    menu__items[3].addEventListener("mouseover", function() {
        menu__items[3].style.animation='myframes1 0.25s ease-in-out 0s forwards';
    });
    $(window).scroll(function() {
        if ($(this).scrollTop() > 1){
            menu__items[3].addEventListener("mouseleave", function() {
                menu__items[3].style.animation='myframes10_sticky 0.25s ease-in-out 0s forwards';
        });
            menu__items[3].addEventListener("mouseover", function() {
                menu__items[3].style.animation='myframes1_sticky 0.25s ease-in-out 0s forwards';
            });
        }
        else{
            menu__items[3].addEventListener("mouseleave", function() {
                menu__items[3].style.animation='myframes10 0.25s ease-in-out 0s forwards';
            });
            menu__items[3].addEventListener("mouseover", function() {
                menu__items[3].style.animation='myframes1 0.25s ease-in-out 0s forwards';
            });
        }
    });



	$('.offer a').on('click', function (e) {
	  if (this.hash !== '') {
	    e.preventDefault();
	    const hash = this.hash;
	    $('html, body')
	      .animate({
	        scrollTop: $(hash).offset().top
	      },800);
	  }
	});






	$('.menu-opener').click( function() {
		$('.menu-collapse').toggleClass('d-none');
		$('.menu-collapse').toggleClass('d-block');
		$('.menu-collapse').toggleClass('opened');
		$('.offer').toggleClass('vertical-slide');
	})


	$('.bubble a').on('click', function (e) {
	  if (this.hash !== '') {
	    e.preventDefault();
	    const hash1 = this.hash;
	    $('html, body')
	      .animate({
	        scrollTop: $(hash1).offset().top
	      },800);
	  }
	});


	$('#paralax a').on('click', function (e) {
	  if (this.hash !== '') {
	    e.preventDefault();
	    const hash1 = this.hash;
	    $('html, body')
	      .animate({
	        scrollTop: $(hash1).offset().top-50
	      },800);
	  }
	});

	if($(window).width() > 960)
    {
        $('body').parallax({
            'elements': [
                {
                    'selector': '.circle',
                    'properties': {
                        'x': {
                            'right': {
                                'initial': 25,
                                'multiplier': 0.04,
                                'unit': 'px',
                                'invert': false
                            }
                        },
                        'y': {
                            'top': {
                                'initial': 0,
                                'multiplier': 0.05,
                                'unit': 'px',
                                'invert': true
                            }
                        }
                    }
                }
            ]
        });
    } else {
        // change functionality for larger screens
    }


    $(window).scroll(function() {
        $('.timer__title').each(function(){
            var imagePos = $(this).offset().top;

            var topOfWindow = $(window).scrollTop();
            if (imagePos < topOfWindow+550) {
                $(this).addClass("fadeInUp");
            }
        });
    });
    $(window).scroll(function() {
        $('.timer__decription').each(function(){
            var imagePos = $(this).offset().top;

            var topOfWindow = $(window).scrollTop();
            if (imagePos < topOfWindow+550) {
                $(this).addClass("fadeInUp");
            }
        });
    });
    $(window).scroll(function() {
        $('.countdown').each(function(){
            var imagePos = $(this).offset().top;

            var topOfWindow = $(window).scrollTop();
            if (imagePos < topOfWindow+550) {
                $(this).addClass("fadeInUp");
            }
        });
    });


    $(window).scroll(function() {
        $('.bubble').each(function(){
            var imagePos = $(this).offset().top;

            var topOfWindow = $(window).scrollTop();
            if (imagePos < topOfWindow+400) {
                $(this).addClass("fadeInRight");
            }
        });
    });

    
    $(window).scroll(function() {
        $('.paralax-elem').each(function(){
            var imagePos = $(this).offset().top;

            var topOfWindow = $(window).scrollTop();
            if (imagePos < topOfWindow+500) {
                $(this).addClass("fadeIn");
            }
        });
    });




    $(window).scroll(function() {
        if ($(this).scrollTop() > 1){
        $('nav').addClass("sticky");
        }
        else{
        $('nav').removeClass("sticky");
        }
    });

});

