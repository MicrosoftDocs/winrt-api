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
    /* registerForShare()is a basic share example. It demonstrates the following elements of the DataTransfer namespace:
                * DataTransfer.getForCurrentView()
                * DataRequested event
                * DataRequest object
                * DataPackagePropertySet (general)
                * DataPackagePropertySet.title
                * DataPackagePropertySet.description
                * setText()
        */
    function registerForShare() {
        var dataTransferManager = Windows.ApplicationModel.DataTransfer.DataTransferManager.getForCurrentView();
        dataTransferManager.addEventListener("datarequested", function (e) {
            var request = e.request;
            request.data.properties.title = "Share Text Example";
            request.data.properties.description = "A demonstration that shows how to share.";
            //<SnippetSetText_JS>
            //<SnippetSetText>
            request.data.setText("Hello World!");
            //</SnippetSetText>
            //</SnippetSetText_JS>
        });
    }

    //<SnippetHowToShareTextBasic_JS>
    //<SnippetHowToShareTextBasic>
    function registerForShare() {
        var dataTransferManager = Windows.ApplicationModel.DataTransfer.DataTransferManager.getForCurrentView();
        dataTransferManager.addEventListener("datarequested", shareTextHandler);
    }

    function shareTextHandler(e) {
        var request = e.request;
        request.data.properties.title = "Share Text Example";
        request.data.properties.description = "A demonstration that shows how to share.";
        request.data.setText("Hello World!");
    }
    //</SnippetHowToShareTextBasic>
    //</SnippetHowToShareTextBasic_JS>

    app.start();
})();
