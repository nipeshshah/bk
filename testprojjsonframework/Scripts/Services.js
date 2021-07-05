var baseUrl = "/api/"
//var baseUrl = "https://digitalsign.msbc.in/api/"
//var baseUrl = "/api/"
//$.ajaxSetup({
//    beforeSend: function (xhr) {
//        xhr.setRequestHeader('Authorization', `Bearer ${loginconfiguration.token}`);
//    }
//});

var services =
{
    getService: function (url, callback, errorCallBack) {
        //alert(baseUrl + url);
        var settings = {
            "url": baseUrl + url,
            "method": "GET",
            //"headers": {
            //    'authorization': `bearer ${loginconfiguration.token}`,
            //},
            "timeout": 0,
            error: function (err) {
                if (errorCallBack == undefined && toastr == undefined)
                    alert(err.responseJSON.message);
                else
                    errorCallBack(err);
            },
            success: callback
        };

        $.ajax(settings);
    },
    //getService: function (url, callback, errorCallBack) {
    //    //alert(baseUrl + url);
    //    var settings = {
    //        "url": baseUrl + url,
    //        "method": "GET",
    //        "timeout": 0,
    //        error: function (err) {
    //            if (errorCallBack == undefined && toastr != undefined)
    //                toastr.error(err.responseJSON.message);
    //            else if (errorCallBack == undefined && toastr == undefined)
    //                alert(err.responseJSON.message);
    //            else
    //                errorCallBack(err);
    //        },
    //        success: callback
    //    };

    //    $.ajax(settings);
    //},
    postUploadService: function (url, formdata, callback, errorCallBack) {
        var settings = {
            "url": baseUrl + url,
            "method": "POST",
            "timeout": 0,
            //"headers": {
            //    'authorization': `bearer ${loginconfiguration.token}`,
            //},
            "processData": false,
            "mimeType": "multipart/form-data",
            "contentType": false,
            "data": formdata,
            error: function (err) {
                var errorMessage = {}
                if (err.responseJSON == undefined) {
                    errorMessage = JSON.parse(err.responseText)
                }
                else
                    errorMessage = err.responseJSON;

                if (errorCallBack == undefined && toastr != undefined)
                    toastr.error(errorMessage.message);
                else if (errorCallBack == undefined && toastr == undefined)
                    alert(errorMessage.message);
                else
                    errorCallBack(errorMessage);

                //if (err.responseJSON != undefined)
                //    alert(err.responseJSON.message);
                //else {
                //    err = JSON.parse(err.responseText);
                //    alert(err.message);
                //}
            },
            success: callback
        };

        $.ajax(settings);
    },
    postService: function (url, formData, callback, errorCallBack) {
        //alert(baseUrl + url);
        var settings = {
            "url": baseUrl + url,
            "method": "POST",
            //"headers": {
            //    'authorization': `bearer ${loginconfiguration.token}`,
            //},
            "timeout": 0,
            "processData": false,
            "contentType": "application/json",
            //"headers": {
            //    "Content-Type": "application/json"
            //},
            "data": formData,
            error: function (err) {
                if (errorCallBack == undefined && toastr != undefined)
                    toastr.error(err.responseJSON.message);
                else if (errorCallBack == undefined && toastr == undefined)
                    alert(err.responseJSON.message);
                else
                    errorCallBack(err);
            },
            success: callback
        };

        $.ajax(settings);
    },

}

function errorCallBack(err) {
    console.log(err);
}