<?php
    session_start();
?>
<!DOCTYPE HTML>
<html>
<head>
	<title>Ready to Wed - A Website for Couples</title>
	<meta charset="utf-8">
	<!--Meta for Mobile Responsiveness-->
	<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no">
	<!-- SEO -->
	<meta name="author" content="Focus on the Family">
	<meta name="description" content="You’re engaged, and the checklist for the day of your dreams is a mile long. In the who, what, where, and how of planning, the why can be forgotten. Ready to Wed discusses 12 Traits of a thriving marriage and offers a variety of topics to guide and advise those preparing to say, 'I do!'.">
	<meta name="keywords" content="??">
	<!--Fonts-->
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.4.0/css/font-awesome.min.css">
	<!--Stylesheets-->
	<link rel="stylesheet" type="text/css" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css">
	<link rel="stylesheet" type="text/css" href="style.css">
</head>
<body id="page-top" data-spy="scroll" data-target=".navbar-fixed-top">

    <!-- Navigation -->
    <nav class="navbar navbar-custom navbar-fixed-top" role="navigation">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-main-collapse">
                    <i class="fa fa-bars"></i>
                </button>
                <a class="navbar-brand page-scroll" href="#page-top">
                    <img src="images/rtw-logo-white.png" alt="logo">
                </a>
            </div>

            <!-- Collects the nav links, forms, and other content for toggling -->
            <div class="collapse navbar-collapse navbar-right navbar-main-collapse">
                <ul class="nav navbar-nav">
                    <!-- Hidden li included to remove active class from about link when scrolled up past about section -->
                    <li class="hidden">
                        <a href="#page-top"></a>
                    </li>
                    <li>
                        <a class="page-scroll" href="#about">About</a>
                    </li>
                    <li class="sign-show">
                        <a class="page-scroll" href="#signin">Sign-in</a>
                    </li>
                    <li class="dropdown">
                        <a class="page-scroll dropdown-toggle" id="user-credentials" href="#" data-toggle="dropdown"><strong class="caret"></strong></a>
                        <div class="dropdown-menu" style="padding: 12px 0px; text-align: center;">
                            <a href="logout.php" class="logout"><input type="submit" class="btn btn-info" value="Logout" /></a>
                        </div>
                    </li>
                    <li class="edit-show">
                        <a class="page-scroll" href="#titles">Edit Titles</a>
                    </li>
                    <li>
                        <a class="page-scroll" href="#theme">12 Points</a>
                    </li>
                    <li>
                        <a class="page-scroll" href="#connected">Stay Connected</a>
                    </li>
                </ul>
            </div>
            <!-- /.navbar-collapse -->
        </div>
        <!-- /.container -->
    </nav>

    <!-- Intro Header -->
    <header class="intro">
        <div class="intro-body">
            <div class="container">
                <div class="row">
                    <div class="col-md-8 col-md-offset-2">
                        <h1 class="brand-heading">Ready to Wed?</h1>
                        <p class="intro-text">Site Created by Joshua Cintolo.</p>
                        <a href="#about" class="btn btn-circle page-scroll">
                            <i class="fa fa-angle-double-down animated"></i>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </header>

	<main>
            <!-- About Section -->
            <section id="about" class="container content-section text-center">
                <div class="row">
                    <div class="col-lg-8 col-lg-offset-2">
                        <h2>About Ready to Wed</h2>
                        <p>Phasellus id nisl eu urna ullamcorper tempus non eu erat. Aenean dapibus volutpat dapibus. Sed lacinia quis ipsum vitae convallis. Mauris blandit consequat orci, ut suscipit tellus. Nulla facilisi. Cras nibh odio, imperdiet quis tempor ac, fringilla vel nisi. Interdum et malesuada fames ac ante ipsum primis in faucibus.</p>
                        <p>Cras id nulla nec orci suscipit euismod. Etiam eu est in nunc egestas auctor. Ut nibh dolor, lobortis in semper eu, venenatis eget eros. Integer imperdiet pulvinar commodo.</p>
                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse ullamcorper imperdiet mauris, non vehicula ipsum mattis et. Suspendisse turpis magna, efficitur sed libero vitae, interdum ornare libero.</p>
                    </div>
                </div>
            </section>


            <!-- Sign In Section -->
            <section id="signin" class="container content-section text-center">
            <div class="row">
                <div class="col-md-6 col-md-offset-3">
                    <div class="panel panel-login">
                        <div class="panel-heading">
                        <div class="row">    
                                <div class="col-xs-6">
                                    <a href="#" class="active" id="login-form-link">Login</a>
                                </div>
                                <div class="col-xs-6">
                                    <a href="#" id="register-form-link">Register</a>
                                </div>
                        </div>        
                            <hr>
                        </div>
                        <div class="panel-body">
                            <div class="row">
                                <div class="col-lg-12">
                                <form id="login-form" action="login.php" method="post" role="form" style="display: block;">
                                    <div class="form-group">
                                        <input type="text" name="user_name" id="user_name" tabindex="1" class="form-control" placeholder="Username" value="">
                                    </div>
                                    <div class="form-group">
                                        <input type="password" name="password" id="password" tabindex="2" class="form-control" placeholder="Password">
                                    </div>
                                    <div class="form-group">
                                        <div class="row">
                                            <div class="col-sm-6 col-sm-offset-3">
                                                <input type="submit" name="login-submit" id="login-submit" tabindex="4" class="form-control btn btn-login" value="Log In">
                                            </div>
                                        </div>
                                    </div>
                                </form>
                                <form id="register-form" action="register.php" method="post" role="form" style="display: none;">
                                    <div id="error">
                                    <!-- error will be shown here ! -->
                                    </div>
                                    <div class="form-group">
                                        <input type="text" name="user_name" id="user_name" tabindex="1" class="form-control" placeholder="Username" value="">
                                    </div>
                                    <div class="form-group">
                                        <input type="email" name="user_email" id="user_email" tabindex="1" class="form-control" placeholder="Email Address" value="">
                                    </div>
                                    <div class="form-group">
                                        <input type="password" name="password" id="password" tabindex="2" class="form-control" placeholder="Password">
                                    </div>
                                    <div class="form-group">
                                        <input type="password" name="cpassword" id="cpassword" tabindex="2" class="form-control" placeholder="Confirm Password">
                                    </div>
                                    <div class="form-group">
                                        <div class="row">
                                            <div class="col-sm-6 col-sm-offset-3">
                                                <input type="submit" name="register-submit" id="register-submit" tabindex="4" class="form-control btn btn-register" value="Register Now">
                                            </div>
                                        </div>
                                    </div>
                                </form>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>


        <!--Edit the Titles Section-->
        <section id="titles" class="container content-section text-center">
        <?php
            $myFile = fopen("points.json", "r");
            $someJSON = fgets($myFile);
            $someArray = json_decode($someJSON, true);
            $update1 = $someArray[1]['title'];
            $update2 = $someArray[2]['title'];
            $update3 = $someArray[3]['title'];
            $update4 = $someArray[4]['title'];
            $update5 = $someArray[5]['title'];
            $update6 = $someArray[6]['title'];
            $update7 = $someArray[7]['title'];
            $update8 = $someArray[8]['title'];
            $update9 = $someArray[9]['title'];
            $update10 = $someArray[10]['title'];
            $update11 = $someArray[11]['title'];
            $update12 = $someArray[12]['title'];
        ?>   
                <div class="row">
                    <div class="panel panel-login">
                        <div class="panel-heading">
                            <div class="row">
                                <div class="col-xs-12">
                                    <h4>Edit the Titles</h4>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                    <hr>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-lg-12">
                            <form id="edit-titles" action="edit.php" method="post" role="form" style="display: block;">
                                <div id="error">
                                <!-- error will be shown here ! -->
                                </div>
                                <div class="form-group">
                                    <input type="text" name="title_1" id="title_1" tabindex="1" class="form-control" placeholder="Title 1" value="">
                                </div>
                                <div class="form-group">
                                    <input type="text" name="title_2" id="title_2" tabindex="1" class="form-control" placeholder="Title 2" value="">
                                </div>
                                <div class="form-group">
                                    <input type="text" name="title_3" id="title_3" tabindex="1" class="form-control" placeholder="Title 3" value="">
                                </div>
                                <div class="form-group">
                                    <input type="text" name="title_4" id="title_4" tabindex="1" class="form-control" placeholder="Title 4" value="">
                                </div>
                                <div class="form-group">
                                    <input type="text" name="title_5" id="title_5" tabindex="1" class="form-control" placeholder="Title 5" value="">
                                </div>
                                <div class="form-group">
                                    <input type="text" name="title_6" id="title_6" tabindex="1" class="form-control" placeholder="Title 6" value="">
                                </div>
                                <div class="form-group">
                                    <input type="text" name="title_7" id="title_7" tabindex="1" class="form-control" placeholder="Title 7" value="">
                                </div>
                                <div class="form-group">
                                    <input type="text" name="title_8" id="title_8" tabindex="1" class="form-control" placeholder="Title 8" value="">
                                </div>
                                <div class="form-group">
                                    <input type="text" name="title_9" id="title_9" tabindex="1" class="form-control" placeholder="Title 9" value="">
                                </div>
                                <div class="form-group">
                                    <input type="text" name="title_10" id="title_10" tabindex="1" class="form-control" placeholder="Title 10" value="">
                                </div>
                                <div class="form-group">
                                    <input type="text" name="title_11" id="title_11" tabindex="1" class="form-control" placeholder="Title 11" value="">
                                </div>
                                <div class="form-group">
                                    <input type="text" name="title_12" id="title_12" tabindex="1" class="form-control" placeholder="Title 12" value="">
                                </div>
                                <div class="form-group">
                                    <div class="row">
                                        <div class="col-sm-6 col-sm-offset-3">
                                            <input type="submit" name="titles-submit" id="titles-submit" tabindex="4" class="form-control btn btn-register" value="Submit Changes">
                                        </div>
                                    </div>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>    
            </section>


		<!--Theme section-->
		<section id="theme" class="content-section text-center">
		<div class="container">
			<div class="col-lg-10 col-lg-offset-1">
                <div id="points-header">
                </div><!--End of Points Header-->
            </div>    
            <div class="col-lg-4 col-lg-offset-1">    
				<div id="points-left">
				</div><!--End of Points-Left-->
            </div>
            <div class="col-lg-4 col-lg-offset-2">     
                <div id="points-right">
                </div><!--End of Points-Right-->
			</div>
		</div>
		</section>
	</main>


        <!-- Contact Section -->
        <section id="connected" class="container content-section text-center">
            <div class="row">
                <div class="col-lg-10 col-lg-offset-1">
                    <h3>Contact us at Focus on the Family</h3>
                </div>
                <div class="col-lg-8 col-lg-offset-2">    
                    <p>Find these other great ways to stay connected with us: </p>
                    <p><a href="mailto:info@readytowed.com">info@readytowed.com</a>
                    </p>
                    <ul class="list-inline banner-social-buttons">
                        <li>
                        <a href="https://twitter.com/FocusFamily" class="btn btn-default btn-lg"><i class="fa fa-twitter fa-fw"></i> <span class="network-name">Twitter</span></a>
                    </li>
                    <li>
                        <a href="https://www.facebook.com/focusonthefamily" class="btn btn-default btn-lg"><i class="fa fa-facebook fa-fw"></i> <span class="network-name">Facebook</span></a>
                    </li>
                    <li>
                        <a href="https://plus.google.com/+focusonthefamily/videos" class="btn btn-default btn-lg"><i class="fa fa-google-plus fa-fw"></i> <span class="network-name">Google+</span></a>
                    </li>
                    </ul>
                </div>
            </div>
        </section>
	<!-- Footer -->
    <footer>
        <div class="container text-center">
            <p>Copyright &copy; Focus on the Family <?php echo date("Y")?></p>
        </div>
    </footer>

	<!--Scripts-->
		<!--Queuing jQuery-->
	<script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
		<!--Queuing jQuery easing-->
	<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/jquery-easing/1.3/jquery.easing.min.js"></script>
        <!--Queuing jQuery validate-->
    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.15.0/jquery.validate.min.js"></script>
		<!--Queuing bootstrap-->
	<script type="text/javascript" src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
		<!--Queuing custom js-->
	<script type="text/javascript" src="script.js"></script>
</body>
</html>