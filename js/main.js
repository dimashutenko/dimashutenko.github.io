$(document).ready( function() {

    const btn_prev =$('#btn-prev');
    const btn_next =$('#btn-next');





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
