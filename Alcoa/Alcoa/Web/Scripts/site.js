function validateData() {
    $('.input-validation-error').closest(".control-group").addClass("error alert alert-error validation");
    $('.field-validation-error').closest(".control-group").addClass("error alert alert-error validation");
    $('.datetimepicker').datetimepicker({ language: 'pt-BR' });
    $('.datepicker').datetimepicker({ language: 'pt-BR', pickTime: false });
    $('.timepicker').datetimepicker({ language: 'pt-BR', pickDate: false });
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
