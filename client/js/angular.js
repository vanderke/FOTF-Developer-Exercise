var app = angular.module('myApp', ['ngRoute', 'ngResource']);

app.controller('rtwController',['$scope', '$http', '$location', '$routeParams', 'getIdService', '$route', function($scope, $http, $location, $routeParams, getIdService, $route) {


  $scope.currentUrl = $route.current.templateUrl;


  //Add Book Point Data
  $scope.addBookData = function(){
    var payload = {
      'lesson': $scope.lesson,
      'title' : $scope.title,
      'summary' : $scope.summary
    };
    $http.post('/users', payload).then(function(response){
      console.log(response);
      $scope.username = 'User Saved';
    });
    $scope.getBookData();
  };

  //Get all book data
  $scope.getBookData = function () {
   $http.get('/users')
   .success(function(data) {
     $scope.bookData = data;
   })
   .error(function(err) {
   });
 };

//Get Single UserId
// $scope.getSingleUserId = function (data) {
//  getIdService.id = data._id;
//  getIdService.editUserName = data.name;
//  console.log(getIdService.id);
// };


//Update Book Point
$scope.editBookPoint = function(){
  var id = getIdService.id;
  var payload = {
    'title': $scope.editBookPoint,
  };
  $http.put('/bookPoints/' + id, payload).then(function(response){
    console.log('success');
  });
};

//delete book point data
$scope.deleteChapter = function(data){
  $http.delete('/bookPoints/' + data).success(function(data){
    console.log('success');
    $scope.userData = data;
  })
  .error(function(err){
  });
  $scope.getBookData();
};

}]);//myController

