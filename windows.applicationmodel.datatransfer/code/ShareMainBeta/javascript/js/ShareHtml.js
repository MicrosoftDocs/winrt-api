// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

    var app = WinJS.Application;

    // This function responds to all application activations.
    app.onactivated = function (eventObject) {
        if (eventObject.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.launch) {
            // TODO: Initialize your application here.
            WinJS.UI.processAll();
            shareHtml();
        }
    };

    
    function shareHtml() {
        //<SnippetShareHtmlSetup>
        var htmlExample = "<p>Here is our store logo: <img src='images/logo.png'>.</p>";
        var fileExample = "images\\logo.png";
        //</SnippetShareHtmlSetup>
        var dataTransferManager = Windows.ApplicationModel.DataTransfer.DataTransferManager.getForCurrentView();
        dataTransferManager.addEventListener("datarequested", function (e) {
            //<SnippetGetFileForMap>
            var streamRef;
            Windows.ApplicationModel.Package.current.installedLocation.getFileAsync(fileExample).done(function (file) {
                try {
                    streamRef = new Windows.Storage.Streams.RandomAccessStreamReference.createFromFile(file);
                } catch (ex) {
                    document.getElementById("output").innerText = "Fail.";
                }
            });
            //</SnippetGetFileForMap>
            //<SnippetFormatHtml>
            var htmlFormat = Windows.ApplicationModel.DataTransfer.HtmlFormatHelper.createHtmlFormat(htmlExample);
            //</SnippetFormatHtml>
            var request = e.request;
            request.data.properties.title = "Share Html Example";
            request.data.properties.description = "A demonstration that shows how to share.";
            //<SnippetSetHtmlFormat>
            request.data.setHtmlFormat(htmlFormat);
            //</SnippetSetHtmlFormat>
            //<SnippetSetResourceMap>
            request.data.resourceMap[fileExample] = streamRef;
            //</SnippetSetResourceMap>
        });
    }

    //<SnippetHowToShareHtml>
    function shareHtmlHandler(e) {
        var request = e.request;
        var htmlExample = "<p>Here is our store logo: <img src='images/logo.png'>.</p>";
        var localImage = "images\\logo.png";
        request.data.properties.title = "Share Html Example";
        request.data.properties.description = "A demonstration that shows how to share an HTML fragment with a local image.";
        var deferral = e.request.getDeferral();
        Windows.ApplicationModel.Package.current.installedLocation.getFileAsync(localImage).done(function (imageFile) {
            request.data.setHtmlFormat(Windows.ApplicationModel.DataTransfer.HtmlFormatHelper.createHtmlFormat(htmlExample));
            request.data.resourceMap[localImage] = Windows.Storage.Streams.RandomAccessStreamReference.createFromFile(imageFile);
            deferral.complete();
        }, function (err) {
            request.failWithDisplayText(err);
        });
    }
    //</SnippetHowToShareHtml>


    app.start();
})();
