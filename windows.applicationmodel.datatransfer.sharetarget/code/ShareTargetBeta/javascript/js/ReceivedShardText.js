// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

    var app = WinJS.Application;
    var output = document.getElementById("output");

    // This function responds to all application activations.
    app.onactivated = function (eventObject) {
        if (eventObject.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.shareTarget) {
            //document.getElementById("output").innerText = "shareTarget Activation success.";

            //<SnippetHowToReceiveSharedText>
            var shareOperation = eventObject.detail.shareOperation;
            if (shareOperation.data.contains(Windows.ApplicationModel.DataTransfer.StandardDataFormats.text)) {
                //<SnippetGetTextAsync>
                shareOperation.data.getTextAsync().done(function (text) {
                        // To output the text using this example, 
                        // you need a div tag with an id of "output" in your HTML file.
                        document.getElementById("output").innerText = text;
                    }, function (e) {
                        displayError("Error retrieving Text format: " + e);
                    }
                });
                //</SnippetGetTextAsync>
            }
            //</SnippetHowToReceiveSharedText>

            //<SnippetReceivedContentContainsText>
            if (shareOperation.data.contains(Windows.ApplicationModel.DataTransfer.StandardDataFormats.text)) {
                // Code to process text goes here.      
            }
            //</SnippetReceivedContentContainsText>

        }
    };

    app.start();
})();
