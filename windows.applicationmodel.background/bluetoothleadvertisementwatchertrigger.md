---
-api-id: T:Windows.ApplicationModel.Background.BluetoothLEAdvertisementWatcherTrigger
-api-type: winrt class
---

<!-- Class syntax.
public class BluetoothLEAdvertisementWatcherTrigger : Windows.ApplicationModel.Background.IBackgroundTrigger, Windows.ApplicationModel.Background.IBluetoothLEAdvertisementWatcherTrigger
-->

# Windows.ApplicationModel.Background.BluetoothLEAdvertisementWatcherTrigger

## -description
Represents a trigger that is registered to scan for Bluetooth LE advertisement in the background.

## -remarks
A background task is launched when an advertisement is received.

This trigger works similarly to the [BluetoothAdvertisementWatcher](../windows.devices.bluetooth.advertisement/bluetoothleadvertisementwatcher.md) class, with the exception that it has more restrictions as it allows the app to receive advertisements in the background. Notably, exactly a single filter pattern is accepted in the background (not more, not less).

Once registered, the background watcher is serviced in a best effort manner. A background task will be launched to notify the app when an advertisement matching the filter configured through trigger is received. The app is also notified of failures or interruption of the background watcher through the trigger details provided in the background task context. To stop receiving the advertisements, the background task associated with this trigger must be unregistered.

The following advertisement types are not allowed to be filtered for in the background due to their generic nature

+ Flags (0x01)
+ Class of Device (0x0D)
+ Security Manager Out-of-Band Flags (0x11)
+ Appearance (0x19)
+ LE Role (0x1C)

A background filter for a raw section of type manufacturer specific data (0xFF) that only matches for the second byte of the section with 0x00 will be rejected, as it corresponds to the most significant byte of the company identifier field. All SIG-assigned company identifiers currently have this byte set to 0x00 and performing a partial match with only a single byte can potentially result in an excess of received advertisements when in presence of multiple advertisers. This could significantly impact the battery life of the system.

Use of a BluetoothLEAdvertisementWatcherTrigger is limited by the hardware offload resources available. New Windows devices with [HCI Extensions](/windows-hardware/drivers/ddi/content/index) support in the local Bluetooth radio provide lower power advertisement scanning, improving battery life for long term scenarios such as beacons. The amount of hardware resources available is dependent on the radio and current system-wide usage, and attempts to register for this trigger will return [BluetoothError.ResourceInUse](../windows.devices.bluetooth/bluetootherror.md) when no more resources are available. Apps should use these resources sparingly to provide a focused, power efficient scenario in watching for the unique advertisement data for only the specific remote advertisers which are needed.

While many new Windows devices have HCI Extensions support, some may not, especially in cases of upgrades on older devices from older Windows versions. In these cases, Windows will emulate the hardware filtering in software, providing a maximum of 20 trigger conditions per device, across all apps on the system. When using this software emulation, attempts to register for trigger resources once the maximum has been reached will cause an exception to be thrown, with error **ERROR_NO_SYSTEM_RESOURCES (0x800705AA)**.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 2004 | 19041 | AllowExtendedAdvertisements |

## -examples

## -see-also
[IBackgroundTrigger](ibackgroundtrigger.md)
