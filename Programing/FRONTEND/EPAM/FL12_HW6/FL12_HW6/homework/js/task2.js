var reload = false;
var a = Number(prompt('a='));
if(isNaN(a) || a === null){
	alert('Invalid input data');
	location.reload(true); 
}
var b = Number(prompt('b='));
if(isNaN(b)|| b === null){
	alert('Invalid input data');
	location.reload(true); 
}
var c = Number(prompt('c='));
if(isNaN(c)|| c === null){
	alert('Invalid input data');
	location.reload(true); 
}
if( a===0 || b === 0 || c === 0 ){
	alert('A triangle must have 3 sides with a positive definite length ');
	reload = true;
}
var valid = false;
if((Number(a) + Number(b)) > Number(c)){
    if((Number(b) + Number(c)) > Number(a)){
        if((Number(a) + Number(c)) > Number(b)){
            valid = true;
        }
    }
}
