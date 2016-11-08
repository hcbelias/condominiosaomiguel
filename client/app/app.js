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

      $urlRouterProvider.otherwise('/');
      $locationProvider.hashPrefix('!')
      $locationProvider.html5Mode(true);
  });
