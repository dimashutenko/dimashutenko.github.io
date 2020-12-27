function countdown(dateEnd) {
	var timer, days, hours, minutes, seconds;

	dateEnd = new Date(dateEnd);
	dateEnd = dateEnd.getTime();

	if(isNaN(dateEnd)){
		return;
	}
	timer = setInterval(calculate, 1000);

	function calculate(){
		var dateStart = new Date();
		var dateStart = new Date(dateStart.getUTCFullYear(),
			dateStart.getUTCMonth(),
			dateStart.getUTCDate(),
			dateStart.getUTCHours(),
			dateStart.getUTCMinutes(),
			dateStart.getUTCSeconds());
		var timeRemaining = parseInt((dateEnd - dateStart.getTime())/1000);
	
		if(timeRemaining >=0){
			days = parseInt(timeRemaining/86400);
			timeRemaining = (timeRemaining%86400);
			hours = parseInt(timeRemaining/3600);
			timeRemaining = (timeRemaining%3600);
			minutes = parseInt(timeRemaining/60);
			timeRemaining = (timeRemaining%60);
			seconds = parseInt(timeRemaining);

			if (days<10){
				document.getElementById('days').innerHTML = '0'+parseInt(days, 10);
			}else if (days===0){
				document.getElementById('days').innerHTML = '00';
			}else{
				document.getElementById('days').innerHTML = parseInt(days, 10);
			}
			if (hours<10){
				document.getElementById('hours').innerHTML = '0'+parseInt('0'+ hours);
			}else if(hours===0){
				document.getElementById('hours').innerHTML = '00';
			}else{
				document.getElementById('hours').innerHTML = parseInt(hours);
			}
			if (minutes<10){
				document.getElementById('minutes').innerHTML = '0'+parseInt('0'+ minutes);
			}else if(minutes===0){
				document.getElementById('minutes').innerHTML = '00';
			}else{
				document.getElementById('minutes').innerHTML = parseInt(minutes);
			}
			if (seconds<10){
				document.getElementById('seconds').innerHTML = '0'+parseInt('0'+ seconds);
			}else if(seconds===0){
				document.getElementById('seconds').innerHTML = '00';
			}else{
				document.getElementById('seconds').innerHTML = parseInt(seconds);
			}
		} else{
			return;
		}
	}
	// function display(days, hours, minutes, seconds){}
}

countdown(Date.now()); //current time zone utc+2
