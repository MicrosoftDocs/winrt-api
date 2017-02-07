// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

    var app = WinJS.Application;

    // This function responds to all application activations.
    app.onactivated = function (eventObject) {
        if (eventObject.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.shareTarget) {
            //document.getElementById("output").innerText = "share target activation.";
            var shareOperation = eventObject.detail.shareOperation;
            //<SnippetReceivedContentContainsHtml>
            if (shareOperation.data.contains(Windows.ApplicationModel.DataTransfer.StandardDataFormats.html)) {
                // Code to get HTML goes here.
            }
            //</SnippetReceivedContentContainsHtml>

            // Hopefully, this code will work anyway.
            //<SnippetHowToReceiveSharedHtml>
            if (shareOperation.data.contains(Windows.ApplicationModel.DataTransfer.StandardDataFormats.html)) {
                document.getElementById("htmlContentArea").className = "unhidden";
                //<SnippetGetHtmlAsync>
                
                shareOperation.data.getHtmlFormatAsync().then(function (html) {
                    if (html !== null) {
                        var htmlFragment = Windows.ApplicationModel.DataTransfer.HtmlFormatHelper.getStaticFragment(htmlFormat);

                        // Set the innerHTML of the ifram to the HTML fragment.
                        var iFrame = document.getElementById("htmlContent");
                        iFrame.style.display = "";
                        iFrame.contentDocument.documentElement.innerHTML = htmlFragment;
                    } 
                });
                //</SnippetGetHtmlAsync>

                // Loop through any images and use the resourceMap to map each image element's src.
                var images = iFrame.contentDocument.documentElement.getElementsByTagName("img");
                if (images.length > 0) {
                    shareOperation.data.getResourceMapAsync().done(function (resourceMap) {
                        if (resourceMap.size > 0) {
                            for (var i = 0, len = images.length; i < len; i++) {
                                var streamReference = resourceMap[images[i].getAttribute("src")];
                                if (streamReference) {
                                    // Call a helper function to map the image element's src to a corresponding blob URL generated from the streamReference
                                    setResourceMapURL(streamReference, images[i]);
                                }
                            }
                        }
                    });
            }
            //shareOperation.reportCompleted();
            //</SnippetHowToReceiveSharedHtml>
        }
    };

    app.start();
})();
