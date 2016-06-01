<?php
	session_start();
	session_destroy();
	unset($_SESSION['active']);
	header("location:index.php");
?>