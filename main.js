jQuery(document).ready(function ($) {

	range = () => {

		let tasks = [], tasks_ranged = [], task1_time, task2_time, task3_time, task1_value, task2_value, task3_value, total_value=0;

		let total_time = Number(document.getElementById('total_time').value);

		//с увеличение n сменить на for

		const task1 = {
		  name: document.getElementById('task1_name').innerHTML,
		  time: Number(document.getElementById('task1_time').value),
		  value: Number(document.getElementById('task1_value').value)
		};
		tasks.push(task1);
		const task2 = {
		  name: document.getElementById('task2_name').innerHTML,
		  time: Number(document.getElementById('task2_time').value),
		  value: Number(document.getElementById('task2_value').value)
		}
		tasks.push(task2);
		const task3 = {
		  name: document.getElementById('task3_name').innerHTML,
		  time: Number(document.getElementById('task3_time').value),
		  value: Number(document.getElementById('task3_value').value)
		}
		tasks.push(task3);
		
		set_value = (number) =>{
			document.getElementById('total_value').innerHTML = number;
		}

		let current_total_value, current_total_time, biggest_value=0, best_time=Number.POSITIVE_INFINITY, current_tasks, biggest_value_tasks = [];

		for(let i=0;i<tasks.length;i++){

			current_total_value=0;
			current_total_time=0;
			current_tasks = [];

			if(tasks[i].time<=total_time){
				current_total_time+=tasks[i].time;
				current_total_value+=tasks[i].value;
				current_tasks.push(tasks[i]);
			} else {
				
				continue;
			}
			
			for(let j=0;j<tasks.length;j++){
				let a=i!=j;
				let b=tasks[j].time+current_total_time<=total_time;
				if (a && b){
					current_total_time+=tasks[j].time;
					current_total_value+=tasks[j].value
					current_tasks.push(tasks[j]);
				}
			}

			if(current_total_value>biggest_value || current_total_value==biggest_value && current_total_time<best_time){
				biggest_value=current_total_value;
				biggest_value_tasks=current_tasks;
				best_time=current_total_time;
			}
		}

		set_value(biggest_value);

		let ranged_info_elements=Array.prototype.slice.call(document.getElementsByClassName('ranged_info')); //html collection to array

		clear_ranged_tasks = () =>{
			ranged_info_elements.forEach(element=> element.innerHTML = '');
		}
		
		fill_ranged_tasks = () =>{
			try{
				document.getElementById('task1_n').innerHTML = biggest_value_tasks[0].name;
				document.getElementById('task1_t').innerHTML = biggest_value_tasks[0].time;
				document.getElementById('task1_v').innerHTML = biggest_value_tasks[0].value;
				document.getElementById('task2_n').innerHTML = biggest_value_tasks[1].name;
				document.getElementById('task2_t').innerHTML = biggest_value_tasks[1].time;
				document.getElementById('task2_v').innerHTML = biggest_value_tasks[1].value;
				document.getElementById('task3_n').innerHTML = biggest_value_tasks[2].name;
				document.getElementById('task3_t').innerHTML = biggest_value_tasks[2].time;
				document.getElementById('task3_v').innerHTML = biggest_value_tasks[2].value;
			} 	catch (ex) 
				{console.log(ex)}
		}

		clear_ranged_tasks();
		fill_ranged_tasks();
	}

});    