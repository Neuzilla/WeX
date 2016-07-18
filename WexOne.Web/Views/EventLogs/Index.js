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
            "order": [[ 0, "desc" ]],
            columns: [
                { "width":"200","data": "CreationTime", "render": function (d) { return moment(d).format('YYYY/MM/DD hh:mm:ss');} },
                { "data": "FromUserName" },
                { "data": "ToUserName" },
                { "width":"80","data": "MsgType" },
                {
                    "width":"40%",
                    "data": "OriginalXml", "render": function (d) {
                        return $('<div/>').text(d).html();
                    }
                }
            ]
        });
    });

})();