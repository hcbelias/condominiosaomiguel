function replaceOnComplete(controller, method, queryString, elementReplacedSelector) {
    $.post(controller + '/' + method, queryString, null)
            .complete(function (data) {
                $(elementReplacedSelector).html(data.responseText);
                $('ul.nav li').removeClass('active');
                $("#"+controller).parent().addClass('active');
            });
}


function isNumberKey(e) {
    var tecla = (window.event) ? event.keyCode : e.which;

    var inp = String.fromCharCode(tecla);
    if (/[0-9]/.test(inp))
        return true;
    else
        return false;
}


function openModal(controller, method, queryString, modalSelector) {
    debugger;
    $.get(controller + '/' + method, queryString, null)
            .complete(function (data) {
                debugger;
                $(modalSelector).html(data.responseText);
                $(modalSelector).modal({
                    backdrop: true,
                    show: true
                });
                
            });
}
