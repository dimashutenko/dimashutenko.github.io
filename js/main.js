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

    function nextSlide() {
        if(index == slides.length - 1){
            index = 0;
            activeSlide(index);
            slides[index].style.animation = "myFadeIn 0.7s";
        } else {
            var variable = index;
            index++;
            activeSlide(index);
            $(".active")[0].style.animation = "myFadeIn 0.7s";
        }
    }

    function prevSlide() {
        if(index == 0){
            index = slides.length - 1;
            activeSlide(index);
            slides[index].style.animation = "myFadeIn 0.7s";
        } else {
            index--;
            activeSlide(index);
            $(".active")[0].style.animation = "myFadeIn 0.7s";
        }
    }



function search_clicked() {  // ?
    alert('В разработке');
    if(document.querySelectorAll('#search')[0].style.display='none')
    {
        document.querySelectorAll('#search')[0].style.display='block';
    } else {
        document.querySelectorAll('#search')[0].style.display='none';
    }
    
}

function contacts_clicked() {
    document.querySelectorAll('.contacts')[0].classList.toggle('contacts-clicked');
    document.querySelectorAll('.contacts-extended')[0].classList.toggle('block');
}

function menu_clicked() {
    document.querySelectorAll('.menu')[0].classList.toggle('menu-clicked');
    document.querySelectorAll('.menu-extended')[0].classList.toggle('block');
}

function services_clicked() {
    document.querySelectorAll('#services-menu')[0].classList.toggle('services-clicked');
    document.querySelectorAll('.services-menu')[0].classList.toggle('block');
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

        $('body').style.display='none';
        alert('in development');

		// $(window).scroll(function() {
  //   	    $('.').each(function(){
  //   	        var imagePos = $(this).offset().top;
	
  //   	        var topOfWindow = $(window).scrollTop();
  //   	        if (imagePos < topOfWindow+500) {
  //   	            $(this).addClass("fadeIn");
  //   	        }
  //   	    });
  //   	});
    	
	}

});
