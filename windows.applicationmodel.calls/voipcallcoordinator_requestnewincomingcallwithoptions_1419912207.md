---
-api-id: M:Windows.ApplicationModel.Calls.VoipCallCoordinator.RequestNewIncomingCallWithOptions(Windows.ApplicationModel.Calls.IncomingVoipPhoneCallOptions)
-api-type: winrt method
---

# Windows.ApplicationModel.Calls.VoipCallCoordinator.RequestNewIncomingCallWithOptions(Windows.ApplicationModel.Calls.IncomingVoipPhoneCallOptions)

<!--
public Windows.ApplicationModel.Calls.VoipPhoneCall RequestNewIncomingCallWithOptions (Windows.ApplicationModel.Calls.IncomingVoipPhoneCallOptions callOptions);
-->


## -description

Requests a new call object from the system by using an [IncomingVoipPhoneCallOptions](./incomingvoipphonecalloptions.md) object. Call this method from your VoIP app to tell the system that there's a new incoming call, and that you want to host an incoming call notification for that new call.

## -parameters

### -param callOptions

An object representing the options to use when creating the new call.

## -returns

An object representing the new initiated call in the incoming state.

## -remarks

Use this method to create a new [VoipPhoneCall](voipphonecall.md) object. You can use a **VoipPhoneCall** object to send in-app call notifications, and to handle events that the **VoipPhoneCall** raises. See [VoipPhoneCall](voipphonecall.md) for more info about how to work with those notifications and events.

## -see-also
[VoipPhoneCall](voipphonecall.md)

## -examples

## -capabilities
phoneCallHistory, phoneCallHistorySystem, voipCall
