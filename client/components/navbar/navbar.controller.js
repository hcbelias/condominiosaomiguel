/* global angular */
'use strict';

angular.module('condominiosmApp')
  .controller('NavbarCtrl', function ($scope) {

    $scope.Title = 'Condomínio São Miguel'; //$scope.menu[0].title;
    
    $scope.setActive = function(elementSelector){
      angular.element('.nav-wrapper ul li').removeClass('active');
      angular.element(elementSelector).addClass('active');      
    };
  });
