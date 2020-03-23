window.getPlaneSize = function () {
    return {
        width: $('#plane').width(),
        height: $('#plane').height()
    };
}

window.enterUserName = function () {
    $('#myModal').modal('show');

    return true;
}

window.hideUserNameDialog = function () {
    $('#myModal').modal('hide');

    return true;
}

$(window).resize(function () {
    //https://docs.microsoft.com/en-us/aspnet/core/blazor/call-dotnet-from-javascript?view=aspnetcore-3.1

    DotNet.invokeMethodAsync('BlazorPong3.Client', 'OnWindowResize');
});

$(document).bind('keydown', function (e) {
    if (window.console)
        console.log(e.keyCode);

    switch (e.keyCode) {
        case 38:
            DotNet.invokeMethodAsync('BlazorPong3.Client', 'OnKeyDown', 38);
            break;
        case 40:
            DotNet.invokeMethodAsync('BlazorPong3.Client', 'OnKeyDown', 40);
            break;
        case 27:
            DotNet.invokeMethodAsync('BlazorPong3.Client', 'OnKeyDown', 27);
            break;
    }
});