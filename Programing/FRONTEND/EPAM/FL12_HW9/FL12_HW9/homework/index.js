function convert(array){
	for(let i in array){
		if(typeof(array[i])==='string' ){
			array[i]=Number(array[i]);
		}else{
			array[i]=String(array[i]);
		}
	}
	return array;
}
let two =2;
let three = 3;
let arr1 = ['1',two,three,'4'];
alert('arr1: '+ arr1);
for(let j in arr1){
	alert('Element '+arr1[j]+' is '+ typeof(arr1[j]));
}
arr1 = convert(arr1);
alert('arr1: '+ arr1);
for(let j in arr1){
	alert('Element '+arr1[j]+' is '+ typeof(arr1[j]));
}
function executeforEach(array){
	for( let i in array){
		console.log(array[i]*2);
	}
	return array;
}
let one = 1;
let arr2=[one,two,three];
arr2 = executeforEach(arr2);
function mapArray(array){
	for(let i in array){
		console.log(array[i]+3);
	}
}
function makeNumber(array, callback){
	for(let i in array){
		if(typeof(array[i])==='string'){
			array[i]=Number(array[i]);
		}
	}
	callback(array);
}
let arr3=[2,'5',8];
arr3=makeNumber(arr3, mapArray);
function task4(array, callback){
	for(let i in array){
		array[i]=array[i]*2;
	}
	callback(array);
}
function four(array){
	for(let el in array){
		if(el%2===0){
			console.log(array[el]/2);
		}
	}
}
let five =5;
let eight =8;
let arr4=[two,five,eight];
arr4=task4(arr4, four);
function flipOver(string){
	return string.split("").reverse().join("");
}
console.log(flipOver('hey world'));

