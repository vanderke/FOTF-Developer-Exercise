<?php // </Y3W§']['!//\\//

DEFINE ('DB_USER', 'fotfRTW');
DEFINE ('DB_PASSWORD', 'w356a4sdfeWd!!fds');
DEFINE ('DB_HOST', 'fotfRTW.db.5671199.hostedresource.com');
DEFINE ('DB_NAME', 'fotfRTW');

$dbc = @mysqli_connect (DB_HOST, DB_USER, DB_PASSWORD, DB_NAME) OR die ('Could Not Connect: '.mysqli_connect_error());
mysqli_set_charset($dbc, 'utf8');

?>