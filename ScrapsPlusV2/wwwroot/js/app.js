var app = angular.module("ScrapsPlusV2", ["ngRoute"]);
app.config(function ($routeProvider) {
    $routeProvider
        .when("/nhanha", {
            
            templateUrl: "../Views/home.html",
            controller: "homeController.js"

        })
});
