// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function validateWordDays(empId, currentDays) {
    $('#errorMessage').css('display', 'none');
    var hours = $('#txtWorkedDays_' + empId).val();
    if (parseInt(hours) > 260) {
        $('#errorMessage').text('Worked Days should be between 0 and 260');
        $('#errorMessage').css('display', '');
    }
    else if (parseInt(hours) < parseInt(currentDays)) {
        $('#errorMessage').text('New Worked Days should be greater than previous days');
        $('#errorMessage').css('display', '');
    }
    else {
        var urlGet = window.location.href + "WorkDays?id=" + empId + "&days=" + hours;
        $.ajax({

            url: urlGet,
            type: 'GET',
            dataType: 'text/json',
            success: function () {
                $('#errorMessage').css('display', 'none');
                location.reload();
            },
            error: function (request, error) {
                $('#errorMessage').css('display', 'none');
                location.reload();
            }
        });
    }
    event.preventDefault();
}

function validateVacationDays(empId, currentVacationDays) {
    $('#errorMessage').css('display', 'none');
    var hours = $('#txtVacationDays_' + empId).val();
    if (parseFloat(currentVacationDays) < 1.0) {
        $('#errorMessage').text('Minimum vacation balance should be 1 to take a vacation');
        $('#errorMessage').css('display', '');
    }
    else if (parseFloat(currentVacationDays) < parseFloat(hours)) {
        $('#errorMessage').text('Vacation balance should be greater than requesting days');
        $('#errorMessage').css('display', '');
    }
    else {
        var urlGet = window.location.href + "TakeVacation?id=" + empId + "&days=" + hours;
        $.ajax({

            url: urlGet,
            type: 'GET',
            dataType: 'text/json',
            success: function () {
                $('#errorMessage').css('display', 'none');
                location.reload();
            },
            error: function (request, error) {
                $('#errorMessage').css('display', 'none');
                location.reload();
            }
        });
    }
    event.preventDefault();
}
