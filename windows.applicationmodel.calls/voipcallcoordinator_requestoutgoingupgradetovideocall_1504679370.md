---
-api-id: M:Windows.ApplicationModel.Calls.VoipCallCoordinator.RequestOutgoingUpgradeToVideoCall(System.Guid,System.String,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Calls.VoipPhoneCall RequestOutgoingUpgradeToVideoCall(System.Guid callUpgradeGuid, System.String context, System.String contactName, System.String serviceName)
-->

# Windows.ApplicationModel.Calls.VoipCallCoordinator.RequestOutgoingUpgradeToVideoCall

## -description
Makes a request of the system to create an outgoing video call that will replace an existing cellular call.

## -parameters
### -param callUpgradeGuid
The GUID of the call.

### -param context
A string that is passed to the associated foreground app as a deep link. This might be a contact name or other data that can be used to populate the app's UI more quickly. The maximum length is 128 characters. This parameter must be non-null and must refer to a task defined in the app's manifest file.

### -param contactName
The name or ID of the caller which is displayed in the phone's minimized call UI. The maximum length is 128 characters.

### -param serviceName
The name of the VoIP service which is displayed in the phone's minimized call UI. The maximum length is 128 characters.

## -returns
The object representing the new outgoing call.

## -remarks

## -examples

## -see-also


## -capabilities
phoneCallHistory, phoneCallHistorySystem
voipCall
