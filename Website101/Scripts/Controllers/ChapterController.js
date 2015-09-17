
angular.module( 'chapters', [] ).controller( 'chapterCtrl', function( $scope, $http ) {
  $http.get( "/Book/List" )
       .success( function( response ) {
         console.log( "test" );
         $scope.chapters = response.chapters;
       } );
} );
