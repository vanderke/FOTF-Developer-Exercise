<?php
	// error_reporting(E_ERROR);
	session_start();
	$user_name = $_POST['user_name'];
	$password = $_POST['password'];

	$db = new PDO("mysql: host=localhost;dbname=fotf;charset=utf8", "root", "root");
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
?>