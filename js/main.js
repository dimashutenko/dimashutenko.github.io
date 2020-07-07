const btn_prev = $('#btn-prev'),
    btn_next = $('#btn-next'),
    slides = document.querySelectorAll('.slide'),
    slides_wrapper = $('.slider-wrapper');

    let index=0;

    function wait(ms){
       var start = new Date().getTime();
       var end = start;
       while(end < start + ms) {
         end = new Date().getTime();
      }
    }

    const activeSlide = n => {
        for (slide of slides){
            slide.classList.remove('active');
        }
        slides[n].classList.add('active');
    }

    function nextSlide() {
        if(index == slides.length - 1){
            index = 0;
            activeSlide(index);
            slides[index].style.animation = "slide-to-left 0.7s";
        } else {
            var variable = index;
            index++;
            activeSlide(index);
            $(".active")[0].style.animation = "slide-to-left 0.7s";
        }
    }

    function prevSlide() {
        if(index == 0){
            index = slides.length - 1;
            activeSlide(index);
            slides[index].style.animation = "slide-to-right 0.7s";
        } else {
            index--;
            activeSlide(index);
            $(".active")[0].style.animation = "slide-to-right 0.7s";
        }
    }


$(document).ready( function() {

    

    // btn_next.addEventListener('click', nextSlide);





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
