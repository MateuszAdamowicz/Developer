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

var searcher = angular.module('searcher', ['ngResource', 'angularUtils.directives.dirPagination']);


searcher.config(function ($httpProvider) {
    $httpProvider.interceptors.push('myHttpInterceptor');

    var spinnerFunction = function spinnerFunction(data) {
        $("#spinner").show();
        return data;
    };

    $httpProvider.defaults.transformRequest.push(spinnerFunction);
    $httpProvider.defaults.timeout = 5000;
});

searcher.factory('myHttpInterceptor', function ($q, $window) {
    return{
        'response':
            function(response) {
                $("#spinner").hide();
                return response || $q.when(response);
            },
        'responseError':
            function (response) {
                $("#spinner").hide();
        return $q.reject(response);
        }
    };
});

searcher.filter('unique', function () {
    return function (input, key) {
        if (typeof input !== "undefined") {
            var unique = {};
            var uniqueList = [];
            for (var i = 0; i < input.length; i++) {
                if (typeof unique[input[i][key]] == "undefined") {
                    unique[input[i][key]] = 1;
                    uniqueList.push(input[i]);
                } else {
                    unique[input[i][key]] += 1;
                };
                }
            for (var i = 0; i < uniqueList.length; i++) {
                uniqueList[i].counter = uniqueList[i][key] + " ("+unique[uniqueList[i][key]]+")";
            }        
            return uniqueList;
       }
    };
});

searcher.controller('SearcherController', function ($scope, $resource) {

    $scope.properties = [
    { name: 'Domy', value: 'house' },
    { name: 'Mieszkania', value: 'flat' },
    { name: 'Działki', value: 'land' }
    ];
    $scope.myProperty = null;

    $scope.myoffertTypeHouse = null;
    $scope.myoffertTypeFlat = null;
    $scope.boolToStr = function (arg) { return arg ? 'Wynajem' : 'Sprzedaż' };

    $scope.loadResources = function (myProperty) {
        if (myProperty === 'flat') {
            
            $scope.mySort = null;
                var flatResource = $resource('/api/offertsapi/getflats', {}, {});
                $scope.flatList = [];

                flatResource.query(function(data) {
                    $scope.flatList = data;
                });
            
        }
        else if (myProperty === 'land') {
            $scope.mySort = null;
                var landResource = $resource('/api/offertsapi/getlands', {}, {});
                $scope.landList = [];

                landResource.query(function(data) {
                    $scope.landList = data;
                });
            }
        else if (myProperty === 'house') {
            $scope.mySort = null;
                var houseResource = $resource('/api/offertsapi/gethouses', {}, {});
                $scope.houseList = [];

                houseResource.query(function(data) {
                    $scope.houseList = data;
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


    $scope.mySortFunction = function (item) {
        if ($scope.mySort !== null) {
            if ($scope.mySort.value === 'Price') {
                return Number(item[$scope.mySort.value].split('z')[0].replace(/ /g, ''));
            } else {
                return item[$scope.mySort.value];
            }
        }
        }

    $scope.sorting = [
        { name: 'Po cenie-rosnąco', value: 'Price', reverse:false},
        { name: 'Po cenie-malejąco', value: 'Price',reverse:true},
        { name: 'Po dacie-rosnąco', value: 'CreatedAt', reverse:false},
        { name: 'Po dacie-malejąco', value: 'CreatedAt', reverse:true}
    ];

    $scope.mySort = null;

    $scope.clearFilters = function (myProperty) {
        if (myProperty === 'flat') {
            $scope.myoffertTypeHouse = null;
            $scope.myoffertTypeFlat = null;
            $scope.myflatCity = null;
            $scope.myflatRoom = null;
            $scope.myflatPrice = null;
            $scope.myoffertType = null;
            $scope.mySort = null;
        }
        else if (myProperty === 'land') {
            $scope.mylandCity = null;
            $scope.mylandArea = null;
            $scope.mylandPrice = null;
            $scope.myoffertType = null;
            $scope.mySort = null;
        }
        else if (myProperty === 'house') {
            $scope.myoffertTypeHouse = null;
            $scope.myoffertTypeFlat = null;
            $scope.myhouseCity = null;
            $scope.myhouseUsableArea = null;
            $scope.myhousePrice = null;
            $scope.myoffertType = null;
            $scope.mySort = null;
        }
    };
    $scope.currentPage = 1;
    $scope.pageSize = 5;

});


searcher.controller("NewestController", function ($scope, $resource) {
    $scope.NewestAdverts = [];
    var newestResource = $resource('/api/offertsapi/getnewest', {}, {timeout: {params: 5000}});
    newestResource.query(function(data) {
        $scope.NewestAdverts = data;
    });
});

//searcher.controller('MyController', function($scope) {

//    $scope.currentPage = 1;
//    $scope.pageSize = 10;
//    $scope.meals = [];

//    var dishes = [
//        'noodles',
//        'sausage',
//        'beans on toast',
//        'cheeseburger',
//        'battered mars bar',
//        'crisp butty',
//        'yorkshire pudding',
//        'wiener schnitzel',
//        'sauerkraut mit ei',
//        'salad',
//        'onion soup',
//        'bak choi',
//        'avacado maki'
//    ];
//    var sides = [
//        'with chips',
//        'a la king',
//        'drizzled with cheese sauce',
//        'with a side salad',
//        'on toast',
//        'with ketchup',
//        'on a bed of cabbage',
//        'wrapped in streaky bacon',
//        'on a stick with cheese',
//        'in pitta bread'
//    ];
//    for (var i = 1; i <= 100; i++) {
//        var dish = dishes[Math.floor(Math.random() * dishes.length)];
//        var side = sides[Math.floor(Math.random() * sides.length)];
//        $scope.meals.push('meal ' + i + ': ' + dish + ' ' + side);
//    }

//    $scope.pageChangeHandler = function(num) {
//        console.log('meals page changed to ' + num);
//    };
//});

//searcher.controller('OtherController', function($scope) {
//    $scope.pageChangeHandler = function(num) {
//        console.log('going to page ' + num);
//    };
//});
