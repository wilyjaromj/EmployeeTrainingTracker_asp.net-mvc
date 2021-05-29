
function loadEditTraining(id) {
    $.ajax({
        url: '/Training/AddEditModal?id=' + id,
        method: 'GET',
        success: function (response) {
            $('#addEditTrainingModalBody').html(response);
            $('#addEditTrainingModal').modal('show');
        },
        error: function (xhr) {
            showError(xhr.statusText);
        }
    });
}

function saveTrainingSuccess(response) {
    if (response.status == 'success') {
        $('#training-list').load('/Training/TrainingTable');
        $('#addEditTrainingModal').modal('hide');
        $('#addEditTrainingSuccess').html('The training has been saved successfully').show().delay(5000).fadeOut(400);
    } else {
        $('#addEditTrainingError').html('There was an error trying to save the training: ' + response.message).show();
    }    
}

function saveTrainingFailure(xhr) {
    $('#addEditTrainingError').html(xhr.statusText).show();
}

function loadDeleteTraining(id) {
    $('#idToDelete').val(id);
    $('#deleteTrainingModalTitle').html('Delete Training with Id: ' + id);
    $('#deleteTrainingModal').modal('show');
}

function deleteTrainingSuccess(response) {
    if (response.status == 'success') {
        $('#training-list').load('/Training/TrainingTable');
        $('#deleteTrainingModal').modal('hide');
        $('#addEditTrainingSuccess').html('The training has been deleted successfully').show().delay(5000).fadeOut(400);
    } else {
        $('#deleteTrainingError').html('There was an error trying to delete the training: ' + response.message).show();
    }
}

function deleteTrainingFailure(xhr) {
    $('#deleteTrainingError').html(xhr.statusText).show();
}