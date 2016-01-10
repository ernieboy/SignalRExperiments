(function () {
    var realTimeDataHub = $.connection.realtimeDataHub;
    $.connection.hub.logging = true;
    $.connection.hub.start();

    realTimeDataHub.client.newServerTime = function (newTime) {
        $('#timeDisplay').html(newTime);
    };
}());