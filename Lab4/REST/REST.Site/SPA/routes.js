/**
 * Created by Bartłomiej on 2014-08-25.
 */
angular.module('AngularExample').config(['$routeProvider',
    function($routeProvider) {
        $routeProvider
            .when('/', {
                templateUrl: 'Templates/example.html',
                controller: 'exampleController'
            }, null)
            .when('/list', {
                templateUrl: 'Templates/list.html',
                controller: 'exampleController'
            }, null);
    }]);