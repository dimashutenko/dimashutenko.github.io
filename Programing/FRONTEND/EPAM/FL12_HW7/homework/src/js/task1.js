const email = prompt('Enter email');
let password;
let password_change;
let variable;
if (email===''){
	alert('Canceled');
}
let min_email_length = 5;
let min_password_length = 6;
if (email.length < min_email_length){
	alert('I dont know any emails having name length less than 5 symbols');
}else if (email!=='user@gmail.com' && email!=='admin@gmail.com'){
	alert('I dont know you');
}else if(email==='user@gmail.com'){
	password = prompt('Hi, user, enter your password:');
	if(password!=='UserPass'){
		alert('Wrong password');
	}else{
		alert('Welcome, user');
		password_change = confirm('Do you want to change your password?');
		if(password_change){
			if (password === prompt('User, enter your current password:')){
				variable = prompt('Success. Enter your new password:');
				if(variable.length<min_password_length){
					alert('It’s too short password. Sorry');
				}else{
					password = variable;
					if (password === prompt('Success. You now have new password. Please enter it to continue')){
						alert('You have successfully changed your password');
					}else{
						alert('Wrong password');
					}
				}
			}else{
				alert('Wrong password');
			}
		}else{
			alert('You have failed the change');
		}
	}
}else if(email==='admin@gmail.com'){
	password = prompt('Hi, admin, enter your password:');
	if(password!=='AdminPass'){
		alert('Wrong password');
	}else{
		alert('Welcome, admin')
		password_change = confirm('Do you want to change your password?');
		if(password_change){
			if (password === prompt('Admin, enter your current password:')){
				variable = prompt('Success. Enter your new password:');
				if(variable.length<min_password_length){
					alert('It’s too short password. Sorry');
				}else{
					password = variable;
					if (password === prompt('Success. You now have new password. Please enter it to continue')){
						alert('You have successfully changed your password');
					}else{
						alert('Wrong password');
					}
				}
			}else{
				alert('Wrong password');
			}
		}else{
			alert('You have failed the change');
		}
	}
}