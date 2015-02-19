/*var mainApp = angular.module('mainApp', ['ngRoute','ngSanitize','ngCookies','ui.bootstrap', 'whCurrencyFilter', 'whDateFilter']);*/
var mainApp = angular.module('mainApp', ['ngRoute','ui.bootstrap']);

/* Route */
mainApp.config(function ($routeProvider) {
    $routeProvider
		.when('/welcome',
		{
		    //controller: 'MainController',
		    templateUrl: 'content/partials/welcome.html'
		})
		.when('/list',
		{		    
		    templateUrl: 'content/partials/recipelist.html'
		})
		.when('/add',
		{
		   // controller: 'AddController',
		    templateUrl: 'content/partials/addrecipe.html'
		})

		.otherwise({ redirectTo: '/welcome' });
});