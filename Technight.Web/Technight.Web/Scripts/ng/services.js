var factories = {};

factories.recipeService = function ($http, $q) {
    var recipes = null;

    return {
        getRecipes: function () {

            return $http.get(rootURL+'Home/Recipes')            
                 .then(function (result) {
                     //resolve the promise as the data
                     //console.log(result.data);  
                     //rootURL                        
                     return result.data;
                 });                 
        },
        getRecipe: function (index) {           
            var config = {                                
                params: {
                    index: index
                }
            };
            return $http.get(rootURL + 'Home/Recipe/', config)
                 .then(function (result) {
                     //resolve the promise as the data
                     //console.log(result.data);                            
                     return result.data;
                 });
        }

    }
};


factories.languageService = function ($http, $q) {
    var languageData = null;

    return {
        getLanguageText: function (currentLanguage) {
            if (languageData == null) {
                function asyncGetLanguageText(currentLanguage) {

                    var deferred = $q.defer();
                    $http.get(rootUrl + 'xx/xx/language.js')
                    .success(function (response) {
                        //Ext.app.data.lang = Ext.decode(response.responseText);

                        //me.application.fireEvent('lang',Ext.app.data.currentLanguage);
                        languageData = response;
                        deferred.resolve(response[currentLanguage]);

                    }).error(function (response) {
                        //Sending a friendly error message in case of failure
                        deferred.reject("An error occured while fetching items");
                    });
                    return deferred.promise;

                }
                var promise = asyncGetLanguageText(currentLanguage);
                promise.then(function (data) {
                    return data;
                }, function (reason) {
                   // alert('Failed: ' + reason);
                }, function (update) {
                    //alert('Got notification: ' + update);
                });
            }
            else {
                var deferred = $q.defer();
                deferred.resolve(languageData[currentLanguage]);
                var promise = deferred.promise;
                promise.then(function (data) {
                    return data;
                }, function (reason) {
                    //alert('Failed: ' + reason);
                }, function (update) {
                    //alert('Got notification: ' + update);
                });
                //	return enrollmentData;
            }
            return promise;

        }

    }

}



mainApp.factory(factories);


