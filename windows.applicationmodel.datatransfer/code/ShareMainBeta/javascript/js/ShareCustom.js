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
            shareCustomData();
        }
    };

    //<SnippetHowToShareCustomData>
    function shareCustomData() {
        //Create the custom data.
        var myArray = new Array(1, 2, 3, 4);
        var arrayToCsv = myArray.join(",");
        var dataTransferManager = Windows.ApplicationModel.DataTransfer.DataTransferManager.getForCurrentView();
        dataTransferManager.addEventListener("datarequested", function (e) {
            var request = e.request;
            request.data.properties.title = "Share Text Example";
            request.data.properties.description = "A demonstration that shows how to share.";
            //<SnippetSetCustomData>
            request.data.setData("csv", arrayToCsv);
            //</SnippetSetCustomData>
        });
    }
    //</SnippetHowToShareCustomData>
    app.start();
})();