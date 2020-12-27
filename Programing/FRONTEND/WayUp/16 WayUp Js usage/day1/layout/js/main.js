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







    // $(window).on('load', function () {
    //     var $preloader = $('#page-preloader'),
    //         $spinner   = $preloader.find('.windows8');
    //     $spinner.fadeOut();
    //     $preloader.delay(350).fadeOut('slow');
    // });
});
