<?php // </Y3W§']['!//\\//

function check_login($dbc, $pass =''){

	$errors = array(); 
		
	if(empty($pass)){
	
		$errors[] = 'Enter Your Password';
	
	}else{
		
		$p = mysqli_real_escape_string($dbc, trim($pass));
	
	}
	
	if (empty($errors)){
	
		$q = "SELECT * FROM readyToWed_Users WHERE rtwu_userID = 1 AND rtwu_userPass = SHA1('$p')";
		$r = @mysqli_query($dbc, $q);
		
		if(mysqli_num_rows($r) == 1){
			
			$row = mysqli_fetch_array ($r, MYSQLI_ASSOC);
			return array(true, $row);
			
		} else { 
			
			$errors[] = 'The email address and or the password is incorrect';
		
		}
		
	}
	
	return array(false, $errors);
	
}