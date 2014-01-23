function validateData() {
    $('.input-validation-error').closest(".control-group").addClass("error alert alert-error validation");
    $('.field-validation-error').closest(".control-group").addClass("error alert alert-error validation");
    $('.datetimepicker').datetimepicker({ language: 'pt-BR', pickTime: true, pickDate: true });
    $('.datepicker').datetimepicker({ language: 'pt-BR', pickTime: false, pickDate: true });
    $('.timepicker').datetimepicker({ language: 'pt-BR', pickDate: false, pickTime: true });
}

function openModalAsync(method, queryString, modalSelector) {

    $.get(method, queryString, null)
            .complete(function (data) {

                $(modalSelector).html(data.responseText);
                openModal(modalSelector);

            });
}

function closeModal(modalSelector) {
    $(modalSelector).modal('toggle');
}

function openModal(modalSelector) {

    $(modalSelector).modal({
        backdrop: true,
        keyboard: true,
        show: true
    });
}

function isTrue(value) {
    if (value == "True") {
        return true;
    }
    return false;
}

function isNumberKey(e, element, allowComma) {

    if (allowComma) {
        return isNumeric(e, element);
    }
    else {
        return isInteger(e, element);
    }
}

function isInteger(e, element) {

    var tecla = (window.event) ? event.keyCode : e.which;

    var nextChar = String.fromCharCode(tecla);
    var inputValue = $(element).val();
    var inputTest = inputValue + nextChar;
    if (/^(\d*)$/.test(inputTest))
        return true;
    else
        return false;
}

function isNumeric(e, element) {

    var tecla = (window.event) ? event.keyCode : e.which;

    var nextChar = String.fromCharCode(tecla);
    var inputValue = $(element).val();
    var inputTest = inputValue + nextChar;
    if (/^\d(\d*)([,]?)(\d*)$/.test(inputTest))
        return true;
    else
        return false;
}

