<?php
	session_start();
	$title_1 = $_POST['title_1'];
	$title_2 = $_POST['title_2'];
	$title_3 = $_POST['title_3'];
	$title_4 = $_POST['title_4'];
	$title_5 = $_POST['title_5'];
	$title_6 = $_POST['title_6'];
	$title_7 = $_POST['title_7'];
	$title_8 = $_POST['title_8'];
	$title_9 = $_POST['title_9'];
	$title_10 = $_POST['title_10'];
	$title_11 = $_POST['title_11'];
	$title_12 = $_POST['title_12'];

	// for ($x = 1; $x < 13; $x += 1) {
	// 	echo ${'title_' . $x};
	// }

	$jsonString = file_get_contents('points.json');
	$data = json_decode($jsonString, true);

	for ($i = 1; $i < 13; $i += 1) {
		$data[$i]['title'] = ${'title_' . $i};
	}

	$newJsonString = json_encode($data);
	file_put_contents('points.json', $newJsonString);

	header("location:index.php?#theme");

?>