// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";
    WinJS.strictProcessing();

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;

    app.onactivated = function (args) {
        if (args.detail.kind === activation.ActivationKind.launch) {
            if (args.detail.previousExecutionState !== activation.ApplicationExecutionState.terminated) {
                // TODO: This application has been newly launched. Initialize
                // your application here.
            } else {
                // TODO: This application has been reactivated from suspension.
                // Restore application state here.
            }
            args.setPromise(WinJS.UI.processAll());

            initializeProximity();
            queryDeviceProperties();
        }
    };

    app.oncheckpoint = function (args) {
        // TODO: This application is about to be suspended. Save any state
        // that needs to persist across suspensions here. You might use the
        // WinJS.Application.sessionState object, which is automatically
        // saved and restored across suspension. If you need to complete an
        // asynchronous operation before your application is suspended, call
        // args.setPromise().
    };

    // <SnippetGetDeviceSelector>
    var proximityDevice;

    function initializeProximity() {
        var selectorString = Windows.Networking.Proximity.ProximityDevice.getDeviceSelector();
                
        var propertiesToRetrieve = new Array();
        propertiesToRetrieve.push("{FB3842CD-9E2A-4F83-8FCC-4B0761139AE9} 2");

        Windows.Devices.Enumeration.DeviceInformation.findAllAsync(selectorString, propertiesToRetrieve).done(
            function (deviceInfoCollection) {
                if (deviceInfoCollection.size == 0) {
                    statusDiv.innerHTML = "No proximity devices found.";
                } else {
                    statusDiv.innerHTML = "Proximity Device id = " + deviceInfoCollection[0].id;
                    proximityDevice =
                        Windows.Networking.Proximity.ProximityDevice.fromId(deviceInfoCollection[0].id);
                }
        });
    }
    //</SnippetGetDeviceSelector>


    // <SnippetDeviceId>
    function queryDeviceProperties() {
        // Include the proximity properties key
        var propertiesToRetrieve = new Array();
        propertiesToRetrieve.push("{FB3842CD-9E2A-4F83-8FCC-4B0761139AE9} 2");

        var defaultProximityDevice =
            Windows.Networking.Proximity.ProximityDevice.getDefault();

        if (defaultProximityDevice) {
            Windows.Devices.Enumeration.DeviceInformation.createFromIdAsync(
                defaultProximityDevice.deviceId, propertiesToRetrieve).done(
                function (devInfo) {
                    if (devInfo.properties.hasKey("{FB3842CD-9E2A-4F83-8FCC-4B0761139AE9} 2")) {
                        var proximityCapabilities = new Array();
                        proximityCapabilities = devInfo.properties["{FB3842CD-9E2A-4F83-8FCC-4B0761139AE9} 2"];
                        for (var i = 0; i < proximityCapabilities.length; i++) {
                            if (proximityCapabilities[i] == "StandardNfc") {
                                // This proximity device supports NFC
                            }
                        };
                    }
                });
        }
    }
    // </SnippetDeviceId>

    app.start();
})();
