// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;



    app.oncheckpoint = function (args) {
        // TODO: This application is about to be suspended. Save any state
        // that needs to persist across suspensions here. You might use the
        // WinJS.Application.sessionState object, which is automatically
        // saved and restored across suspension. If you need to complete an
        // asynchronous operation before your application is suspended, call
        // args.setPromise().
    };
    // <SnippetInitialize>
    var proximityDevice;
 
    app.onactivated = function (args) {
        if (args.detail.kind === activation.ActivationKind.launch) {
            initializeProximitySample();

            args.setPromise(WinJS.UI.processAll());
        }
    };

    function id(elementId) {
        return document.getElementById(elementId);
    }

    function initializeProximitySample() {
        proximityDevice = Windows.Networking.Proximity.ProximityDevice.getDefault();

        if (proximityDevice) {
            id("publishUriButton").addEventListener("click", publishUri);
            id("stopPublishingUriButton").addEventListener("click",
		    stopPublishingUri);
        }
        else {
            id("messageDiv").innerHTML += "Failed to initialize proximity device." +
                 "Your device may not have proximity hardware.<br />";
        }
    }
    // </SnippetInitialize>

    // <SnippetPublishSubscribeUri>
    var publishedUriId = -1;

    function publishUri() {
        // Stop publishing the current Uri.
        if (publishedUriId != -1) {
            proximityDevice.stopPublishingUri(publishedUriId);
        }

        publishedUriId =
	    proximityDevice.publishUri(new Windows.Foundation.Uri("http://www.microsoft.com"));
    }

    function stopPublishingUri() {
        proximityDevice.stopPublishingMessage(publishedUriId);
    }
    // </SnippetPublishSubscribeUri>

    function exclude() {
    // <SnippetPublishSubscribeUri2>
    var publishedUriId = -1;
    var subscribedUriId = -1;

    function publishUri() {
        // Stop publishing the current Uri.
        if (publishedUriId != -1) {
            proximityDevice.stopPublishingUri(publishedUriId);
        }

        publishedUriId =
	    proximityDevice.publishUri(new Windows.Foundation.Uri("http://www.microsoft.com"),
                                       uriTransmitted);
    }

    function uriTransmitted(sender, messageId) {
	// The Uri has been successfully transmitted.
    }

    function stopPublishingUri() {
        proximityDevice.stopPublishingMessage(publishedUriId);
    }
    // </SnippetPublishSubscribeUri2>
    }

    app.oncheckpoint = function (eventObject) {
        // TODO: This application is about to be suspended. Save any state
        // that needs to persist across suspensions here. You might use the 
        // WinJS.Application.sessionState object, which is automatically
        // saved and restored across suspension. If you need to complete an
        // asynchronous operation before your application is suspended, call
        // eventObject.setPromise(). 
    };

    app.start();
})();
