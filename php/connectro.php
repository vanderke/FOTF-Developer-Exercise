<?php 

DEFINE ('DB_USER', 'readOnlyRTW');
DEFINE ('DB_PASSWORD', 'asfder432S!!dss');
DEFINE ('DB_HOST', 'fotfRTW.db.5671199.hostedresource.com');
DEFINE ('DB_NAME', 'fotfRTW');



$dbc = @mysqli_connect (DB_HOST, DB_USER, DB_PASSWORD, DB_NAME) OR die ('Could Not Connect: '.mysqli_connect_error());

mysqli_set_charset($dbc, 'utf8');

?>