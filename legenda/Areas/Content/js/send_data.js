function SendData(url, data) {
    $.ajax({
        type: "POST",
        url: url,
        processData: false,
        contentType: false,
        data: data,
        success: function (message) {
            if (message !== null) {
                swal({
                    title: message.Title,
                    text: message.Description,
                    icon: message.Success ? "success" : "error",
                    button: "დახურვა",
                    dangerMode: !message.Success
                })
                .then((willDelete) => {
                    if (willDelete) {
                        if (message.Success) {
                            if (message.RedirectUrl !== null && message.RedirectUrl !== "") {
                                setTimeout(function () { window.location.href = message.RedirectUrl; }, 500);

                            }
                        }
                    }
                });

                //if (message.NewImageUrl !== null && message.NewImageUrl !== "") {
                //    var imgUrl = Path + message.NewImageUrl;
                //    var imgobj = $('.activeImage');
                //    window[imgobj.attr('data-name')].destroy();
                //    imgobj.attr('src', imgUrl);
                //    CutImage(imgobj);
                //}


            }
        }
    });
}