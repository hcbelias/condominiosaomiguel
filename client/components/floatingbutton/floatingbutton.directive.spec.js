'use strict';

describe('Directive: floatingbutton', function () {

  // load the directive's module and view
  beforeEach(module('condominiosaomiguelsassApp'));
  beforeEach(module('components/floatingbutton/floatingbutton.html'));

  var element, scope;

  beforeEach(inject(function ($rootScope) {
    scope = $rootScope.$new();
  }));

  it('should make hidden element visible', inject(function ($compile) {
    element = angular.element('<floatingbutton></floatingbutton>');
    element = $compile(element)(scope);
    scope.$apply();
    expect(element.text()).toBe('this is the floatingbutton directive');
  }));
});