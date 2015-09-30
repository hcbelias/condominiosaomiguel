'use strict';

angular.module('condominiosmApp')
  .directive('floatingbutton', function () {
    return {
      
      templateUrl: 'components/floatingbutton/floatingbutton.html',
      restrict: 'A',
      link: function (scope, element, attrs) {
      }
    };
  });