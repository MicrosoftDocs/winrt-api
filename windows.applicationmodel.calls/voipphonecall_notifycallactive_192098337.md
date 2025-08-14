---
-api-id: M:Windows.ApplicationModel.Calls.VoipPhoneCall.NotifyCallActive(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

# Windows.ApplicationModel.Calls.VoipPhoneCall.NotifyCallActive(Windows.Foundation.Collections.IIterable{System.String})

<!--
public void NotifyCallActive (System.Collections.Generic.IEnumerable<string> associatedDeviceIds);
-->


## -description

Notifies the system that the VoIP call is active; includes associated call control devices.

## -parameters

### -param associatedDeviceIds

A list of device interface ids of call control devices to associate with the call. May not be null (otherwise returns **E_INVALIDARG**). Replaces any existing list of associated devices.

## -remarks

The system raises the [AnswerRequested](voipphonecall_answerrequested.md) event to signal to your VoIP application that the call has been accepted by the system. After the event is raised, your VoIP application must call **NotifyCallActive** within 5 seconds. See [VoipPhoneCall](voipphonecall.md) for more info.

When calling this method, your app might wish to specify either a single device (such as the one that accepted the call, or the device that's the active audio endpoint) or a set of devices (such as the device that accepted the call plus a dedicated Bluetooth remote control for calls). Your app may also pass an empty device list. When calling this overload, the [VoipPhoneCall.IsUsingAssociatedDevicesList](./voipphonecall_isusingassociateddeviceslist.md) property of the call will be set to `true` (if not already), and only the associated devices will be able to interact with the call going forward.

## -see-also

## -examples

## -capabilities
phoneCallHistory, phoneCallHistorySystem, voipCall, voipCall
