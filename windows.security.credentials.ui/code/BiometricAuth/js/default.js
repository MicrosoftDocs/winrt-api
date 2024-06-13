// For an introduction to the Blank template, see the following documentation:
// http://go.microsoft.com/fwlink/?LinkId=232509
(function () {
    "use strict";

    var app = WinJS.Application;
    var activation = Windows.ApplicationModel.Activation;

    var outputDiv;

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

            document.getElementById("AuthenticateButton").addEventListener("click", AuthenticateButton_Click, false);

            outputDiv = document.getElementById("OutputTextBlock");
            checkFingerprintAvailability();
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


    
    function AuthenticateButton_Click() {
        requestConsent("Let's make sure it's really you.");
    }

//<Snippet1_JS>
function checkFingerprintAvailability() {
    Windows.Security.Credentials.UI.UserConsentVerifier.checkAvailabilityAsync().then(
    function (ucvAvailability) {

        switch (ucvAvailability)
        {
            case Windows.Security.Credentials.UI.UserConsentVerifierAvailability.available:
                outputDiv.innerHTML = "<br/>Authentication device is available.";
                break;
            case Windows.Security.Credentials.UI.UserConsentVerifierAvailability.deviceBusy:
                outputDiv.innerHTML = "<br/>Authentication device is busy.";
                break;
            case Windows.Security.Credentials.UI.UserConsentVerifierAvailability.deviceNotPresent:
                outputDiv.innerHTML = "<br/>No authentication device found.";
                break;
            case Windows.Security.Credentials.UI.UserConsentVerifierAvailability.disabledByPolicy:
                outputDiv.innerHTML = "<br/>Authentication device verification is disabled by policy.";
                break;
            case Windows.Security.Credentials.UI.UserConsentVerifierAvailability.notConfiguredForUser:
                outputDiv.innerHTML = "<br/>Please go to Account Settings to set up a PIN or other advanced authentication.";
                break;
            default:
                outputDiv.innerHTML = "<br/>Authentication device is currently unavailable.";
                break;
        }
    });
}
}
// </Snippet1_JS>

// <Snippet2_JS>
function requestConsent(userMessage) {
    // Request the logged on user's consent via authentication device.
    Windows.Security.Credentials.UI.UserConsentVerifier.requestVerificationAsync(userMessage)
    .then(
        function (consentResult) {
            switch (consentResult) {
                case Windows.Security.Credentials.UI.UserConsentVerificationResult.verified:
                    outputDiv.innerHTML = "<br/>User verified.";
                    break;
                case Windows.Security.Credentials.UI.UserConsentVerificationResult.deviceBusy:
                    outputDiv.innerHTML = "<br/>Authentication device is busy.";
                    break;
                case Windows.Security.Credentials.UI.UserConsentVerificationResult.deviceNotPresent:
                    outputDiv.innerHTML = "<br/>No authentication device found.";
                    break;
                case Windows.Security.Credentials.UI.UserConsentVerificationResult.disabledByPolicy:
                    outputDiv.innerHTML = "<br/>Authentication device verification is disabled by policy.";
                    break;
                case Windows.Security.Credentials.UI.UserConsentVerificationResult.notConfiguredForUser:
                    outputDiv.innerHTML = "<br/>Please go to Account Settings to set up a PIN or other advanced authentication.";
                    break;
                case Windows.Security.Credentials.UI.UserConsentVerificationResult.retriesExhausted:
                    outputDiv.innerHTML = "<br/>There have been too many failed attempts. Device authentication canceled.";
                    break;
                case Windows.Security.Credentials.UI.UserConsentVerificationResult.canceled:
                    outputDiv.innerHTML = "<br/>Device authentication canceled.";
                    break;
                default:
                    outputDiv.innerHTML = "<br/>Authentication device is currently unavailable.";
                    break;
            }
        });
}
// </Snippet2_JS>

    app.start();
})();
