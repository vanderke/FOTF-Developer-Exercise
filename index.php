<?php // </Y3W§']['!//\\//

session_start();

?>
<!DOCTYPE HTML> <!-- </Y3W§']['!//\\// -->
<html lang="en">
    <head>
        <meta charset="utf-8">
        <title>Ready To Weds | Helping Engaged Couples</title>
        <meta name="description" content="Having a thriving marriage begins before saying, &quot;I Do.&quot; Become Ready To Wed with this kit for engaged couples &amp; mentoring pastors from Focus on the Family.">
        <meta name="keywords" content="couples,ready,engaged,helping,marriage,love,experts,focus,learn,mentors,family,session,finances,couple,important">
        <meta name="author" content="Justin Trimble">
        <link rel="shortcut icon" href="images/favicon.ico" >
        <link rel='stylesheet' href='http://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800&#038;subset=latin,latin-ext' type='text/css' media='all' />
        <link rel="stylesheet" type="text/css" href="css/style.css">
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.0.0/jquery.min.js"></script>
        <script type="text/javascript" src="js/js.js"></script>
    </head>
    <body>
        <div id="creativeShow">
            <div id="motto">12 Ways to Start<br />a Marriage You'll Love</div>
            <div id="genEditors"><h2>Dr. Greg &amp; Erin Smalley</h2>General Editors</div>
            <div id="rings"></div>
            <div id="heart" class="heart pulse2" onClick="getPoints()">Begin</div>
            <div id="readyToWed"></div>
            <div id="listPoints"><?php include('php/r_list.php'); ?></div>
            <div id="viewPoint"></div>
            <div id="focusOnTheFamilyOrange" onClick="goToFocus()"></div>
            <div id="readyToWedLogo"></div>    
            <div id="frameTop"></div>
            <div id="frameBottom"></div>
            <div id="frameLeft"></div>
            <div id="frameRight"></div>
            <?php include('php/r_login.php'); ?>
            <div id="screen"></div>
            <div id="admin"><div id="moreInfo"></div><div onClick="closeEdit()" id="backButton"></div><input type="password" placeholder="Password" id="adPass" /><div onClick="validateP()" id="subButtom"></div></div>
        </div>
    </body>
</html>
