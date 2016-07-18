(function () {

    $(function () {
        var _eventLogService = abp.services.app.weChatEventLog;


        $("#eventLogTable").DataTable({
            "lengthMenu": [25, 50, 100],
            "pagingType": "simple_numbers",
            "serverSide": true,
            "processing": true,
            "ajax":{
                "url": abp.appPath + 'eventLogs/GetEventLogsList',
                "type": "POST",
                "dataSrc":"data"
            },
            columns: [
                { "data": "CreationTime", "render": function (d) { return moment(d).format('YYYY/MM/DD hh:mm:ss');} },
                { "data": "FromUserName" },
                { "data": "ToUserName" },
                { "data": "MsgType" },
                {
                    "data": "OriginalXml", "render": function (d) {
                        return $('<div/>').text(d).html();
                    }
                }
            ]
        });
    });

})();