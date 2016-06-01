	// jQuery to collapse the navbar on scroll
	function collapseNavbar() {
	    if ($(".navbar").offset().top > 50) {
	        $(".navbar-fixed-top").addClass("top-nav-collapse");
	    } else {
	        $(".navbar-fixed-top").removeClass("top-nav-collapse");
	    }
	}

$(function(){ //on load functions
	// Test Suite for checking work
	var test = function(claim, message) {
			if(claim) {
				return true;
			} else {
				throw message;
			}
		}

	$(window).scroll(collapseNavbar);
	$(document).ready(collapseNavbar);

	// jQuery for page scrolling feature - uses jQuery Easing plugin
    $('a.page-scroll').bind('click', function(event) {
        var $anchor = $(this);
        $('html, body').stop().animate({
            scrollTop: $($anchor.attr('href')).offset().top
        }, 2000, 'easeInOutExpo');
        event.preventDefault();
    });

	// Closes the Responsive Menu on Menu Item Click
	$('.navbar-collapse ul li a').click(function() {
	  if ($(this).attr('class') != 'dropdown-toggle active' && $(this).attr('class') != 'dropdown-toggle') {
	    $('.navbar-toggle:visible').click();
	  }
	});

	// Toggles Login and Register Button
	$('#login-form-link').click(function(e) {
		$("#login-form").delay(100).fadeIn(100);
 		$("#register-form").fadeOut(100);
		$('#register-form-link').removeClass('active');
		$(this).addClass('active');
		e.preventDefault();
	});
	$('#register-form-link').click(function(e) {
		$("#register-form").delay(100).fadeIn(100);
 		$("#login-form").fadeOut(100);
		$('#login-form-link').removeClass('active');
		$(this).addClass('active');
		e.preventDefault();
	});

	// Getting JSON object and churning out the information
	$.getJSON('points.json', function(data){
		// console.log(data); // test works and also works if input console.log(data[1]);
		for (var i = 1; i < 14; i++) {
			var pointsHeader = $("#points-header");
			var pointsLeft = $("#points-left");
			var pointsRight = $("#points-right");
			var title = data[i].title;
			var summary = data[i].summary;
			if (i <= 6) {
				pointsLeft.append("<h4>" + i + ". " + title + "</h4><h5>" + summary + "</h5>");
			}
			else if (i > 6 && i < 13 ) {
				pointsRight.append("<h4>" + i + ". " + title + "</h4><h5>" + summary + "</h5>");
			}
			else {
				pointsHeader.append("<h3>" + title + "</h3>");
				$("#points-header h3").addClass("header-spacing");
			}
		}
	});

	// Handles Logout
	$(".logout").on("click", function(){
		$("li.dropdown").hide();
		$("li.edit-show").hide();
		$("#titles").hide();
		$(".sign-show").show();
	});

	// All Scripts for Form Registration
	/* validation */
	$("#register-form").validate({
	    rules:
	   {
	   user_name: {
	   required: true,
	   minlength: 3
	   },
	   password: {
	   required: true,
	   minlength: 5,
	   maxlength: 15
	   },
	   cpassword: {
	   required: true,
	   // equalTo: '#password',
	   minlength: 5,
	   maxlength: 15
	   },
	   user_email: {
	            required: true,
	            email: true
	            },
	    },
	       messages:
	    {
	            user_name: "please enter user name",
	            password:{
	                      required: "please provide a password",
	                      minlength: "password at least have 5 characters"
	                     },
	            user_email: "please enter a valid email address",
			    cpassword:{
			      required: "please retype your password",
			      // equalTo: "password doesn't match !"
			       }
	       },
	    submitHandler: submitForm 
	       });  
	    /* validation */
	    
	    /* form submit */
	    function submitForm()
	    {  
		    var data = $("#register-form").serialize();	    
	    $.ajax({
		    type : 'POST',
		    url  : 'register.php',
		    data : data,
		    dataType : 'json'
		})
	    .done(function(data){
	    	// alert(data);
	    	if(data !== ''){
	    		alert("Thank you, you are now registered");
	    		$(".sign-show").hide();
	    		$("li.dropdown").show();
	    		$("li.edit-show").show();
				$("#titles").show();
	    		$("a#user-credentials").html("Hi, " + data.username);
	    	}
	    	if(data == ''){
	    		alert("Seems you are already registered - try logging in. Also be sure your passwords match.");
	    	}
	    })
	    .fail(function(jqXHR, responseJSON, errorThrown){
	    	alert(errorThrown);
	    	alert(responseJSON);
	    })
	    .always(function(){});

	    return false;
	  }

	  // All Scripts for Login Registration
	/* validation */
	$("#login-form").validate({
	    rules:
	   {
	   user_name: {
	   required: true,
	   minlength: 3
	   },
	   password: {
	   required: true,
	   minlength: 5,
	   maxlength: 15
	   },
	    },
	       messages:
	    {
	            user_name: "please enter user name",
	            password:{
	                      required: "please provide a password",
	                      minlength: "password at least have 5 characters"
	                     },
	       },
	    submitHandler: loginForm
	       });  
	    /* validation */
	    
	    /* form submit */
	    function loginForm()
	    {  
		    var data = $("#login-form").serialize();	    
	    $.ajax({
		    type : 'POST',
		    url  : 'login.php',
		    data : data,
		    dataType: 'json'
		})
	    .done(function(data){
	    	// alert(data);
	    	if(data !== ""){
	    		alert("Thank you, you are now logged in");
	    		$(".sign-show").hide();
	    		$("li.dropdown").show();
	    		$("li.edit-show").show();
				$("#titles").show();
	    		$("a#user-credentials").html("Hi, " + data.username);
	    		// console.log(data.username);
	    		// console.log(data)
	    	}
	    	if(data == ""){
	    		alert("Seems you are already logged in or not registered");
	    	}
	    })
	    .fail(function(jqXHR, responseJSON, errorThrown){
	    	alert(errorThrown);
	    	alert(responseJSON);
	    })
	    .always(function(){});

	    return false;
	  }
});	     