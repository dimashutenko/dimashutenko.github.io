$(document).ready( function() {
	$('.notifications-bar__item').on('click', function(){
		$(this).addClass('is-active').siblings().removeClass('is-active');
	})
	$('.notifications-bar__item').on('mouseleave', function(){
		$(this).removeClass('is-active');
	})
	// $('.i4').on('click', function(){
	// 	$(this).toggleClass('run');
	// })
	// $('.i4').on('mouseleave', function(){
	// 	$(this).removeClass('run');
	// })
})
