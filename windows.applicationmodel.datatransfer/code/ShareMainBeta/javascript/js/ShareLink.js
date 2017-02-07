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
            shareLink();
        }
    };

    //<SnippetHowToShareLink>
    function registerForShare() {
        var dataTransferManager = Windows.ApplicationModel.DataTransfer.DataTransferManager.getForCurrentView();
        dataTransferManager.addEventListener("datarequested", shareLinkHandler);
    }

    function shareLinkHandler(e) {
            var request = e.request;
            request.data.properties.title = "Share Link Example";
            request.data.properties.description = "A demonstration that shows how to add a link (URI) to share.";
            //<SnippetSetUri>
            request.data.setUri(new Windows.Foundation.Uri("http://www.fabrikam.com"));
            //</SnippetSetUri>
    }
    //</SnippetHowToShareLink>
    app.start();
})();
