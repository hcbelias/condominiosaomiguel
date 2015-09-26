'use strict';

describe('Directive: scrollfire', function () {

  // load the directive's module
  beforeEach(module('condominiosmApp'));

  var element,
    scope;

  beforeEach(inject(function ($rootScope) {
    scope = $rootScope.$new();
  }));

  it('should make hidden element visible', inject(function ($compile) {
    element = angular.element('<scrollfire></scrollfire>');
    element = $compile(element)(scope);
    expect(element.text()).toBe('this is the scrollfire directive');
  }));
});
