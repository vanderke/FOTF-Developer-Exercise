<?php // </Y3W§']['!//\\//

session_start();
			
if(isset($_SESSION['UserID'])){
	
	echo '<div onClick="logOut()" id="welcomeNote">Logout</div>';

}else{

	echo '<div id="edit" onClick="edit()"></div>';	

}

?>