function LoadingImage(imgUploader, previewImg)
{
    if (imgUploader.files && imgUploader.files[0]) {
        var data = new FileReader();
        data.onload = function (e)
        {
            $(previewImg).attr('src' , e.target.result);
        }
        data.readAsDataURL(imgUploader.files[0]);
    }
}
function JqueryAsAjax(form)
{
    $.validator.unobtrusive.parse(form);

    if ($(form).valid())
    {
        var ajaxConfig =
        {
            type: 'POST',
            url: form.action,
            data: new FormData(form),
            success: function (response)
            {
                $("#firstTab").html(response);
            }

        }
        if ($(form).attr('enctype') == "multipart/form-data")
        {
            ajaxConfig["processData"] = false;
            ajaxConfig["contentType"] = false;

        }
        $.ajax(ajaxConfig);
    }
    return false;
}