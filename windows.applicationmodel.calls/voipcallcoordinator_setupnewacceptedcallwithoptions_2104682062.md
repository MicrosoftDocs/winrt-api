---
-api-id: M:Windows.ApplicationModel.Calls.VoipCallCoordinator.SetupNewAcceptedCallWithOptions(Windows.ApplicationModel.Calls.AcceptedVoipPhoneCallOptions)
-api-type: winrt method
---

# Windows.ApplicationModel.Calls.VoipCallCoordinator.SetupNewAcceptedCallWithOptions(Windows.ApplicationModel.Calls.AcceptedVoipPhoneCallOptions)

<!--
public Windows.ApplicationModel.Calls.VoipPhoneCall SetupNewAcceptedCallWithOptions (Windows.ApplicationModel.Calls.AcceptedVoipPhoneCallOptions callOptions);
-->


## -description

Sets up a newly accepted call by using an [AcceptedVoipPhoneCallOptions](./acceptedvoipphonecalloptions.md) object.

## -parameters

### -param callOptions

An object representing the options to use when creating the new accepted call.

## -returns

An object representing the new initiated call in the active state.

## -remarks

Use this method instead of **RequestNewIncomingCall** in auto-accept scenarios, where an incoming call is automatically accepted and connected with video. Possible applications include a home surveillance camera, or helping elderly or disabled users accept calls.

## -see-also

## -examples

## -capabilities
backgroundVoIP, phoneCallHistory, phoneCallHistorySystem, voipCall
