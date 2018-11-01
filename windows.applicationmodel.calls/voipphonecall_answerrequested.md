---
-api-id: E:Windows.ApplicationModel.Calls.VoipPhoneCall.AnswerRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler AnswerRequested<Windows.ApplicationModel.Calls.VoipPhoneCall,  Windows.ApplicationModel.Calls.CallAnswerEventArgs>
-->

# Windows.ApplicationModel.Calls.VoipPhoneCall.AnswerRequested

## -description
Raised when the user answers an incoming call.

## -remarks
The system raises the **AnswerRequested** event to signal to your VoIP application that the call has been accepted by the system. After the event is raised, your VoIP application must call [NotifyCallActive](voipphonecall_notifycallactive_97340177.md) within 5 seconds. See [VoipPhoneCall](voipphonecall.md) for more details.

## -examples

## -see-also

## -capabilities
phoneCallHistory, phoneCallHistorySystem, voipCall
