
angular.module('condominiosmApp')
  .config(function($stateProvider) {
    $stateProvider
      .state('structure', {
        url: '/structure',
        templateUrl: 'app/structure/structure.html',
        controller: 'StructureCtrl'
      });
  });