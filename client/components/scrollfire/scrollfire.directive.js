'use strict';

angular.module('condominiosmApp')
  .directive('scrollfire', function () {
    return {
      restrict: 'A',
      controller: 'ScrollfireCtrl',
      link: function (scope, element, attrs) {
        element.text('this is the scrollfire directive');
      }
    };
  });
