'use strict';

angular.module('condominiosmApp')
  .controller('FooterCtrl', function($scope, Email) {

    $scope.isValidField = function(fieldName){
      return $scope.contactForm[fieldName].$dirty && 
        $scope.contactForm[fieldName].$valid;
    };


    $scope.isValidForm = function(){
      return $scope.isValidField('name') &&
        $scope.isValidField('email') &&
        $scope.isValidField('message');
    };

    $scope.isValidFormSubmitted = function(){
      return $scope.isValidForm() &&
        $scope.contactForm.$submitted;
    };
 
    $scope.setDisableButton = function(){
      $scope.submitButtonDisabled = $scope.contactForm.$invalid;
    };
  
    $scope.showValidationMessage = function(fieldName){
      return !$scope.isValidField(fieldName) && $scope.contactForm.$submitted;
    };

    $scope.clearMessage = function(){
      $scope.showSuccessfullMessage = false;
      $scope.showErrorMessage = false;
    };

    $scope.showMessage = function(successfull){
      $scope.showSuccessfullMessage = successfull;
      $scope.showErrorMessage = !successfull;
      $scope.showForm = false;
    };    

    $scope.sendMessage = function(){
      if ($scope.contactForm.$valid) {
        $scope.clearMessage();
        $scope.contactForm.$error = { };
        var contact = {
          'email': $scope.email,
          'name': $scope.name,
          'message': $scope.message,
          'phone': $scope.phone
        };
        Email.sendMessage(contact)
          .$promise.then(function(greeting) {
            console.log(greeting);
            $scope.showMessage(true);
          }, function(reason) {
            console.log(reason);          
            $scope.contactForm.$error = { 
              'message' : 'Ocorreu um erro ao processar a solicitacação. Por favor, tente mais tarde.',
            };
            $scope.showMessage(true);
          }
        );
      } else{
        $scope.showValidationMessage('name');
        $scope.showValidationMessage('email');
        $scope.showValidationMessage('message');
      }
    };

    
    $scope.clearMessage();
    $scope.showForm = true;
    
  });
