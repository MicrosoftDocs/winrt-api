(function() {
    'use strict';

    // <SnippetInitialize> 
    function id(elementId) {
        return document.getElementById(elementId);
    }

    WinJS.Application.onmainwindowactivated = function (e) {
        if (e.detail.kind === Windows.ApplicationModel.Activation.ActivationKind.launch) {

            var proximityDevice = Windows.Networking.Proximity.ProximityDevice.getDefault();

            if (proximityDevice != null) {
                proximityDevice.addEventListener("devicearrived", 
                                                 proximityDeviceArrived, false);
                proximityDevice.addEventListener("devicedeparted", 
                                                 proximityDeviceDeparted, false);
            }
            else {
                id("MessageBlock").innerHTML += "Failed to initialize proximity device.<br/>";
            }

        }
    }
    // </SnippetInitialize>
    
    // <SnippetEvents>
    function proximityDeviceArrived() {
        id("MessageBlock").innerHTML += "Proximate device arrived.<br/>";
    }

    function proximityDeviceDeparted() {
        id("MessageBlock").innerHTML += "Proximate device departed.<br/>";
    }
    // </SnippetEvents>

    // <SnippetClickEvents>
    function closeButton_click() {
        window.close();
    }
    // </SnippetClickEvents>
    
    WinJS.Application.start();
})();