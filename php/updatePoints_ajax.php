<?php // </Y3W§']['!//\\//

session_start();

require ('connect.php');

if(isset($_SESSION['UserID'])) {
		
		
		for ($i = 1; $i <= 12; $i++) {
				
			$q = "UPDATE readyToWed_Points SET rtwp_pointTitle = '".$_POST['t'.$i]."', rtwp_pointDetails= '".$_POST['d'.$i]."' WHERE rtwp_pointID = ".$i." LIMIT 1";
			
			$r = @mysqli_query ($dbc, $q);
		
		}
				
}else{
	
	echo 0;

}

?>