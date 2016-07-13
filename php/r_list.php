<?php // </Y3W§']['!//\\// 

session_start();

require ('connect.php');

$q = "SELECT * FROM readyToWed_Points";
$r = @mysqli_query($dbc, $q);
$num = mysqli_num_rows($r);
	
if($num>0){
	
	if(isset($_SESSION['UserID'])){
		
	}else{
		
		echo '<div id="instructions"></div>';				
	
	}
	
	while($row = mysqli_fetch_array($r, MYSQLI_ASSOC)){
			
			if(isset($_SESSION['UserID'])){

				echo '<input id="input'.$row['rtwp_pointID'].'" value="'.$row['rtwp_pointTitle'].'" type="text" /><br /><textarea id="textarea'.$row['rtwp_pointID'].'">'.$row['rtwp_pointDetails'].'</textarea>';				

			}else{

				echo '<div onClick="viewPoint(\''.$row['rtwp_pointID'].'\',\''.$row['rtwp_pointTitle'].'\',\''.$row['rtwp_pointDetails'].'\')" class="point">'.$row['rtwp_pointID'].'. '.$row['rtwp_pointTitle'].'</div>';				
				
			}
			
	}	
	
	if(isset($_SESSION['UserID'])){  //thought I would hide this js until now
		
		echo '<div onClick="updateData()" id="saveBTN">Save</div><script>function updateData(){

		var data = new Object();
		data.t1 = $("#input1").val().replace(/\n/g, "");
		data.d1 = $("#textarea1").val().replace(/\n/g, "");		
		data.t2 = $("#input2").val().replace(/\n/g, "");
		data.d2 = $("#textarea2").val().replace(/\n/g, "");		
		data.t3 = $("#input3").val().replace(/\n/g, "");
		data.d3 = $("#textarea3").val().replace(/\n/g, "");		
		data.t4 = $("#input4").val().replace(/\n/g, "");
		data.d4 = $("#textarea4").val().replace(/\n/g, "");		
		data.t5 = $("#input5").val().replace(/\n/g, "");
		data.d5 = $("#textarea5").val().replace(/\n/g, "");		
		data.t6 = $("#input6").val().replace(/\n/g, "");
		data.d6 = $("#textarea6").val().replace(/\n/g, "");		
		data.t7 = $("#input7").val().replace(/\n/g, "");
		data.d7 = $("#textarea7").val().replace(/\n/g, "");		
		data.t8 = $("#input8").val().replace(/\n/g, "");
		data.d8 = $("#textarea8").val().replace(/\n/g, "");		
		data.t9 = $("#input9").val().replace(/\n/g, "");
		data.d9 = $("#textarea9").val().replace(/\n/g, "");		
		data.t10 = $("#input10").val().replace(/\n/g, "");
		data.d10 = $("#textarea10").val().replace(/\n/g, "");		
		data.t11 = $("#input11").val().replace(/\n/g, "");
		data.d11 = $("#textarea11").val().replace(/\n/g, "");		
		data.t12 = $("#input12").val().replace(/\n/g, "");
		data.d12 = $("#textarea12").val().replace(/\n/g, "");																								
		
		var options = new Object();
		options.data = data;
		options.dataType = "text";
		options.type = "post";
		options.success = function(response){
			
				alert("Update Successful");
				
		};
		options.url = "php/updatePoints_ajax.php";
		
		$.ajax(options);
		
}</script>';		
	
	
	
	}
	
	echo '<div class="space"></div>';
	
}
		
mysqli_free_result ($r);

?>