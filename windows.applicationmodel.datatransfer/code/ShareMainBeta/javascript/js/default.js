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
            shareText();
        }
    };

    /* shareText()is a basic share example. It demonstrates the following elements of the DataTransfer namespace:
                * DataTransfer.getForCurrentView()
                * DataRequested event
                * DataRequest object
                * DataPackagePropertySet (general)
                * DataPackagePropertySet.title
                * DataPackagePropertySet.description
                * setText()
        */
    //<SnippetHowToShareText>
    function shareText() {
        var dataTransferManager = Windows.ApplicationModel.DataTransfer.DataTransferManager.getForCurrentView();
        dataTransferManager.addEventListener("datarequested", function (e) {
            var request = e.request;
            request.data.properties.title = "Share Text Example";
            request.data.properties.description = "A demonstration that shows how to share.";
            request.data.setText("Hello World!");
        });
    }
    //</SnippetHowToShareText>
    app.start();
})();
