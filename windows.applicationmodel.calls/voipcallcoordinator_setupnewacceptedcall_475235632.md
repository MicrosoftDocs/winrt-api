---
-api-id: M:Windows.ApplicationModel.Calls.VoipCallCoordinator.SetupNewAcceptedCall(System.String,System.String,System.String,System.String,Windows.ApplicationModel.Calls.VoipPhoneCallMedia)
-api-type: winrt method
---

<!-- Method syntax.
public VoipPhoneCall VoipCallCoordinator.SetupNewAcceptedCall(String context, String contactName, String contactNumber, String serviceName, VoipPhoneCallMedia media)
-->

# Windows.ApplicationModel.Calls.VoipCallCoordinator.SetupNewAcceptedCall

## -description
Sets up a newly accepted call.

## -parameters
### -param context
Information that is passed to the VOIP app's foreground UI process. This might be the contact name, or other data that helps the UI display more quickly.

### -param contactName
The name or ID of the caller.

### -param contactNumber
The phone number (if applicable) of the caller.

### -param serviceName
The name of the service or application.

### -param media
The type of call (audio/video or audio only).

## -returns
Returns the call as a VoipPhoneCall object.

## -remarks
All string parameters have a maximum allowed length of 128 characters (including the terminator).

## -see-also

## -examples

