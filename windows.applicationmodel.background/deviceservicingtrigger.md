---
-api-id: T:Windows.ApplicationModel.Background.DeviceServicingTrigger
-api-type: winrt class
---

<!-- Class syntax.
public class DeviceServicingTrigger : Windows.ApplicationModel.Background.IBackgroundTrigger, Windows.ApplicationModel.Background.IDeviceServicingTrigger
-->

# Windows.ApplicationModel.Background.DeviceServicingTrigger

## -description
Represents an event that an application can trigger to initiate a long-running update (firmware or settings) of a device.

Windows 8.1 enables you to develop UWP app for your peripheral devices that communicate over USB, HID, and Bluetooth. For example, a user might need to sync content on a PC to or from the device, or perform a long-running update to the device itself like settings or firmware updates. Windows 8.1 provides two background tasks and corresponding APIs that allow your device to sync and update in the background: DeviceServicingTrigger and [DeviceUseTrigger](deviceusetrigger.md). This topic provides API reference information for DeviceServicingTrigger - for info on using this trigger in the context of a device app, see [Device sync and update for UWP device apps](/windows-hardware/drivers/devapps/device-sync-and-update-for-uwp-device-apps).

The DeviceServicingTrigger background task allows your UWP app that interacts with your peripheral device to perform long running device updates while your app is suspended, for example settings transfers or firmware updates. Updating your device in the background requires user approval each time the background task is used. Unlike the [DeviceUseTrigger](deviceusetrigger.md) background task, the DeviceServicingTrigger background task allows for device reboot and disconnect and allows a maximum of 30 minutes of background activity.


+ More detail on the policy requirements of the DeviceServicingTrigger background task can be found in the  section of this page.
+ For info about using the DeviceServicingTrigger, see [Device sync and update for UWP device apps](/windows-hardware/drivers/devapps/device-sync-and-update-for-uwp-device-apps).
+ For info about using the [DeviceUseTrigger](deviceusetrigger.md), see [Accessing sensors and devices from a background task](/previous-versions/windows/apps/dn630194(v=win.10)).
> [!IMPORTANT]
> This trigger cannot be used with single-process background tasks.

## -remarks
Certain policies are enforced by Windows to ensure user consent when updating their peripheral devices. Additional polices are enforced to preserve user battery life when syncing and updating peripheral devices. The [DeviceServicingTrigger](deviceservicingtrigger_deviceservicingtrigger_1221375020.md) background task is subject to the following policies:

+ The [DeviceServicingTrigger](deviceservicingtrigger_deviceservicingtrigger_1221375020.md) background task requires user consent every time it's triggered.
+ Your device must be connected or paired with the PC and available when requesting the [DeviceServicingTrigger](deviceservicingtrigger_deviceservicingtrigger_1221375020.md).
+ Your app is allowed a maximum of 30 minutes (wall clock) of background activity for device updates with [DeviceServicingTrigger](deviceservicingtrigger_deviceservicingtrigger_1221375020.md)
+ Your app is not allowed to request a [DeviceServicingTrigger](deviceservicingtrigger_deviceservicingtrigger_1221375020.md) background task while your app is not in the foreground.
+ Your app can only run one [DeviceServicingTrigger](deviceservicingtrigger_deviceservicingtrigger_1221375020.md) at a time. Attempting to create a second [DeviceServicingTrigger](deviceservicingtrigger_deviceservicingtrigger_1221375020.md) will raise an exception.
+ The PC's battery must have more than 33% capacity remaining, or the PC must be on A/C power.
+ [DeviceServicingTrigger](deviceservicingtrigger_deviceservicingtrigger_1221375020.md) background tasks may be canceled by Windows when these policy requirements are no longer met, including a maximum amount of wall clock background time.
> [!NOTE]
> UWP app that intend to use the [DeviceServicingTrigger](deviceservicingtrigger_deviceservicingtrigger_1221375020.md) background task must also be a privileged app for the device. App privilege is specified in the device metadata for a peripheral device by the device manufacturer. When a UWP app attempts to trigger the [DeviceServicingTrigger](deviceservicingtrigger_deviceservicingtrigger_1221375020.md) background task, Windows will validate that the calling app is the privileged app for the device it is attempting to update. If the app is not privileged for the device then Windows will not allow the background task to launch.

For detailed information about app privilege and the policy checks enforced by Windows for the [DeviceServicingTrigger](deviceservicingtrigger_deviceservicingtrigger_1221375020.md) background task see [Device sync and update for UWP device apps](/windows-hardware/drivers/devapps/device-sync-and-update-for-uwp-device-apps).

## -examples

## -see-also
[IBackgroundTrigger](ibackgroundtrigger.md)
