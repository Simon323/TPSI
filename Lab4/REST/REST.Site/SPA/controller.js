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

    $scope.zmienna = $routeParams.id;

    var onRequestCompletedDoctor = function (response) {
        $scope.doctor = response.data;
        console.log(JSON.stringify(response.data));
    }

    var onError = function (reason) {
        $scope.error = "Nie można pobrać informacji"
    }

    $http.get("http://localhost:7822/doctor/" + $routeParams.id).
        then(onRequestCompletedDoctor, onError);

    $scope.oneAtATime = true;

    $scope.groups = [
      {
          title: 'Dynamic Group Header - 1',
          content: 'Dynamic Group Body - 1'
      },
      {
          title: 'Dynamic Group Header - 2',
          content: 'Dynamic Group Body - 2'
      }
    ];

    $scope.items = ['Item 1', 'Item 2', 'Item 3'];

    $scope.addItem = function () {
        var newItemNo = $scope.items.length + 1;
        $scope.items.push('Item ' + newItemNo);
    };

    $scope.status = {
        isFirstOpen: true,
        isFirstDisabled: false
    };
});