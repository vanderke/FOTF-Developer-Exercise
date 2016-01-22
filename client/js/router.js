app.config(function ($routeProvider) {
 $routeProvider

 .when('/', {
   templateUrl: 'pages/home.html',
   controller:'rtwController',
 })

 .when('/editLessonName', {
   templateUrl: 'pages/editLessonName.html',
   controller:'rtwController',
 })

 .when('/about', {
   templateUrl: 'pages/about.html',
   controller:'rtwController',
 })

 .when('/studyHome', {
   templateUrl: 'pages/studyHome.html',
   controller:'rtwController',
 })

 .when('/editLessons', {
   templateUrl: 'pages/editLessons.html',
   controller:'rtwController',
 })

 .otherwise({redirectTo: '/home'});
});



