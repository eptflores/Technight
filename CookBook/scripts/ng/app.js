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
		.when('/signin',
		{
		    // controller: 'AddController',
		    templateUrl: 'content/partials/signin.html'
		})
		.when('/register',
		{
		    // controller: 'AddController',
		    templateUrl: 'content/partials/register.html'
		})

		.otherwise({ redirectTo: '/welcome' });
});