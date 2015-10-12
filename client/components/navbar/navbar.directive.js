'use strict';

angular.module('condominiosmApp')
  .directive('navbar', function () {
    return {
      templateUrl: 'components/navbar/navbar.html',
      restrict: 'E',
      controller: 'NavbarCtrl',
      link: function(scope, element) {
        
        element.find('.button-collapse').sideNav();
      }
    };
  });
