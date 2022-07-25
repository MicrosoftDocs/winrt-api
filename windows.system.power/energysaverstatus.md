---
-api-id: T:Windows.System.Power.EnergySaverStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.System.Power.EnergySaverStatus : int
-->

# EnergySaverStatus

## -description
Specifies the status of battery saver.

## -enum-fields
### -field Disabled:0
Battery saver is off permanently or the device is plugged in.

### -field Off:1
Battery saver is off now, but ready to turn on automatically.

### -field On:2
Battery saver is on. Save energy where possible.


## -remarks
A user can turn on battery saver at any time to save energy (as long as the device is running on battery power). Battery saver extends battery life by limiting background activity on the device. In addition to the efforts of battery saver, your app can do its own part to save energy. Before initiating resource intensive tasks, check [EnergySaverStatus](powermanager_energysaverstatus.md) to make sure battery saver isn’t **on**. If your app’s resource intensive tasks are long-running, listen for the [EnergySaverStatusChanged](powermanager_energysaverstatuschanged.md) event so that those tasks can be stopped when battery saver is turned on.

A user can also set battery saver to turn on automatically when the battery reaches a specified charge threshold, such as 20% remaining. When it's in this state (before it turns on automatically), [EnergySaverStatus](powermanager_energysaverstatus.md) is **Off**. If the user disables this automatic setting, [EnergySaverStatus](powermanager_energysaverstatus.md) is **Disabled**.

Even if the automatic setting is enabled, when the device is plugged in, battery saver is turned off and [EnergySaverStatus](powermanager_energysaverstatus.md) is **Disabled**. It is not **Off** because as long as the device is plugged in, battery saver cannot be turned on.

When battery saver is on, the receipt of push notifications is disabled to save energy. But there are a couple exceptions to this. **Battery saver settings** (from the Settings app) provides settings that allow your app to receive push notifications even when battery saver is on. If your app depends heavily on push notifications, we recommend notifying users that they may not receive notifications while battery saver is on and to make it easy for them to adjust **battery saver settings**. For more info and examples, see [Windows Push Notification Services (WNS) overview](/windows/apps/design/shell/tiles-and-notifications/windows-push-notification-services--wns--overview).

## -examples

## -see-also