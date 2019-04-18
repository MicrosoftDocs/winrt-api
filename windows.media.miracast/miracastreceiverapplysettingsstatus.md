---
-api-id: T:Windows.Media.Miracast.MiracastReceiverApplySettingsStatus
-api-type: winrt enum
ms.custom: 19H1
---

<!-- Enumeration syntax.
public enum MiracastReceiverApplySettingsStatus : int 
-->

# Windows.Media.Miracast.MiracastReceiverApplySettingsStatus

## -description

Specifies the status of a [DisconnectAllAndApplySettings](miracastreceiver_disconnectallandapplysettings_1413841516.md) or [DisconnectAllAndApplySettingsAsync](miracastreceiver_disconnectallandapplysettingsasync_404771925.md) operation.

## -enum-fields
### -field UnknownFailure:1

The operation failed for an unknown reason.

### -field Success:0

The operation succeeded.

### -field ModelNumberTooLong:6

The operation failed because the number of characters in the *ModelNumber* parameter exceeded the maximum allowed value.

### -field ModelNameTooLong:5

The operation failed because the number of characters in the *ModelName* parameter exceeded the maximum allowed value.

### -field MiracastNotSupported:2

The operation failed because Miracast is not supported on the current device.

### -field InvalidSettings:7

The operation failed because one or more parameters were set to an invalid value.

### -field FriendlyNameTooLong:4

The operation failed because the number of characters in the *FriendlyName* parameter exceeded the maximum allowed value.

### -field AccessDenied:3

The operation failed because the app is not allowed to change the settings.

## -remarks

Store apps must declare the **PrivateNetworkClientServer** capability in their app manifest in order to be allowed to change the Miracast settings. If the capability is missing, it results in an *AccessDenied* status value.
If Miracast has been enabled by the system, such as through the Settings app, other apps are not allowed to change the settings, and attempts to do so will result in the *AccessDenied* status value.

## -see-also

[DisconnectAllAndApplySettings](miracastreceiver_disconnectallandapplysettings_1413841516.md),
[DisconnectAllAndApplySettingsAsync](miracastreceiver_disconnectallandapplysettingsasync_404771925.md)

## -examples

