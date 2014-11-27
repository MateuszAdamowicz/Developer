//var appRoot = angular.module('main', ['ngRoute', 'ngGrid', 'ngResource']);     //Define the main module

//appRoot
//    .config(['$routeProvider', function ($routeProvider) {
//        //Setup routes to load partial templates from server. TemplateUrl is the location for the server view (Razor .cshtml view)
//        $routeProvider
//            .when('/land', { templateUrl: '/home/land', controller: 'LandController' })
//            .when('/flat', { templateUrl: '/home/flat', controller: 'FlatController' })
//            .when('/house', { templateUrl: '/home/house', controller: 'HouseController' })
//            .otherwise({ redirectTo: '' });
//    }])
//    .controller('RootController', ['$scope', '$route', '$routeParams', '$location', function ($scope, $route, $routeParams, $location) {
//        $scope.$on('$routeChangeSuccess', function (e, current, previous) {
//            $scope.activeViewPath = $location.path();
//        });
//    }]);

var searcher = angular.module('searcher', ['ngRoute', 'ngGrid', 'ngResource']);

searcher.filter('unique', function () {
    return function (input, key) {
        if (typeof input !== "undefined") {
            var unique = {};
            var uniqueList = [];
            for (var i = 0; i < input.length; i++) {
                if (typeof unique[input[i][key]] == "undefined") {
                    unique[input[i][key]] = "";
                    uniqueList.push(input[i]);
                }
            }        
            return uniqueList;
       }
    };
});

searcher.controller('SearcherController', function ($scope, $resource, $location) {

    $scope.properties = [
    { name: 'Domy', value: 'house' },
    { name: 'Mieszkania', value: 'flat' },
    { name: 'Działki', value: 'land' }
    ];
    $scope.myProperty = null;

    $scope.offertType = [
    { name: 'Wynajem', value: 'true' },
    { name: 'Sprzedaż', value: 'false' }
    ];
    $scope.myoffertType = null;

    $scope.loadResources = function (myProperty) {

            if (myProperty=== 'flat'){
                var flatResource = $resource('/api/offertsapi/getflats', {}, {});
                $scope.flatList = [];

                flatResource.query(function(data) {
                    $scope.flatList = [];
                    angular.forEach(data, function(userData) {
                        $scope.flatList.push(userData);
                    });
                });
            }
            else if (myProperty ==='land') {
                var landResource = $resource('/api/offertsapi/getlands', {}, {});
                $scope.landList = [];

                landResource.query(function(data) {
                    $scope.landList = [];
                    angular.forEach(data, function(userData) {
                        $scope.landList.push(userData);
                    });
                });
            }
            else if (myProperty === 'house') {
                var houseResource = $resource('/api/offertsapi/gethouses', {}, {});
                $scope.houseList = [];

                houseResource.query(function(data) {
                    $scope.houseList = [];
                    angular.forEach(data, function(userData) {
                        $scope.houseList.push(userData);
                    });
                });
            }
    };

    $scope.myhouseCity = null;
    $scope.myhouseUsableArea = null;
    $scope.myhousePrice = null;

    $scope.mylandCity = null;
    $scope.mylandArea = null;
    $scope.mylandPrice = null;

    $scope.myflatCity = null;
    $scope.myflatRoom = null;
    $scope.myflatPrice = null;

    $scope.clearFilters = function (myProperty) {
        if (myProperty === 'flat') {
            $scope.myflatCity = null;
            $scope.myflatRoom = null;
            $scope.myflatPrice = null;
            $scope.myoffertType = null;
        }
        else if (myProperty === 'land') {
            $scope.mylandCity = null;
            $scope.mylandArea = null;
            $scope.mylandPrice = null;
            $scope.myoffertType = null;
        }
        else if (myProperty === 'house') {
            $scope.myhouseCity = null;
            $scope.myhouseUsableArea = null;
            $scope.myhousePrice = null;
            $scope.myoffertType = null;
        }
    };

});
