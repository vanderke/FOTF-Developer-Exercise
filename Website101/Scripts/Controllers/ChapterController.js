
angular.module( 'chapters', [] ).controller( 'chapterCtrl', function( $scope, $http ) {

  $scope.chapters = [];

  // Initialize form values.
  $scope.Initialize = function() {
    $scope.Number = $scope.chapters.length + 1;
    $scope.Title = "";
    $scope.Summary = "";
    $scope.FormTitle = "Add Chapter " + $scope.Number;
    $scope.edit = false;
    $scope.titleInvalid = false;
    $scope.summaryInvalid = false;
  }
  $scope.Initialize();

  // Get the chapters from the backend.
  $scope.Fetch = function() {
    $http.get( "/Book/List" )
    .success( function( response ) {
      $scope.chapters = response.chapters;
      $scope.Initialize();
    } );
  }
  $scope.Fetch();

  // Open the form to add a new chapter.
  $scope.AddNew = function() {
    $scope.Initialize();
    $( "#chapterForm" ).modal( "show" );
  }

  // Close the form.
  $scope.CloseForm = function() {
    $( "#chapterForm" ).modal( "hide" );
    $scope.Initialize();
  }

  // Edit the form.
  $scope.Edit = function( Number ) {
    var chapter = $scope.GetChapter( Number );
    if ( chapter === null ) {
      return;
    }
    $scope.edit = true;
    $scope.Number = Number;
    $scope.Title = chapter.Title;
    $scope.Summary = chapter.Summary;
    $scope.FormTitle = "Edit Chapter " + Number;
    $( "#chapterForm" ).modal( "show" );
  }

  // Watch form state.
  $scope.test = function() {
    console.log( "test" );
    $scope.incomplete = false;
    if ( !$scope.Title.length || !$scope.Summary.length ) {
      $scope.incomplete = true;
    }
  };
  $scope.$watch( 'edit', function() { $scope.test(); } );
  $scope.$watch( 'Number', function() { $scope.test(); } );
  $scope.$watch( 'Title', function() { $scope.test(); } );
  $scope.$watch( 'Summary', function() { $scope.test(); } );

  // Submit the form.
  $scope.Submit = function() {
    console.log( $scope.incomplete );
    if ( $scope.incomplete ) {
      $scope.titleInvalid = !$scope.Title.length;
      $scope.summaryInvalid = !$scope.Summary.length;
      return;
    }

    $http( {
      method: 'POST',
      url: "Book/" + ( $scope.edit ? "Edit" : "Add" ),
      data: {
        Number: $scope.Number,
        Title: $scope.Title,
        Summary: $scope.Summary
      }
    } ).success( function( response ) {
      $scope.chapters = response.chapters;
      $scope.CloseForm();
    } );
  }

  // Submit the form.
  $scope.Delete = function( Number ) {
    var message = "Are you sure you want to delete chapter " + Number + "?";
    if ( confirm( message ) ) {
      $http( {
        method: 'POST',
        url: "Book/Delete/" + Number
      } ).success( function( response ) {
        $scope.chapters = response.chapters;
      } );
    }
  }

  // Get a chapter.
  $scope.GetChapter = function( Number ){
    for ( var i in $scope.chapters ) {
      if ( $scope.chapters[i].Number == Number ) {
        return $scope.chapters[i];
      }
    }
    return null;
  }

} );
