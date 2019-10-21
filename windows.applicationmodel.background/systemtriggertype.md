---
-api-id: T:Windows.ApplicationModel.Background.SystemTriggerType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Background.SystemTriggerType : int
-->

# SystemTriggerType

## -description
Specifies the system events that can be used to trigger a background task.

## -enum-fields
### -field Invalid:0
Not a valid trigger type.

### -field SmsReceived:1
The background task is triggered when a new SMS message is received by an installed mobile broadband device.

### -field UserPresent:2
The background task is triggered when the user becomes present.

> **Windows 8, Windows Server 2012, Windows 8.1, Windows Server 2012 R2, Windows Phone 8.1**
> An app must be placed on the lock screen before it can successfully register background tasks using this trigger type.



> **Windows 10, Windows Server 2016, Windows 10 Mobile**
> You do not need to place an app on the lock screen before the app can successfully register background tasks using this trigger type.

### -field UserAway:3
The background task is triggered when the user becomes absent.

> **Windows 8, Windows Server 2012, Windows 8.1, Windows Server 2012 R2, Windows Phone 8.1**
> An app must be placed on the lock screen before it can successfully register background tasks using this trigger type.



> **Windows 10, Windows Server 2016, Windows 10 Mobile**
> You do not need to place an app on the lock screen before the app can successfully register background tasks using this trigger type.

### -field NetworkStateChange:4
The background task is triggered when a network change occurs, such as a change in cost or connectivity.

### -field ControlChannelReset:5
The background task is triggered when a control channel is reset.

> [!NOTE]
> This trigger type does not support a [OneShot](systemtrigger_oneshot.md) mode. So the *OneShot* parameter must be false when using the [SystemTrigger](systemtrigger_systemtrigger_1157162657.md) constructor.



> **Windows 8, Windows Server 2012, Windows 8.1, Windows Server 2012 R2, Windows Phone 8.1**
> An app must be placed on the lock screen before it can successfully register background tasks using this trigger type.



> **Windows 10, Windows Server 2016, Windows 10 Mobile**
> You do not need to place an app on the lock screen before the app can successfully register background tasks using this trigger type.

### -field InternetAvailable:6
The background task is triggered when the Internet becomes available.

### -field SessionConnected:7
The background task is triggered when the session is connected.

> **Windows 8, Windows Server 2012, Windows 8.1, Windows Server 2012 R2, Windows Phone 8.1**
> An app must be placed on the lock screen before it can successfully register background tasks using this trigger type.



> **Windows 10, Windows Server 2016, Windows 10 Mobile**
> You do not need to place an app on the lock screen before the app can successfully register background tasks using this trigger type.

### -field ServicingComplete:8
The background task is triggered when the system has finished updating an app.

### -field LockScreenApplicationAdded:9
The background task is triggered when a tile is added to the lock screen.

### -field LockScreenApplicationRemoved:10
The background task is triggered when a tile is removed from the lock screen.

### -field TimeZoneChange:11
The background task is triggered when the time zone changes on the device (for example, when the system adjusts the clock for daylight saving time).

> [!NOTE]
> This trigger only fires if the new time zone actually changes the system time.

### -field OnlineIdConnectedStateChange:12
The background task is triggered when the Microsoft account connected to the account changes.

### -field BackgroundWorkCostChange:13
The background task is triggered when the cost of background work changes.

> **Windows 8, Windows Server 2012, Windows 8.1, Windows Server 2012 R2, Windows Phone 8.1**
> An app must be placed on the lock screen before it can successfully register background tasks using this trigger type.



> **Windows 10, Windows Server 2016, Windows 10 Mobile**
> You do not need to place an app on the lock screen before the app can successfully register background tasks using this trigger type.

### -field PowerStateChange:14
The background task is triggered when the status of the battery, [BatteryStatus](../windows.system.power/powermanager_batterystatus.md), changes.

> [!NOTE]
> This value was introduced in Windows 10.

### -field DefaultSignInAccountChange:15
The background task is triggered when the default sign-in account changes.

> [!NOTE]
> This value was introduced in Windows 10, version 1607.


## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | DefaultSignInAccountChange |

## -examples

## -see-also
[SystemTrigger.TriggerType](systemtrigger_triggertype.md)
