// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

    var app = WinJS.Application;

    // This function responds to all application activations.
    app.onactivated = function (eventObject) {
        if (eventObject.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.shareTarget) {
            var shareOperation = eventObject.detail.shareOperation;
            //<SnippetReceivedContentContainsBitMap>
            if (shareOperation.data.contains(Windows.ApplicationModel.DataTransfer.StandardDataFormats.bitmap)) {
                // Code to process bitmap goes here.
            }
            //</SnippetReceivedContentContainsBitMap>

            // Hopefully, this code will work anyway.
            //<SnippetHowToReceiveImage>
            if (shareOperation.data.contains(Windows.ApplicationModel.DataTransfer.StandardDataFormats.bitmap)) {

                //<SnippetGetThumbnail>
                if (shareOperation.data.properties.thumbnail) {
                    shareOperation.data.properties.thumbnail.openReadAsync().then(function (thumbnailStream) {
                        var thumbnailBlob = MSApp.createBlobFromRandomAccessStream(thumbnailStream.contentType, thumbnailStream);
                        var thumbnailUrl = URL.createObjectURL(thumbnailBlob, false);
                        // To display the thumbnail, you need an element with id of "thumbnail"
                        // in your HTML page.
                        document.getElementById("thumbnail").src = thumbnailUrl;
                    });
                }
                //</SnippetGetThumbnail>
                //<SnippetGetBitmapAsync>
                shareOperation.data.getBitmapAsync().then(function (streamRef) {
                    streamRef.openReadAsync().then(function (bitmapStream) {
                        if (bitmapstream) {
                            var blob = MSApp.createBlobFromRandomAccessStream(bitmapStream.contentType, bitmapstream);
                            var imageUrl = URL.createObjectURL(blob, false);
                            // To display the image, you need an element with id of "imageholder"
                            // in your HTML page.
                            document.getElementById("imageholder").src = imageUrl;
                        }
                    });
                 });
                //</SnippetGetBitmapAsync>
            }
            shareOperation.reportCompleted();
            //</SnippetHowToReceiveImage>
        }
    };

    app.start();
})();
