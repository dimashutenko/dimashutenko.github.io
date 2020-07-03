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
    	$(window).scroll(function() {
    	    $('.go-section__right').each(function(){
    	        var imagePos = $(this).offset().top;
	
    	        var topOfWindow = $(window).scrollTop();
    	        if (imagePos < topOfWindow+700) {
    	            $(this).addClass("fadeInRight");
    	        }
    	    });
    	});
    	$(window).scroll(function() {
    	    $('.go-section__description span').each(function(){
    	        var imagePos = $(this).offset().top;
	
    	        var topOfWindow = $(window).scrollTop();
    	        if (imagePos < topOfWindow+450) {
    	            $(this).addClass("highlighted");
    	        }
    	    });
    	});
    	$(window).scroll(function() {
    	    $('.section__title').each(function(){
    	        var imagePos = $(this).offset().top;
    	        var topOfWindow = $(window).scrollTop();
    	        if (imagePos < topOfWindow+700) {
    	            $(this).addClass("fadeInUp");
    	        }
    	    });
    	});

        $(window).scroll(function() {
            $('.product-1-bg-part').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+700) {
                    $(this).addClass("fadeInRight");
                }
            });
        });
        $(window).scroll(function() {
            $('.product-2-bg-part').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+700) {
                    $(this).addClass("fadeInRight");
                }
            });
        });
        $(window).scroll(function() {
            $('.product-3-bg-part').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+700) {
                    $(this).addClass("fadeInRight");
                }
            });
        });
        $(window).scroll(function() {
            $('.product-4-bg-part').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+700) {
                    $(this).addClass("fadeInRight");
                }
            });
        });
        $(window).scroll(function() {
            $('.product-5-bg-part').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+700) {
                    $(this).addClass("fadeInRight");
                }
            });
        });
        $(window).scroll(function() {
            $('.product-6-bg-part').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+700) {
                    $(this).addClass("fadeInRight");
                }
            });
        });
        $(window).scroll(function() {
            $('.product-7-bg-part').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+700) {
                    $(this).addClass("fadeInRight");
                }
            });
        });
        $(window).scroll(function() {
            $('.product-8-bg-part').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+700) {
                    $(this).addClass("fadeInRight");
                }
            });
        });

        $(window).scroll(function() {
            $('.list__item-1-left').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+700) {
                    $(this).addClass("fadeInLeft");
                }
            });
        });
        $(window).scroll(function() {
            $('.list__item-1-right').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+700) {
                    $(this).addClass("fadeInRight");
                    $('.list__item-1-right').removeClass("animated");
                }
            });
        });
        $(window).scroll(function() {
            $('.list__item-2-left').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+700) {
                    $(this).addClass("fadeInLeft");
                    
                    setTimeout(function(){
                      $('.list__item-2-left').removeClass("animated");
                    }, 1000);
                }
            });
        });
        $(window).scroll(function() {
            $('.list__item-2-right').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+700) {
                    $(this).addClass("fadeInRight");
                }
            });
        });
        $(window).scroll(function() {
            $('.list__item-3-left').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+700) {
                    $(this).addClass("fadeInLeft");
                }
            });
        });
        $(window).scroll(function() {
            $('.list__item-3-right').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+700) {
                    $(this).addClass("fadeInRight");
                    
                    setTimeout(function(){
                      $('.list__item-3-right').removeClass("animated");
                    }, 1000);
                }
            });
        });
    	$(window).scroll(function() {
    	    $('.list__item-4').each(function(){
    	        var imagePos = $(this).offset().top;
	
    	        var topOfWindow = $(window).scrollTop();
    	        if (imagePos < topOfWindow+700) {
    	            $(this).addClass("fadeInUp");
    	        }
    	    });
    	});
        $(window).scroll(function() {
            $('.list__item-5-left').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+700) {
                    $(this).addClass("fadeInLeft");
                    
                    setTimeout(function(){
                      $('.list__item-5-left').removeClass("animated");
                    }, 1000);
                }
            });
        });
        $(window).scroll(function() {
            $('.list__item-5-right').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+700) {
                    $(this).addClass("fadeInRight");
                }
            });
        });
    	$(window).scroll(function() {
    	    $('.list__item-6').each(function(){
    	        var imagePos = $(this).offset().top;
	
    	        var topOfWindow = $(window).scrollTop();
    	        if (imagePos < topOfWindow+700) {
    	            $(this).addClass("fadeInUp");
    	        }
    	    });
    	});
        $(window).scroll(function() {
            $('.lesson-bottom').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+650) {
                    $(this).addClass("fadeIn");
                }
            });
        });
    	$(window).scroll(function() {
    	    $('.footer').each(function(){
    	        var imagePos = $(this).offset().top;
	
    	        var topOfWindow = $(window).scrollTop();
    	        if (imagePos < topOfWindow+750) {
    	            $(this).addClass("fadeIn");
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
    	$(window).scroll(function() {
    	    $('.go-section__right').each(function(){
    	        var imagePos = $(this).offset().top;
	
    	        var topOfWindow = $(window).scrollTop();
    	        if (imagePos < topOfWindow+550) {
    	            $(this).addClass("fadeInRight");
    	        }
    	    });
    	});
    	$(window).scroll(function() {
    	    $('.go-section__description span').each(function(){
    	        var imagePos = $(this).offset().top;
	
    	        var topOfWindow = $(window).scrollTop();
    	        if (imagePos < topOfWindow+350) {
    	            $(this).addClass("highlighted");
    	        }
    	    });
    	});
    	$(window).scroll(function() {
    	    $('.section__title').each(function(){
    	        var imagePos = $(this).offset().top;
	
    	        var topOfWindow = $(window).scrollTop();
    	        if (imagePos < topOfWindow+550) {
    	            $(this).addClass("fadeInUp");
    	        }
    	    });
    	});
        $(window).scroll(function() {
            $('.product-1-bg-part').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+500) {
                    $(this).addClass("fadeInRight");
                }
            });
        });
        $(window).scroll(function() {
            $('.product-2-bg-part').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+500) {
                    $(this).addClass("fadeInRight");
                }
            });
        });
        $(window).scroll(function() {
            $('.product-3-bg-part').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+500) {
                    $(this).addClass("fadeInRight");
                }
            });
        });
        $(window).scroll(function() {
            $('.product-4-bg-part').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+500) {
                    $(this).addClass("fadeInRight");
                }
            });
        });
        $(window).scroll(function() {
            $('.product-5-bg-part').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+500) {
                    $(this).addClass("fadeInRight");
                }
            });
        });
        $(window).scroll(function() {
            $('.product-6-bg-part').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+500) {
                    $(this).addClass("fadeInRight");
                }
            });
        });
        $(window).scroll(function() {
            $('.product-7-bg-part').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+500) {
                    $(this).addClass("fadeInRight");
                }
            });
        });
        $(window).scroll(function() {
            $('.product-8-bg-part').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+500) {
                    $(this).addClass("fadeInRight");
                }
            });
        });
    	$(window).scroll(function() {
    	    $('.list__item-1-left').each(function(){
    	        var imagePos = $(this).offset().top;
	
    	        var topOfWindow = $(window).scrollTop();
    	        if (imagePos < topOfWindow+500) {
    	            $(this).addClass("fadeInLeft");
    	        }
    	    });
    	});
        $(window).scroll(function() {
            $('.list__item-1-right').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+500) {
                    $(this).addClass("fadeInRight");
                    
                    setTimeout(function(){
                      $('.list__item-1-right').removeClass("animated");
                    }, 1000);
                }
            });
        });
        $(window).scroll(function() {
            $('.list__item-2-right').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+500) {
                    $(this).addClass("fadeInRight");
                }
            });
        });
        $(window).scroll(function() {
            $('.list__item-2-left').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+500) {
                    $(this).addClass("fadeInLeft");
                    
                    setTimeout(function(){
                      $('.list__item-2-left').removeClass("animated");
                    }, 1000);
                }
            });
        });
        $(window).scroll(function() {
            $('.list__item-3-left').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+500) {
                    $(this).addClass("fadeInLeft");
                }
            });
        });
        $(window).scroll(function() {
            $('.list__item-3-right').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+500) {
                    $(this).addClass("fadeInRight");
                    
                    setTimeout(function(){
                      $('.list__item-3-right').removeClass("animated");
                    }, 1000);
                }
            });
        });
    	$(window).scroll(function() {
    	    $('.list__item-4').each(function(){
    	        var imagePos = $(this).offset().top;
	
    	        var topOfWindow = $(window).scrollTop();
    	        if (imagePos < topOfWindow+500) {
    	            $(this).addClass("fadeInUp");
    	        }
    	    });
    	});
        $(window).scroll(function() {
            $('.list__item-5-right').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+500) {
                    $(this).addClass("fadeInRight");
                }
            });
        });
        $(window).scroll(function() {
            $('.list__item-5-left').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+500) {
                    $(this).addClass("fadeInLeft");
                    
                    setTimeout(function(){
                      $('.list__item-5-left').removeClass("animated");
                    }, 1000);
                }
            });
        });
    	$(window).scroll(function() {
    	    $('.list__item-6').each(function(){
    	        var imagePos = $(this).offset().top;
	
    	        var topOfWindow = $(window).scrollTop();
    	        if (imagePos < topOfWindow+500) {
    	            $(this).addClass("fadeInUp");
    	        }
    	    });
    	});
        $(window).scroll(function() {
            $('.lesson-bottom').each(function(){
                var imagePos = $(this).offset().top;
    
                var topOfWindow = $(window).scrollTop();
                if (imagePos < topOfWindow+500) {
                    $(this).addClass("fadeIn");
                }
            });
        });
    	$(window).scroll(function() {
    	    $('.footer').each(function(){
    	        var imagePos = $(this).offset().top;
	
    	        var topOfWindow = $(window).scrollTop();
    	        if (imagePos < topOfWindow+650) {
    	            $(this).addClass("fadeIn");
    	        }
    	    });
    	});
	}

})
