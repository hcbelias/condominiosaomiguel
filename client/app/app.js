'use strict';

angular.module('condominiosmApp', [
  'ngCookies',
  'ngResource',
  'ngSanitize',
  'ui.router',
  'validation.match',
  'pascalprecht.translate'
])
  .config(function($stateProvider, $urlRouterProvider, $locationProvider, $httpProvider, $translateProvider, ptBR) {
	    //I18N
      $translateProvider.translations('pt-BR', ptBR);
      $translateProvider.preferredLanguage('pt-BR');
      $translateProvider.useSanitizeValueStrategy('escape');

      //Route
      $stateProvider    
        .state('main', {
            url: '#/',
            templateUrl: 'app/main/main.html',
            controlleR: 'MainCtrl'
        })
        .state('structure', {
            url: '#/structure',
            templateUrl: 'app/structure/structure.html',
            controlleR: 'StructureCtrl'
        })
        .state('location', {
            url: '#/location',
            templateUrl: 'app/location/location.html',
            controlleR: 'LocationCtrl'
        })
        .state('contact', {
            url: '#/contact',
            templateUrl: 'app/contact/contact.html',
            controlleR: 'ContactCtrl'
        });

      $urlRouterProvider.otherwise('/');

      $locationProvider.html5Mode(true);
  });
