---
-api-id: T:Windows.ApplicationModel.Calls.VoipPhoneCall
-api-type: winrt class
---

<!-- Class syntax.
public class VoipPhoneCall : Windows.ApplicationModel.Calls.IVoipPhoneCall
-->

# Windows.ApplicationModel.Calls.VoipPhoneCall

## -description
Represents a VoIP phone call.

## -remarks
Call the [VoipCallCoordinator.RequestNewAppInitiatedCall](voipcallcoordinator_requestnewappinitiatedcall_477072082.md) method to create a new **VoipPhoneCall** object. You can then use the **VoipPhoneCall** object to set up a new in-app call notification, and to handle events that the **VoipPhoneCall** raises.

If the user accepts the call, then your application should call [NotifyCallAccepted](voipphonecall_notifycallaccepted_862950983.md). If the call is rejected or unanswered, then call [NotifyCallEnded](voipphonecall_notifycallended_1962259325.md). Alternatively, the system itself can raise the [AnswerRequested](voipphonecall_answerrequested.md) or [RejectRequested](voipphonecall_rejectrequested.md) events, and your VoIP application can handle those events in order to determine whether the user has accepted or rejected the incoming call via the HID device.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | TryShowAppUI |
| 1803 | 17134 | NotifyCallAccepted |

## -examples

## -see-also

## -capabilities
phoneCallHistory, phoneCallHistorySystem, voipCall
