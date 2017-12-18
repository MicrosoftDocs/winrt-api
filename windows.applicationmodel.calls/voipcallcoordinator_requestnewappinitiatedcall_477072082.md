---
-api-id: M:Windows.ApplicationModel.Calls.VoipCallCoordinator.RequestNewAppInitiatedCall(System.String,System.String,System.String,System.String,Windows.ApplicationModel.Calls.VoipPhoneCallMedia)
-api-type: winrt method
---

<!-- Method syntax.
public VoipPhoneCall VoipCallCoordinator.RequestNewAppInitiatedCall(String context, String contactName, String contactNumber, String serviceName, VoipPhoneCallMedia media)
-->

# Windows.ApplicationModel.Calls.VoipCallCoordinator.RequestNewAppInitiatedCall

## -description
Makes a request to the system for a new call object.

## -parameters
### -param context
A string that is passed to the associated foreground app as a deep link. The maximum length is 128 characters. This parameter must be non-null.

### -param contactName
The contact name of the caller to be displayed on the incoming call UI. The maximum length is 128 characters.

### -param contactNumber
The phone number of the caller to be displayed on the incoming call UI. The maximum length is 128 characters.

### -param serviceName
The name of the VoIP service or application. The maximum length is 128 characters.

### -param media
The media types of the new incoming call.

## -returns
The object representing the new initiated call.

## -remarks
Use this method to create new **VoipPhoneCall** objects, which can be used to setup a new in-app call notifcation and attach event handlers.

Your application should call **VoipPhoneCall.NotifyCallAccepted** if the user accepts the call. If the call is rejected or unanswered, use **VoipPhoneCall.NotifyCallEnded**. Alternatively, the system can raise the **AnswerRequested** or **RejectRequested** events on the VoipPhoneCall object to tell the VoIP App if the user accepts or rejects the incoming call via HID device.

## -see-also

## -examples

