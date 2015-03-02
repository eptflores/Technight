var basecontrollers = {};

basecontrollers.MainController = function ($scope, recipeService) {
    $scope.today = new Date();
    $scope.message = "Welcome to the Tech Night CookBook.";
    
    recipeService.getRecipes().then(function (dataobj) {      
        $scope.recipeList = dataobj.recipes;

    });
    



    $scope.signin = function (user) {
        console.log(user);
    };

    $scope.register = function (user) {
        console.log(user);
    }

    $scope.getsinglerecipe = function (index) {     
        recipeService.getRecipe(index).then(function (dataobj) {          
            console.log(dataobj);
        });
    }
};

mainApp.controller(basecontrollers);
