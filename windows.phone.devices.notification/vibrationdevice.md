---
-api-id: T:Windows.Phone.Devices.Notification.VibrationDevice
-api-type: winrt class
---

<!-- Class syntax.
public class VibrationDevice : Windows.Phone.Devices.Notification.IVibrationDevice
-->

# Windows.Phone.Devices.Notification.VibrationDevice

## -description
Vibrates the phone.

## -remarks
Windows Phone devices include a vibration controller. Your app can vibrate the phone for up to 5 seconds to notify the user of an important event.

Use the vibration feature in moderation. Do not rely on the vibration feature for critical notifications, because the user can disable vibration.

To test an app that uses the vibration controller effectively, you have to test it on a physical device. The emulator cannot simulate vibration and does not provide any audible or visual feedback that vibration is occurring.

An app that is running in the background cannot vibrate the phone. If your code tries to use vibration while the app is running in the background, nothing happens, but no exception is raised. If you want to vibrate the phone while your app is running in the background, you have to implement a toast notification.

## -examples
You vibrate the phone by calling the [Vibrate](vibrationdevice_vibrate_926341456.md) method of the [VibrationDevice](vibrationdevice.md) class.


1. Import the [Windows.Phone.Devices.Notification](windows_phone_devices_notification.md) namespace.

`using Windows.Phone.Devices.Notification;
`
1. Get a reference to the vibration controller by calling the static [GetDefault](vibrationdevice_getdefault_846721868.md) method of the [VibrationDevice](vibrationdevice.md) class.

`VibrationDevice testVibrationDevice = VibrationDevice.GetDefault();
`
1. Start the vibration by calling the [Vibrate](vibrationdevice_vibrate_926341456.md) method of the [VibrationDevice](vibrationdevice.md) class. Specify the duration as a **TimeSpan** value.

`testVibrationDevice.Vibrate(TimeSpan.FromSeconds(3));
`
1. If necessary, stop the vibration by calling the [Cancel](vibrationdevice_cancel_1985564044.md) method of the [VibrationDevice](vibrationdevice.md) class.

`testVibrationDevice.Cancel();
`


## -see-also
