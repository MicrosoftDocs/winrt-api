---
-api-id: M:Windows.ApplicationModel.Calls.VoipCallCoordinator.RequestNewOutgoingCallWithOptions(Windows.ApplicationModel.Calls.OutgoingVoipPhoneCallOptions)
-api-type: winrt method
---

# Windows.ApplicationModel.Calls.VoipCallCoordinator.RequestNewOutgoingCallWithOptions(Windows.ApplicationModel.Calls.OutgoingVoipPhoneCallOptions)

<!--
public Windows.ApplicationModel.Calls.VoipPhoneCall RequestNewOutgoingCallWithOptions (Windows.ApplicationModel.Calls.OutgoingVoipPhoneCallOptions callOptions);
-->


## -description

Requests a new call object from the system by using an [OutgoingVoipCallOptions](./outgoingvoipphonecalloptions.md) object. Call this method from your VoIP app to tell the system that there's a new outgoing call.

## -parameters

### -param callOptions

An object representing the options to use when creating the new call.

## -returns

An object representing the new initiated call in the outgoing state.

## -remarks

Use this method to create a new [VoipPhoneCall](voipphonecall.md) object. You can use a **VoipPhoneCall** object to send in-app call notifications, and to handle events that the **VoipPhoneCall** raises. See [VoipPhoneCall](voipphonecall.md) for more info about how to work with those notifications and events.

## -see-also
[VoipPhoneCall](voipphonecall.md)

## -examples

## -capabilities
phoneCallHistory, phoneCallHistorySystem, voipCall
