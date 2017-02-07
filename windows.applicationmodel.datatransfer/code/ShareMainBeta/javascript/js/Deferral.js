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
    //<SnippetHowToShareDeferral>
    function shareImage() {
        var shareImage;
        var shareThumbnail;
        Windows.ApplicationModel.Package.current.installedLocation.getFileAsync("images\\logo.png").then(function (file) {
            shareImage = file;
        });
        Windows.ApplicationModel.Package.current.installedLocation.getFileAsync("images\\smalllogo.png").then(function (file) {
            shareThumbnail = file;
        });
        var dataTransferManager = Windows.ApplicationModel.DataTransfer.DataTransferManager.getForCurrentView();
        dataTransferManager.addEventListener("datarequested", function (e) {
            var request = e.request;
            //<SnippetGetDeferral_JS>
            //<SnippetGetDeferral>
            var deferral = request.getDeferral();
            //</SnippetGetDeferral>
            //</SnippetGetDeferral_JS>
            request.data.properties.title = "Share Image Example";
            request.data.properties.description = "A demonstration that shows how to share an image.";
            var thumbnailStreamReference = Windows.Storage.Streams.RandomAccessStreamReference.createFromFile(shareThumbnail);
            request.data.properties.thumbnail = thumbnailStreamReference;
            var shareImageReference = Windows.Storage.Streams.RandomAccessStreamReference.createFromFile(shareImage);
            request.data.setBitmap(shareImageReference);
            //<SnippetDeferralComplete_JS>
            //<SnippetDeferralComplete>
            deferral.complete();
            //</SnippetDeferralComplete>
            //</SnippetDeferralComplete_JS>
        });

    }
    //</SnippetHowToShareDeferral>
    app.start();
})();
