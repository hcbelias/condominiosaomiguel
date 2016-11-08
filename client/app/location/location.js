
angular.module('condominiosmApp')
  .config(function($stateProvider) {
    $stateProvider
      .state('location', {
        url: '/location',
        templateUrl: 'app/location/location.html',
        controller: 'LocationCtrl'
      });
  });