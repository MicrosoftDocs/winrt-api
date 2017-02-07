// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

    var app = WinJS.Application;

    // <SnippetInitialize>
    var proximityDevice;

    app.onactivated = function (eventObject) {
        if (eventObject.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.launch) {
            
            initializeProximitySample();

            WinJS.UI.processAll();
        }
    };

    function id(elementId) {
        return document.getElementById(elementId);
    }
        
    function initializeProximitySample() {
        proximityDevice = Windows.Networking.Proximity.ProximityDevice.getDefault();

        if (proximityDevice) {
            id("publishMessageButton").addEventListener("click", publishMessage);
            id("subscribeForMessageButton").addEventListener("click", subscribeForMessage);
            id("stopSubscribingForMessageButton").addEventListener("click",
                stopSubScribingForMessage);
            id("stopPublishingMessageButton").addEventListener("click",
		    stopPublishingMessage);
        }
        else {
            id("messageDiv").innerHTML += "Failed to initialize proximity device." +
                 "Your device may not have proximity hardware.<br />";
        }
    }
    // </SnippetInitialize>

    // <SnippetPublishSubscribe>
    var publishedMessageId = -1;
    var subscribedMessageId = -1;

    function publishMessage() {
        // Stop publishing the current message.
        if (publishedMessageId != -1) {
            proximityDevice.stopPublishingMessage(publishedMessageId);
        }

        publishedMessageId =
		proximityDevice.publishMessage("Windows.SampleMessage", id("messageText").value);
    }

    function subscribeForMessage() {
        // Only subscribe for the message one time.
        if (subscribedMessageId === -1) {
            subscribedMessageId =
		proximityDevice.subscribeForMessage("Windows.SampleMessage", messageReceived);
        }
    }

    function messageReceived(device, message) {
        id("messageDiv").innerHTML += "Message received: " + message.dataAsString + "<br />";
    }

    function stopSubscribingForMessage() {
        proximityDevice.stopSubscribingForMessage(subscribedMessageId);
    }

    function stopPublishingMessage() {
        proximityDevice.stopPublishingMessage(publishedMessageId);
    }
    // </SnippetPublishSubscribe>

    app.start();
})();
