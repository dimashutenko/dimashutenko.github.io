$(document).ready( function() {
	$('.element2').on('click', function(){
		$(this).toggleClass('disappear');
		$('.element4').toggleClass('running');
		$('.interaction-elem').toggleClass('running')
	})
	$('.pause-elem').on('click', function(){
		$(this).toggleClass('paused');
		$('.element').toggleClass('paused')
	})
	$('.interaction-elem').on('mouseenter', function(){
		$('h5').addClass('bigger')
	})
	$('.interaction-elem').on('mouseleave',function(){
		$('h5').removeClass('bigger');
	})
	// 
	//
	//   interaction
	//
	
})
