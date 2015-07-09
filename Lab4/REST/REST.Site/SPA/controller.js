/**
 * Created by Bartłomiej on 2014-08-25.
 */
app.controller('exampleController', function ($scope){
    
});

app.controller('listController', function ($scope, $http) {

    var onRequestCompletedDoctors = function (response) {
        $scope.doctors = response.data;
        console.log(JSON.stringify(response.data));   
    }

    var onError = function (reason) {
        $scope.error = "Nie można pobrać informacji"
    }

    $http.get("http://localhost:7822/doctors").
        then(onRequestCompletedDoctors, onError);

});

app.controller('detailsController', function ($scope, $http, $routeParams) {

    var onRequestCompletedDoctor = function (response) {
        $scope.doctor = response.data;
        console.log(JSON.stringify(response.data));
    }

    var onError = function (reason) {
        $scope.error = "Nie można pobrać informacji"
    }

    $http.get("http://localhost:7822/doctor/" + $routeParams.id).then(onRequestCompletedDoctor, onError);
});