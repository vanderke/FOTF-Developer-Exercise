<?php // </Y3W§']['!//\\//

session_start();

require ('connect.php');

require ('includes/login_functions.inc.php');
	
if(isset($_POST['pas'])) {
			
		list ($check, $data) = check_login($dbc, $_POST['pas']);
			
		if ($check == "true") {
				
				$_SESSION['UserID'] = $data['rtwu_userID'];
				session_regenerate_id(true);
				echo '1';
						
		}else{
			
			echo 0;	
		
		}
						
		mysqli_close($dbc);
				
}else{
	
	echo 0;

}

?>