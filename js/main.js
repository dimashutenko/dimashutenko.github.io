$(document).ready( function() {

    if($(window).width() < 960)
    {
		$(window).scroll(function() {
    	    $('.go-section__left').each(function(){
    	        var imagePos = $(this).offset().top;
	
    	        var topOfWindow = $(window).scrollTop();
    	        if (imagePos < topOfWindow+650) {
    	            $(this).addClass("fadeInLeft");
    	        }
    	    });
    	});

	}else{ //more tham 960px

		$(window).scroll(function() {
    	    $('.go-section__left').each(function(){
    	        var imagePos = $(this).offset().top;
	
    	        var topOfWindow = $(window).scrollTop();
    	        if (imagePos < topOfWindow+500) {
    	            $(this).addClass("fadeInLeft");
    	        }
    	    });
    	});
    	
	}

});
