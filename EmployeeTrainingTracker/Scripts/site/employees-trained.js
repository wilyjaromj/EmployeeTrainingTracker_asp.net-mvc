
function loadViewEmployees(id) {
    $.ajax({
        url: '/EmployeesTrained/EmployeesTrained?trainingId=' + id,
        method: 'GET',
        success: function(response) {
            $('#viewEmployeesTrainedModalBody').html(response);
            $('#viewEmployeesTrainedModal').modal('show');
        },
        error: function(xhr) {
            showError(xhr.statusText);
        }
    });
}

function loadMarkEmployeeTrained() {
    $.ajax({
        url: '/EmployeesTrained/MarkEmployeeTrainedForm',
        method: 'GET',
        success: function(response) {
            $('#markTrainedModalBody').html(response);
            $('#markTrainedModal').modal('show');
        },
        error: function(xhr) {
            showError(xhr.statusText);
        }
    });
}

function markTrainedSuccess(response) {
    if (response.status == 'success') {
        $('#markTrainedModal').modal('hide');
        $('#success').html('The employee has been marked as trained').show().delay(5000).fadeOut(400);
    } else if (response.status == 'duplicate') {
        $('#markTrainedModal').modal('hide');
        $('#warning').html('The employee has already been marked as completing that training.').show().delay(8000).fadeOut(400);
    } else {
        showMarkTrainedError(status.message);
    }
}

function markTrainedFailure(xhr) {
    showMarkTrainedError(xhr.statusText);
}

function showMarkTrainedError(message) {
    $('#markedTrainedError').html(message).show();
}