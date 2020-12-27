$(function () {
    $('.menu-open').click(function () {
        $('.menu-collapse').toggleClass('d-none');
        $('.menu-collapse').toggleClass('opened');
    });

    $('.go_to').click( function(){ // ловим клик по ссылке с классом go_to
        var scroll_el = $(this).attr('href'); // возьмем содержимое атрибута href, должен быть селектором, т.е. например начинаться с # или .
        if ($(scroll_el).length != 0) { // проверим существование элемента чтобы избежать ошибки
            $('html, body').animate({ scrollTop: $(scroll_el).offset().top }, 1500); // анимируем скроолинг к элементу scroll_el
        }
        return false; // выключаем стандартное действие
    });

    // Подключение счетчика: Старт
    $(function(){
        var current_date = new Date();// текущая дата
        current_date.setDate(current_date.getDate())
        curDay = current_date.getDate(),
        curMonth = current_date.getMonth(),
        curYear = current_date.getFullYear();

        $('#counter1').countMe(curYear, curMonth, curDay+1, '#counter1');
    });
    // Подключение счетчика: Финиш

    if($(window).width() > 960)
    {
        $('body').parallax({
            'elements': [
                {
                    'selector': '.circle',
                    'properties': {
                        'x': {
                            'right': {
                                'initial': 0,
                                'multiplier': 0.04,
                                'unit': 'px',
                                'invert': false
                            }
                        },
                        'y': {
                            'top': {
                                'initial': 0,
                                'multiplier': 0.1,
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

    // Animation init
    $(window).scroll(function() {
        $('.timer').each(function(){
            var imagePos = $(this).offset().top;

            var topOfWindow = $(window).scrollTop();
            if (imagePos < topOfWindow+650) {
                $(this).addClass("fadeInLeft");
            }
        });
    });
    $(window).scroll(function() {
        $('.finish-title').each(function(){
            var imagePos = $(this).offset().top;

            var topOfWindow = $(window).scrollTop();
            if (imagePos < topOfWindow+650) {
                $(this).addClass("fadeInUp");
            }
        });
    });

    // Sticky nav
    $(window).scroll(function() {
        if ($(this).scrollTop() > 600){
            $('nav').addClass("sticky");
        }
        else{
            $('nav').removeClass("sticky");
        }
    });

    //ArcticModal init
    $('.parallax-btn').click(function (e) {
        e.preventDefault();
        $('#exampleModal').arcticmodal();
    });

    // Slick slider
    $('.big-slider').slick({
        // settings
        arrows:true,
        nextArrow: '<button type="button" class="slick-next"><i class="fa fa-angle-right"></i></button>',
        prevArrow: '<button type="button" class="slick-prev"><i class="fa fa-angle-left"></i></button>',
        dots: true,
        responsive: [
            {
                breakpoint: 960,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1,
                    arrows: false
                }
            }
        ]
    });

    $('.car-slider').slick({
        // settings
        arrows:true,
        nextArrow: '<button type="button" class="slick-next"><i class="fa fa-arrow-alt-circle-right"></i></button>',
        prevArrow: '<button type="button" class="slick-prev"><i class="fa fa-arrow-alt-circle-left"></i></button>',
        dots: false,
        infinite: true,
        slidesToShow: 4,
        slidesToScroll: 1,
        responsive: [
            {
                breakpoint: 960,
                settings: {
                    slidesToShow: 3,
                    slidesToScroll: 3,
                    arrows: false
                }
            },
            {
                breakpoint: 576,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1,
                    arrows: false
                }
            }
        ]
    });


    // Form send
        $('[data-submit]').on('click', function(e){
            e.preventDefault();
            $(this).parent('form').submit();
        })
        $.validator.addMethod(
            "regex",
            function(value, element, regexp) {
                var re = new RegExp(regexp);
                return this.optional(element) || re.test(value);
            },
            "Please check your input."
        );
        function valEl(el){

            el.validate({
                rules:{
                    tel:{
                        required:true,
                        regex: '^([\+]+)*[0-9\x20\x28\x29\-]{5,20}$'
                    },
                    name:{
                        required:true
                    },
                    email:{
                        required:true,
                        email:true
                    }
                },
                messages:{
                    tel:{
                        required:'Поле обязательно для заполнения',
                        regex:'Телефон может содержать символы + - ()'
                    },
                    name:{
                        required:'Поле обязательно для заполнения',
                    },
                    email:{
                        required:'Поле обязательно для заполнения',
                        email:'Неверный формат E-mail'
                    }
                },
                submitHandler: function (form) {
                    $('#loader').fadeIn();
                    var $form = $(form);
                    var $formId = $(form).attr('id');
                    switch($formId){
                        case'goToNewPage':
                            $.ajax({
                                type: 'POST',
                                url: $form.attr('action'),
                                data: $form.serialize(),
                            })
                                .always(function (response) {
                                    //ссылка на страницу "спасибо" - редирект
                                    location.href='https://wayup.in/lm/landing-page-marathon/success';
                                    //отправка целей в Я.Метрику и Google Analytics
                                    ga('send', 'event', 'masterklass7', 'register');
                                    yaCounter27714603.reachGoal('lm17lead');
                                });
                            break;
                        case'popupResult':
                            $.ajax({
                                type: 'POST',
                                url: $form.attr('action'),
                                data: $form.serialize(),
                            })
                                .always(function (response) {
                                    setTimeout(function (){
                                        $('#loader').fadeOut();
                                    },800);
                                    setTimeout(function (){
                                        $('#overlay').fadeIn();
                                        $form.trigger('reset');
                                        //строки для остлеживания целей в Я.Метрике и Google Analytics
                                    },1100);
                                    $('#overlay').on('click', function(e) {
                                        $('#overlay').fadeOut();
                                    });


                                });
                            break;
                    }
                    return false;
                }
            })
        }

        $('.js-form').each(function() {
            valEl($(this));
        });
        $('[data-scroll]').on('click', function(){
            $('html, body').animate({
                scrollTop: $( $.attr(this, 'data-scroll') ).offset().top
            }, 2000);
            event.preventDefault();
        })




    // $(window).on('load', function () {
    //     var $preloader = $('#page-preloader'),
    //         $spinner   = $preloader.find('.windows8');
    //     $spinner.fadeOut();
    //     $preloader.delay(350).fadeOut('slow');
    // });
});
