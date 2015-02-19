var factories = {};

factories.recipeService = function ($http) {
    return {
        getRecipes: function () {
            

            var list = [{ "Name": "Chicken Adobo", "Rating": "5", "Origin": "Filipino" }, { "Name": "Chicken Alfredo", "Rating": "5", "Origin": "Italian" }];

            return list;

            /*return $http.get(rootUrl + 'xx/xx')
                 .then(function (result) {
                     //resolve the promise as the data
                     //console.log(result.data);
                     return result.data;
                 });
                 */
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
                    //alert('Failed: ' + reason);
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


