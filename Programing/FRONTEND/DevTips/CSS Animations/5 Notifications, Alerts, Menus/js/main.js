$(document).ready( function() {
	$('.notifications-bar__item').on('click', function(){
		$(this).addClass('is-active').siblings().removeClass('is-active');
		$('.item__notifications').removeClass('flex');
	})
	$('.relative').on('mouseenter', function(){
		$('.item__notifications').addClass('flex');
	})
	$('.notifications-bar__item').on('mouseleave', function(){
		$(this).removeClass('is-active');
	})
	$('.relative').on('mouseleave', function(){
		$('.item__notifications').removeClass('flex');
	})
})
