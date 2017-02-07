// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

    var app = WinJS.Application;

    // This function responds to all application activations.
    app.onactivated = function (eventObject) {
        if (eventObject.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.shareTarget) {
            var shareOperation = eventObject.detail.shareOperation;
            //<SnippetReceivedContentContainsUri>
            if (shareOperation.data.contains(Windows.ApplicationModel.DataTransfer.StandardDataFormats.uri)) {
                // Code to process URI goes here.
            }
            //</SnippetReceivedContentContainsUri>

            // Hopefully, this code will work anyway.
            //<SnippetHowToReceiveSharedLink>
            if (shareOperation.data.contains(Windows.ApplicationModel.DataTransfer.StandardDataFormats.uri)) {
                //<SnippetGetUriAsync>
                shareOperation.data.getUriAsync().then(function (uri) {
                    if (uri !== null) {
                        // To output the link using this example, 
                        // you need a div tag with an id of "output" in your HTML file.
                        document.getElementById("output").innerText = uri.absoluteUri;
                    }
                });
                //</SnippetGetUriAsync>
            }
            shareOperation.reportCompleted();
            //</SnippetHowToReceiveSharedLink>
        }
    };

    app.start();
})();
