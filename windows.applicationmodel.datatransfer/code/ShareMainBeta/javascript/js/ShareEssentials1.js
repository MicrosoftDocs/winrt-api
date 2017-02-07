// The code here is not intended for actual use. Instead, it contains portions of other samples that are re-used frequently in how-to and quickstart topics.
// I have added the code here in case any changes need to be made. That way, the change affects all topics at once.

(function () {
    "use strict";

    var app = WinJS.Application;

    // This function responds to all application activations.
    app.onactivated = function (eventObject) {
        if (eventObject.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.launch) {
            // TODO: Initialize your application here.
            WinJS.UI.processAll();
            shareEssentials();
            shareEmptyDataRequestedEvent();
        }
    };


    function shareEssentials() {
        //<SnippetGetDataTransferManagerEssentials>
        var dataTransferManager = Windows.ApplicationModel.DataTransfer.DataTransferManager.getForCurrentView();
        //</SnippetGetDataTransferManagerEssentials>
        dataTransferManager.addEventListener("datarequested", function (e) {
            //<SnippetGetDataRequestObject_JS>
            //<SnippetGetDataRequestObject>
            var request = e.request;
            //</SnippetGetDataRequestObject>
            //</SnippetGetDataRequestObject_JS>
            request.data.properties.title = "Share Example";
            request.data.properties.description = "A demonstration of share.";

        });
    }


    function shareEssentials2() {
        //<SnippetGetDataTransferManagerEssentials_JS>
        var dataTransferManager = Windows.ApplicationModel.DataTransfer.DataTransferManager.getForCurrentView();
	dataTransferManager.addEventListener("datarequested", shareAsyncHandler);
        //</SnippetGetDataTransferManagerEssentials_JS>
    }


    function shareEmptyDataRequestedEvent() {
        var dataTransferManager = Windows.ApplicationModel.DataTransfer.DataTransferManager.getForCurrentView();
        //<SnippetShareEmptyDataRequestedEvent_JS>
        //<SnippetShareEmptyDataRequestedEvent>
        dataTransferManager.addEventListener("datarequested", function (e) {
            // Code to handle event goes here.
        });
        //</SnippetShareEmptyDataRequestedEvent>
        //</SnippetShareEmptyDataRequestedEvent_JS>
    }
    app.start();
})();
