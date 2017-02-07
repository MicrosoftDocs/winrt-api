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
            shareImage();
        }
    };

    //<SnippetHowToShareImage_JS>
    //<SnippetHowToShareImage>
    function registerForShare() {
        var dataTransferManager = Windows.ApplicationModel.DataTransfer.DataTransferManager.getForCurrentView();
        dataTransferManager.addEventListener("datarequested", shareImageHandler);
    }

    function shareImageHandler(e) {
        var request = e.request;
        request.data.properties.title = "Share Image Example";
        request.data.properties.description = "A demonstration that shows how to share an image.";
        var deferral = request.getDeferral();
        Windows.ApplicationModel.Package.current.installedLocation.getFileAsync("images\\smalllogo.png").then(function (thumbnailFile) {
            //<SnippetAddThumbnailForImage_JS>
            //<SnippetAddThumbnailForImage>
            request.data.properties.thumbnail = Windows.Storage.Streams.RandomAccessStreamReference.createFromFile(thumbnailFile);
            //</SnippetAddThumbnailForImage>
            //</SnippetAddThumbnailForImage_JS>
            return Windows.ApplicationModel.Package.current.installedLocation.getFileAsync("images\\logo.png");
        }).done(function (imageFile) {
            //<SnippetSetBitmap_JS>
            //<SnippetSetBitmap>
            request.data.setBitmap(Windows.Storage.Streams.RandomAccessStreamReference.createFromFile(imageFile));
            //</SnippetSetBitmap>
            //</SnippetSetBitmap_JS>
            deferral.complete();
        }, function (err) {
            request.failWithDisplayText(err);
        });
    }
    //</SnippetHowToShareImage>
    //</SnippetHowToShareImage_JS>

    app.start();
})();
