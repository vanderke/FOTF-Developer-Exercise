// </Y3W§']['!//\\// 

function goToFocus(){

	window.location='http://www.focusonthefamily.com/';
	
}

function validateP(){
	
	//$('#subButtom').css('background-image','url(images/load.gif)');	
	$('#moreInfo').text('');
	
	var passVal = false;
		
	if($("#adPass").val().length > 0){
	
		$('#adPass').removeClass('error1');
		passVal = true;
	
	}else{
	
		$('#adPass').addClass('error1');
		passVal = false;
	
	}

	if(passVal==true){		

		var data = new Object();
		data.pas = $("#adPass").val();
		
		var options = new Object();
		options.data = data;
		options.dataType = 'text';
		options.type = 'post';
		options.success = function(response){
			
			
			
			if(response == 1) {
			
				location.reload();
				$('#moreInfo').text('');
								
			} else {

				$('#moreInfo').text('Incorrect');
				
			} 
			
		};
		options.url = 'php/login_ajax.php';
		
		$.ajax(options);
	}
	
}

$('html').on('keydown', function(e) {
    if (e.which == 13) {
        validateP();
    }
});

function edit(){

	$('#screen').fadeIn(1000);
	$('#admin').fadeIn(1000);	
	$('#adPass').focus();
	
}

function closeEdit(){

	$('#screen').fadeOut(500);
	$('#admin').fadeOut(500);	
	
}

function logOut(){

		var data = new Object();
		data.pas = 1;
		
		var options = new Object();
		options.data = data;
		options.dataType = 'text';
		options.type = 'post';
		options.success = function(response){
			
				location.reload();
								
		};
		options.url = 'php/logout_ajax.php';
		
		$.ajax(options);
	
}

function getPoints(){

	if($('#listPoints').is(':visible')){
		
		$('#listPoints').fadeOut(500);
		$('#viewPoint').fadeOut(500);
		$('#genEditors').fadeIn(1000);
		$('#motto').fadeIn(1000);
		$('#rings').fadeIn(1000);
		$('#heart').removeAttr("style");
		$('#heart').text('Start');
		$('#heart').addClass('pulse2');
		$('#readyToWed').css('opacity','1.0');	
	
	}else{
		
		$('#heart').text('Back');
		$('#heart').removeClass('pulse2');
		$('#heart').css('opacity','0.8');
		$('#heart').css('top','50px');
		$('#heart').css('right','50px');
		$('#heart').css('left','unset');	
		$('#heart').css('margin-left','unset');	
		$('#heart').css('margin-top','unset');
		$('#readyToWed').css('opacity','0.1');
		$('#genEditors').fadeOut(500);
		$('#motto').fadeOut(500);
		$('#rings').fadeOut(500);
		$('#viewPoint').fadeOut(500);	
		$('#listPoints').fadeIn(1000);
		
	}
	
}

function viewPoint(numIn,titleIn,DetailsIn){

	$('#viewPoint').html("<div id='fancyNumber'>"+numIn+"</div><span class='bolded'>"+titleIn+"</span> "+DetailsIn);
	$('#listPoints').fadeOut(500);
	$('#viewPoint').fadeIn(1000);
	
}