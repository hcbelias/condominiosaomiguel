'use strict';

angular.module('condominiosmApp')
  .directive('footer', function () {
    return {
      templateUrl: 'components/footer/footer.html',
      restrict: 'E',
      controller: 'FooterCtrl',
      link: function (scope, element) {
        element.addClass('footer');
      }
    };
  });
