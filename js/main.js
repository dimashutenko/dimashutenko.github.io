$(document).ready( function() {

    const btn_prev = $('#btn-prev'),
    btn_next = $('#btn-next'),
    slides = document.querySelectorAll('.slide'),
    slides_wrapper = $('.slider-wrapper');

    let index=0;

    const activeSlide = n => {
        for (slide of slides){
            slide.classList.remove('active');
        }
        slides[n].classList.add('active');
    }

    const nextSlide = () => {
        if(index == slides.length - 1){
            index = 0;
            activeSlide(index);
        } else {
            index++;
            activeSlide(index);
        }
    }

    btn_next.addEventListener('click', nextSlide);





    if($(window).width() < 960)
    {
		$(window).scroll(function() {
    	    $('.').each(function(){
    	        var imagePos = $(this).offset().top;
	
    	        var topOfWindow = $(window).scrollTop();
    	        if (imagePos < topOfWindow+650) {
    	            $(this).addClass("fadeIn");
    	        }
    	    });
    	});

	}else{ //more tham 960px

		$(window).scroll(function() {
    	    $('.').each(function(){
    	        var imagePos = $(this).offset().top;
	
    	        var topOfWindow = $(window).scrollTop();
    	        if (imagePos < topOfWindow+500) {
    	            $(this).addClass("fadeIn");
    	        }
    	    });
    	});
    	
	}

});
