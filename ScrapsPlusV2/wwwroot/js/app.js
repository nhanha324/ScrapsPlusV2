var app = angular.module("ScrapsPlusV2", ["ngRoute"]);
app.config(function ($routeProvider, $locationProvider) {
   
    $routeProvider
        .when("/", {
            templateUrl: "../Views/home.html",
            controller: "homeController"
        })
        .when("/home", {
            templateUrl: "../Views/home.html",
            controller: "homeController"
        })
        .otherwise("/")
    $locationProvider.html5Mode(true);
});
