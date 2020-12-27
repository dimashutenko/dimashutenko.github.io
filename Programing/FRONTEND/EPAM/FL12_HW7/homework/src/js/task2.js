const wanna_play = confirm('Do you want to play a game?');
if(wanna_play){
	let max =9;
	let random = Math.floor(Math.random() * max); 
	let prize = 0;
	let amount =3;
	let h = 2;
	for(let i=0; i<amount; i++){
		let guess = prompt('Enter a number of pocket on which the ball could land');
		parseInt(guess,10);
		if (random===guess && i===0){
			let give100 =100;
			prize += give100;
			break;
		}else if (random===guess && i===1){
			let give50 =50;
			prize += give50;
			break;
		}else if (random===guess && i===h){
			let give25 =25;
			prize += give25;
			break;
		}
	}
	alert('Thank you for your participation. Your prize is: '+ prize +'$');
}else{
	alert('You did not become a billionaire, but can.');
}