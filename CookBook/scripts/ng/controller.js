var basecontrollers = {};

basecontrollers.MainController = function ($scope, recipeService) {
    $scope.today = new Date();
    $scope.message = "Welcome to the Tech Night CookBook.";

    $scope.recipeList=recipeService.getRecipes();
    
};

mainApp.controller(basecontrollers);
