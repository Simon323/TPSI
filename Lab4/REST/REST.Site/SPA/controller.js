/**
 * Created by Bartłomiej on 2014-08-25.
 */
app.controller('exampleController', function ($scope){
    
});

app.controller('listController', function ($scope, $http) {

    var onRequestCompleted = function (response) {
        $scope.doctors = response.data;
        
    }

    var onError = function (reason) {
        $scope.error = "Nie można pobrać informacji"
    }

    $http.get("http://localhost:7822/doctors").
        then(onRequestCompleted, onError);

});

app.controller('detailsController', function ($scope, $http) {
    
});