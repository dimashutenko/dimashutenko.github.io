var a = Number(prompt('a='));
if(isNaN(a) || a===0 || a === null){
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
var discriminant = Math.pow(b,2) - 4*a*c;
if(discriminant<0){
	console.log('No solution');
}
if(discriminant===0){
	console.log((-b)/2*a);
}
if(discriminant>=0){
	console.log('x1 = '+ (-b+Math.sqrt(discriminant))/2*a);
	console.log('x2 = '+ (-b-Math.sqrt(discriminant))/2*a);
}