---
-api-id: T:Windows.Media.Devices.CallControl
-api-type: winrt class
---

<!-- Class syntax.
public class CallControl : Windows.Media.Devices.ICallControl
-->

# Windows.Media.Devices.CallControl

## -description
Represents the properties, commands and events for handling calls on a telephony related device.

## -remarks
This class provides access to events that can be monitored and used for modifying the behavior of your telephony-aware app. The following JavaScript code snippet shows how to add event listeners to the **CallControl** class, and then to respond to one of the events, **AnswerRequested**.





```javascript
// Define the user-defined valriables
var callControls = null;
var audioTag;

// Add code to initialize your user-defined variables as needed
<code goes here>

// Initialize the telephony device
    function initDevice() {
        if (!callControls) {
            try {
                callControls = Windows.Media.Devices.CallControl.getDefault();

                if (callControls) {
                    // Add the event listener to listen for the various button presses
                    callControls.addEventListener("answerrequested", answerButton, false);
                    callControls.addEventListener("hanguprequested", hangupButton, false);
                    callControls.addEventListener("audiotransferrequested", audiotransferButton, false);
                    callControls.addEventListener("redialrequested", redialButton, false);
                    callControls.addEventListener("dialrequested", dialButton, false);

                    sdkSample.displayStatus("Call Controls Initialized");
                    id("scenario1Ring").disabled = false;
                } else {
                    sdkSample.displayError("No Bluetooth device detected.");
                }
            }
            catch (e) {                
                sdkSample.displayError("No Bluetooth device detected.");
            }
        }

// Event handler code to respond to the AnswerRequested event
    function answerButton() {
        // When the answer button is pressed indicate to the device that the call was answered
        // and start a song on the headset (this is done by streaming music to the bluetooth
        // device in this sample)
        sdkSample.displayStatus("Answer requested: " + callToken);
        callControls.indicateActiveCall(callToken);
        audiotag = document.getElementById("audiotag");
        audiotag.play();
    }

```

For the complete listing of this sample see [How to manage calls on the default Bluetooth communications device](https://go.microsoft.com/fwlink/p/?linkid=241435).

## -examples

## -see-also
[How to manage calls on the default Bluetooth communications device](https://go.microsoft.com/fwlink/p/?linkid=241435)
