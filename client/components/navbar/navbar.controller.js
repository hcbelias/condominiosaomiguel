'use strict';

angular.module('condominiosmApp')
  .controller('NavbarCtrl', function ($scope, Auth, ptBR, $state) {
    $scope.menu = [{
      'title': 'Condomínio São Miguel',
      'state': 'main'
    },
    {
      'title': ptBR.STRUCTURE,
      'state': 'structure'
    },
    {
      'title': ptBR.LOCALIZATION,
      'state': 'localization'
    },
    {
      'title': ptBR.APARTMENTS,
      'state': 'apartments'
    }];

    $scope.isCollapsed = true;
    $scope.isLoggedIn = Auth.isLoggedIn;
    $scope.isAdmin = Auth.isAdmin;
    $scope.getCurrentUser = Auth.getCurrentUser;
    
    $scope.Title = $scope.menu[0].title; //$state.current.name
  });
