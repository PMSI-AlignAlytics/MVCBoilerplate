function showSource(sourceElement) {
    $(sourceElement).show();
    return false;
}

$(document).ready(function () {
    // CSS Helpers
    $('table').find('tr:even').addClass('alt');
    $('table').find('tr:first-child').addClass('first');
    $('table').find('tr:last-child').addClass('last');
    $('ul').find('li:first-child').addClass('first');
    $('ul').find('li:last-child').addClass('last');
    $('hr').before('<div class="clear">&nbsp;</div>');
});