---
-api-id: T:Windows.ApplicationModel.Background.BluetoothLEAdvertisementPublisherTrigger
-api-type: winrt class
---

<!-- Class syntax.
public class BluetoothLEAdvertisementPublisherTrigger : Windows.ApplicationModel.Background.IBackgroundTrigger, Windows.ApplicationModel.Background.IBluetoothLEAdvertisementPublisherTrigger
-->

# Windows.ApplicationModel.Background.BluetoothLEAdvertisementPublisherTrigger

## -description
Represents a trigger that is registered to advertise a Bluetooth LE advertisement in the background.

## -remarks
A background task is launched when the status of the background publisher changes.

This trigger works similarly to the BluetoothAdvertisementPublisher class with the exception that it has more restrictions as it allows the app to maintain advertising in the background. Once registered, the background publisher is serviced in a best effort manner. A background task will be launched to notify the App on the status of the publisher. Right after registration, the status is expected to be either Started or Waiting (if the trigger cannot be serviced at the moment). The app is also notified of failures or interruption of the background publisher through the trigger details provided in the background task context. To stop advertising, the background task associated with this trigger must be unregistered.

The local advertisement resource is limited at the protocol layer. Usage of this resource is best suited for controlled scenarios such as enterprise use cases. Other apps may compete for this limited resource and regular broadcast of advertisements for any specific use case cannot be guaranteed.

The following advertisement types are allowed:

+ Manufacturer Specific Information (0xFF)
+ Any non-standard type not reserved by the system, as shown in the list below. For more information on non-standard types, see the [Assigned numbers and GAP](https://www.bluetooth.com/specifications/assigned-numbers/generic-access-profile/) Bluetooth specification.

The following advertisement types are system-reserved and are not allowed:

+ Flags (0x01)
+ Incomplete List of 16-bit Service UUIDs (0x02)
+ Complete List of 16-bit Service UUIDs (0x03)
+ Incomplete List of 32-bit Service UUIDs (0x04)
+ Complete List of 32-bit Service UUIDs (0x05)
+ Incomplete List of 128-bit Service UUIDs (0x06)
+ Complete List of 128-bit Service UUIDs (0x07)
+ Shortened Local Name (0x08)
+ Complete Local Name (0x09)
+ Tx Power Level (0x0A)
+ Class of Device (0x0D)
+ Simple Pairing Hash C192 (0x0E)
+ Simple Pairing Randomizer R192 (0x0F)
+ Security Manager TK Values (0x10)
+ Security Manager Out-of-Band Flags (0x11)
+ Peripheral Connection Interval Range (0x12)
+ List of 16-bit Service Solicitation UUIDs (0x14)
+ List of 32-bit Service Solicitation UUIDs (0x1F)
+ List of 128-bit Service Solicitation UUIDs (0x15)
+ Service Data 16-bit UUID (0x16)
+ Service Data 32-bit UUID (0x20)
+ Service Data 128-bit UUID (0x21)
+ Public Target Address (0x17)
+ Random Target Address (0x18)
+ Appearance (0x19)
+ Advertising Interval (0x1A)
+ LE Bluetooth Device Address (0x1B)
+ LE Role (0x1C)
+ Simple Pairing Hash C256 (0x1D)
+ Simple Pairing Randomizer R256 (0x1E)
+ 3D Information Data (0x3D)

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 2004 | 19041 | IncludeTransmitPowerLevel |
| 2004 | 19041 | IsAnonymous |
| 2004 | 19041 | PreferredTransmitPowerLevelInDBm |
| 2004 | 19041 | UseExtendedFormat |

## -examples

## -see-also
[IBackgroundTrigger](ibackgroundtrigger.md)
