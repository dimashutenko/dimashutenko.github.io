//alert('hi')
//prompt('question', 'users input')
// var (or let )variable to declare
function redden (){
	var btn = document.querySelector('#btn'); //finds first match
	
	function act(){
		var array = document.querySelectorAll('h1'); //finds everything that matches
		for(var i = 0; i < array.length; i++ ) {
			array[i].classList.add('red'); 
		}
	}
	btn.addEventListener('click', act)
}

redden();