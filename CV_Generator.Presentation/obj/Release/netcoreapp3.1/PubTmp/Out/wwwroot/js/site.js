// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {

    $('#btnSolicitar').click(function () {
        $('#formulario').hide(2000, function () {
            $('#spinner').removeClass('d-none');
        });

    });    

});
