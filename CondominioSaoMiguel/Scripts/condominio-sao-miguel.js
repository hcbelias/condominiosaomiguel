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
    
    $.get(controller + '/' + method, queryString, null)
            .complete(function (data) {
                
                $(modalSelector).html(data.responseText);
                $(modalSelector).modal({
                    backdrop: true,
                    show: true
                });
                
            });
        }

function disable(formSelector, disable) {

    $(formSelector).find('input').each(function() {
        $(this).attr("disabled", disable);
    });
}

$(document).ready(function () {
    $(".nav li").mouseover(function () {
        if (!$(this).hasClass('active')) {
            $(this).addClass('active');
            $(this).mouseout(function () {
                $(this).removeClass('active');
            });
        }
    });
});