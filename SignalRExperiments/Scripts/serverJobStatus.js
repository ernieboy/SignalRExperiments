(function () {

    var jobsHub = $.connection.jobsHub;
    $.connection.hub.logging = true;
    $.connection.hub.start();

    jobsHub.client.newJobStatus = function (jobName, jobStatus) {
        var displayMessage = 'Job with name ' + jobName + ' has status ' + jobStatus;
        $('#jobStatusDisplay').html(displayMessage);
    };

    $(function () {
        $('#btnStartJob').on('click', function (evt) {
            evt.preventDefault();
            $.post("/Hubs/ShowJobPercentageCompleted",
            {
                jobStart: $('#btnStartJob').val()
            },
            function (data, status) {
               // alert("Data: " + data + "\nStatus: " + status);
            });

           
        });
    });



}());