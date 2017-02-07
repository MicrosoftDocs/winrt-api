// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

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

    // <SnippetLaunchAppWriteTag1>
    var proximityDevice;

    function publishLaunchApp() {
        proximityDevice = Windows.Networking.Proximity.ProximityDevice.GetDefault();

	if (proximityDevice) {
            // The format of the app launch string is: "<args>\tWindows\t<AppName>".
            // The string is tab or null delimited.

            // The <args> string must have at least one character.
            var launchArgs = "user=default";

            // The format of the AppName is: PackageFamilyName!PRAID.
            var praid = "MyAppId"; // The Application Id value from your package.appxmanifest.

            var appName = Windows.ApplicationModel.Package.current.id.familyName + "!" + praid;

            var launchAppMessage = launchArgs + "\tWindows\t" + appName;

            var dataWriter = new Windows.Storage.Streams.DataWriter();
            dataWriter.unicodeEncoding = Windows.Storage.Streams.UnicodeEncoding.utf16LE;
            dataWriter.writeString(launchAppMessage);
            var launchAppPubId =
                 proximityDevice.publishBinaryMessage(
                     "LaunchApp:WriteTag", 
                     dataWriter.detachBuffer(), 
                     proximityWriteTagLaunchAppMessageTransmitCallback);
         }
    }

    function proximityWriteTagLaunchAppMessageTransmitCallback() {
        // The LaunchApp message has been successfully written to a tag.
    }
    // </SnippetLaunchAppWriteTag1>

    function exclude() {
        // <SnippetLaunchAppWriteTag2>
        var proximityDevice;

    function publishLaunchApp() {
        proximityDevice = Windows.Networking.Proximity.ProximityDevice.GetDefault();

	if (proximityDevice) {
            // The format of the app launch string is: "<args>\tWindows\t<AppName>".
            // The string is tab or null delimited.

            // The <args> string must have at least one character.
            var launchArgs = "user=default";

            // The format of the AppName is: PackageFamilyName!PRAID.
            var praid = "MyAppId"; // The Application Id value from your package.appxmanifest.

            var appName = Windows.ApplicationModel.Package.current.id.familyName + "!" + praid;

            var launchAppMessage = launchArgs + "\tWindows\t" + appName;

            var dataWriter = new Windows.Storage.Streams.DataWriter();
            dataWriter.unicodeEncoding = Windows.Storage.Streams.UnicodeEncoding.utf16LE;
            dataWriter.writeString(launchAppMessage);
            var launchAppPubId =
                 proximityDevice.publishBinaryMessage(
                     "LaunchApp:WriteTag", 
                     dataWriter.detachBuffer());
        }
    }
       // </SnippetLaunchAppWriteTag2>
    }

    app.start();
})();
