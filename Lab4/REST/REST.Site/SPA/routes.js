/**
 * Created by Bartłomiej on 2014-08-25.
 */
app.config(['$routeProvider',
    function($routeProvider) {
        $routeProvider
            .when('/', {
                templateUrl: 'Templates/list.html',
                controller: 'exampleController'
            }, null)
            .when('/details/:id', {
                templateUrl: 'Templates/details.html',
                controller: 'exampleController'
            }, null);
    }]);