var r1_string = prompt('Enter r1'); // создаю переменную ... в которой будет храниться хначение пользовательского ответа на вопрос ...
var r1 = Number(r1_string);  // перевожу строку в число
var r2_string = prompt('Enter r2');
var r2 = Number(r2_string);
var s1 = r1 * r1 * 3.1415; // создаю переменную .. , она принимает значение r1 * r1 * 3.1415
var s2 = r2 * r2 * 3.1415 ; 
alert("s1 = " + s1 ); // делаю вывод сообщения ...
alert("s2 = " + s2 );
var s3 = s1 - s2;
alert("Your result is: s3 = " + s3);

// var name = prompt ("Hi! What is your name?");
// alert("Hi," + name );