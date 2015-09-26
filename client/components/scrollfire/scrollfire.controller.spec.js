'use strict';

describe('Controller: ScrollfireCtrl', function () {

  // load the controller's module
  beforeEach(module('condominiosmApp'));

  var ScrollfireCtrl, scope;

  // Initialize the controller and a mock scope
  beforeEach(inject(function ($controller, $rootScope) {
    scope = $rootScope.$new();
    ScrollfireCtrl = $controller('ScrollfireCtrl', {
      $scope: scope
    });
  }));

  it('should ...', function () {
    expect(1).toEqual(1);
  });
});
