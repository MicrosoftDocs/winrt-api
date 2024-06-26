---
-api-id: M:Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementWatcher.Start
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void Start()
-->

# Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementWatcher.Start

## -description
Start the [BluetoothLEAdvertisementWatcher](bluetoothleadvertisementwatcher.md) to scan for Bluetooth LE advertisements.

## -remarks

When the system enters any of the supported sleep states (such as S3 or S4), the Bluetooth controller is reset. That reset cycle causes any existing Bluetooth advertisements to be removed from the queue. But if your app still has a watcher in the on state when the system wakes up, then scanning will resume automatically; and your app will receive new advertisements.

For Modern Standby, the system might continue scanning, but your app might not receive advertisements. That depends on various factors such as whether your app is running in an AppContainer, whether it’s a session 0 service, and other factors. We don’t recommend that you scan during a Modern Standby session; instead, your app will need to stop actively scanning, and then resume scanning after the system itself resumes. Applications that don't stop scanning while in Modern Standby might have their execution paused while in Modern Standby, leading to a queue of stale advertisements being returned to the application when the system resumes normal operation.

[GUID_MONITOR_POWER_ON]( /windows/win32/power/power-setting-guids) indicates that the primary system monitor has been powered on or off&mdash;so that *can* imply Modern Standby on some system configurations. But be aware that a system with its primary system monitor powered off might not always go into Modern Standby. For example, when the monitor is configured to power off when idle, but the system itself isn’t configured to go to sleep.

Applications running outside an AppContainer (such as session 0 services or Win32 applications) can register to get notifications for power events (see [Registering for power events](/windows/win32/power/registering-for-power-events)) to receive **WM_POWERBROADCAST** messages. The system sends a **PBT_APMSUSPEND** message shortly before it suspends. Once it resumes operation, it sends a **PBT_APMRESUMEAUTOMATIC** message. Also, it sends another **PBT_APMRESUMESUSPEND** message if the resume is triggered by user input.

This method will transition the [BluetoothLEAdvertisementWatcher](bluetoothleadvertisementwatcher.md) to the **Started** state immediately with a pending scan request or to the **Aborted** state if the request failed immediately due to error.

If this method is called in the **Stopping** state, the request will be pended and the state will remain in the **Stopping** state until the request completes, at which time a new request will be sent and the state will transition to the **Started** state.

The [BluetoothLEAdvertisementWatcher](bluetoothleadvertisementwatcher.md) will be automatically stopped when an app is suspended.

## -examples

## -see-also
[BluetoothLEAdvertisementWatcherStatus](bluetoothleadvertisementwatcherstatus.md)

## -capabilities
bluetooth
