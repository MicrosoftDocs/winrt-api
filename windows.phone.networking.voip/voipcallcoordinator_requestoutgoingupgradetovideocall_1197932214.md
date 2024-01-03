---
-api-id: M:Windows.Phone.Networking.Voip.VoipCallCoordinator.RequestOutgoingUpgradeToVideoCall(System.Guid,System.String,System.String,System.String,Windows.Phone.Networking.Voip.VoipPhoneCall@)
-api-type: winrt method
---

<!-- Method syntax
public void RequestOutgoingUpgradeToVideoCall(System.Guid callUpgradeGuid, System.String context, System.String contactName, System.String serviceName, Windows.Phone.Networking.Voip.VoipPhoneCall call)
-->

# Windows.Phone.Networking.Voip.VoipCallCoordinator.RequestOutgoingUpgradeToVideoCall

## -description

> [!IMPORTANT]
> The types in the **Windows.Phone.Networking.Voip** namespace are deprecated, and may not be available in future versions of Windows. Instead, use the equivalent types in the [Windows.ApplicationModel.Calls](/uwp/api/windows.applicationmodel.calls) namespace.

Notifies the system of a new outgoing video call that will replace an existing cellular call.

## -parameters
### -param callUpgradeGuid
The [GUID](/windows/win32/api/guiddef/ns-guiddef-guid) of the call.

### -param context
A string that is passed to the associated foreground app as a deep link. This might be a contact name or other data that can be used to populate the app's UI more quickly. The maximum length is 128 characters. This parameter must be non-null and must refer to a task defined in the app's manifest file.

### -param contactName
The name or ID of the caller which is displayed in the phone's minimized call UI. The maximum length is 128 characters.

### -param serviceName
The name of the VoIP service which is displayed in the phone's minimized call UI. The maximum length is 128 characters.

### -param call
The object representing the new outgoing call.

## -remarks

## -examples

## -see-also
