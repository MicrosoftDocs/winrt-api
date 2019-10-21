---
-api-id: T:Windows.Networking.Sockets.ControlChannelTriggerResetReason
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Networking.Sockets.ControlChannelTriggerResetReason : int
-->

# ControlChannelTriggerResetReason

## -description
The reason why a [ControlChannelTrigger](controlchanneltrigger.md) was reset. 

> [!NOTE]
> This enumeration is not supported on Windows Phone.

## -enum-fields
### -field FastUserSwitched:0
The [ControlChannelTrigger](controlchanneltrigger.md) was reset as a result of fast user switching.

### -field LowPowerExit:1
The [ControlChannelTrigger](controlchanneltrigger.md) was reset as a result of a low power exit (Connected Standby exit).

### -field QuietHoursExit:2
The [ControlChannelTrigger](controlchanneltrigger.md) was reset as a result of quiet hours being set on the device and quiet hours having ended.

This value is supported on Windows 8.1, Windows Server 2012 R2, and later.

### -field ApplicationRestart:3
he [ControlChannelTrigger](controlchanneltrigger.md) was reset as a result of an app restart.

This value is supported on Windows 8.1, Windows Server 2012 R2, and later.


## -remarks
This ControlChannelTriggerResetReason enumeration is used to indicate the reason why a [ControlChannelTrigger](controlchanneltrigger.md) was reset and needs to be reestablished. The reset reason provides details to the app about the reason for the reset which could be a result of fast user switching or a low power exit (the computer entering Connected standby mode). This allows the app to recreate the connection to the remote destination by re-establishing the [ControlChannelTrigger](controlchanneltrigger.md) and the underlying transport connection.

## -examples

## -see-also
[ControlChannelTrigger](controlchanneltrigger.md), [ControlChannelTriggerStatus](controlchanneltriggerstatus.md), [IControlChannelTriggerResetEventDetails](icontrolchanneltriggerreseteventdetails.md)
