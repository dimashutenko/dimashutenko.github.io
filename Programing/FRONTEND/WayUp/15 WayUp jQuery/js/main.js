$(document).ready( function() {

	function redden (){
		var btn = $('#btn'); //finds first match
		
		btn.click(function (){
			$('.title').css('color', 'red')
		})
	}
	redden();
})
