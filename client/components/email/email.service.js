'use strict';

angular.module('condominiosmApp')
  .service('Email', ['$resource',
	function EmailService($resource) {
		return $resource('/api/contacts', null, {
			'sendMessage': {
				method: 'POST'
		}});
  	}]);
