/// <reference path="../angular.js" />    
/// <reference path="../angular.min.js" />     
/// <reference path="Modules.js" />     
/// <reference path="Services.js" />     

app.controller("MVCDynamicMenuWCF_Controller", function ($scope, $window, AngularJs_WCFService) {
    $scope.date = new Date();
  

    getAllMenuDetails();

    function getAllMenuDetails() {
        var promiseGet = AngularJs_WCFService.geMenuDetails();
        promiseGet.then(function (pl) {
            console.log("Wcf data: ");
            console.log(pl.data);
            $scope.MenuDetailsDisp = pl.data;
        },
         function (errorPl) {
         });
    }

  
});
