---
-api-id: M:Windows.ApplicationModel.Calls.VoipPhoneCall.NotifyCallAccepted(Windows.ApplicationModel.Calls.VoipPhoneCallMedia)
-api-type: winrt method
---

<!-- Method syntax.
public void VoipPhoneCall.NotifyCallAccepted(VoipPhoneCallMedia media)
-->

# Windows.ApplicationModel.Calls.VoipPhoneCall.NotifyCallAccepted

## -description
Notifies the system that the VoIP call has been accepted.

## -parameters
### -param media
The media types used by the call.

## -remarks
This event notifies the system that the incoming VoIP call was answered from within your VoIP application's incoming call notification. You should raise this event in conjunction with the [VoipCallCoordinator.RequestNewAppInitiatedCall](voipcallcoordinator_requestnewappinitiatedcall_477072082.md) method.

## -see-also

## -examples

## -capabilities
backgroundVoIP, voipCall