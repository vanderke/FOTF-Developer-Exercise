<?php

	session_start();

	$user_name = $_POST['user_name'];
	$user_email = $_POST['user_email'];
	$password = $_POST['password'];
	$cpassword = $_POST['cpassword'];	

	// Establishing Database Connection
	$db = new PDO("mysql:host=localhost;dbname=fotf;charset=utf8", 'root', 'root');
	// Checking to See if Credentials Already Exist in the System
	$statement = $db->prepare("SELECT * FROM `login` WHERE `email`= :email");	
	$statement->execute(array(":email"=>$user_email));
	$count = $statement->rowCount();

	// Executing Query
	if ($count==0) {
		$statement = $db->prepare("INSERT INTO `login` (`login_id`,`username`,`email`,`password`) VALUES (NULL, :username, :user_email, :password)");
		$statement->bindParam(":username", $user_name);
		$statement->bindParam(":user_email", $user_email);
		$statement->bindParam(":password", $password);
		$statement->execute();
		echo "";
	// Logs In the New User
		$q = "SELECT * FROM `login` WHERE `username`='$user_name' AND `password`='$password'";
		if (isset($user_name) && isset($password)) {
		$result = $db->query($q);
		if ($resultObj = $result->fetchall(PDO::FETCH_OBJ)) {		
			$_SESSION['active']['username'] = $resultObj[0]->username;
			$_SESSION['active']['login_id'] = $resultObj[0]->login_id;
			$session_user = $_SESSION['active']['username'];
			$session_loginid = $_SESSION['active']['login_id'];
			echo json_encode(array('username' => $session_user, 'login_id' => $session_loginid));
			
			} else {
				echo "";
			}
		} else {
			echo "";
		}	
	}	
	else { echo ""; } // i.e. not available
?>