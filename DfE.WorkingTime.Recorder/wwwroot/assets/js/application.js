$(document).ready(function () {
    window.GOVUKFrontend.initAll();

    $('.show-hide-content').on('click', '.show-key', function (e) {
        e.preventDefault();
        var oldMarkup = $('.show-hide-content').html();
        var that = $(this);
        $.get(that.attr('href'), function (data, status) {
            var newMarkup = data;
            newMarkup += '<a class="block govuk-!-font-size-16 govuk-!-font-weight-regular" href="#">Copy ' + that.attr('data-type') + '</a>';
            $('.show-hide-content').html(newMarkup);

            setTimeout(function () { $('.show-hide-content').html(oldMarkup); }, 5000);
        });
    });
})  