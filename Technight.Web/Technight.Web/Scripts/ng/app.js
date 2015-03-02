/*var mainApp = angular.module('mainApp', ['ngRoute','ngSanitize','ngCookies','ui.bootstrap', 'whCurrencyFilter', 'whDateFilter']);*/
var mainApp = angular.module('mainApp', ['ngRoute','ui.bootstrap']);

/* Route */
mainApp.config(function ($routeProvider) {
    $routeProvider
		.when('/welcome',
		{
		    //controller: 'MainController',
		    templateUrl: '/Home/Welcome'
		})
		.when('/list',
		{		    
		    templateUrl: '/Home/RecipeList'
		})
		.when('/add',
		{
		   // controller: 'AddController',
		    templateUrl: '/Home/AddRecipe'
		})
		.when('/signin',
		{
		    // controller: 'AddController',
		    templateUrl: '/Home/Signin'
		})
		.when('/register',
		{
		    // controller: 'AddController',
		    templateUrl: '/Home/Register'
		})

		.otherwise({ redirectTo: '/welcome' });
});