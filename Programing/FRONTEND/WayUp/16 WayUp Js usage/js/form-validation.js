function validate ()
{
	if(document.getElementById('agrement').checked == true)
        {
      		return true;
        }
    else
        {
        alert("Дайте согласие на обработку ваших данных");
        return false;
        }
}

