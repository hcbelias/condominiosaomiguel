function replaceOnComplete(route, queryString, elementReplacedSelector) {
    $.post(route, queryString, null)
            .complete(function (data) {
                debugger;
                $(elementReplacedSelector).html(data.responseText);
            });
}
