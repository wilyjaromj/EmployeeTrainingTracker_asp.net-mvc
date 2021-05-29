
function loadEditTraining(id) {
    $.ajax({
        url: '/Training/AddEditModal?id=' + id,
        method: 'GET',
        success: function (response) {
            $('#addEditTrainingModalBody').html(response);
            $('#addEditTrainingModal').modal('show');
        },
        error: function (xhr) {
            showError(xhr.responseText);
        }
    });
}

function saveTrainingSuccess(response) {
    if (response.status == 'success') {
        $('#training-list').load('/Training/TrainingTable');
        $('#addEditTrainingModal').modal('hide');
        $('#addEditTrainingSuccess').html('The training has been saved successfully').show().delay(5000).fadeOut(400);
    } else {
        $('#addEditTrainingError').html(response.message).show();
    }    
}

function saveTrainingFailure(xhr) {
    $('#addEditTrainingError').html(xhr.responseText).show();
}