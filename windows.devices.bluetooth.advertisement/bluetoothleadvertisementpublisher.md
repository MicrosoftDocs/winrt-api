---
-api-id: T:Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementPublisher
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class BluetoothLEAdvertisementPublisher : Windows.Devices.Bluetooth.Advertisement.IBluetoothLEAdvertisementPublisher
-->

# Windows.Devices.Bluetooth.Advertisement.BluetoothLEAdvertisementPublisher

## -description
An object to send Bluetooth Low Energy (LE) advertisements.

## -remarks
The BluetoothLEAdvertisementPublisher class allows the configuration and advertising of a Bluetooth LE advertisement packet. The advertising request is serviced on a best effort basis and the advertising parameters are defined by an advertising policy.

The payload of the advertisement is configured when the BluetoothLEAdvertisementPublisher is constructed. The payload can be retrieved by the [Advertisement](bluetoothleadvertisementpublisher_advertisement.md) property of the BluetoothLEAdvertisementPublisher. The [BluetoothLEAdvertisement](bluetoothleadvertisement.md) class must be managed by the caller if used this way. For example, it is not recommended to directly reuse a [BluetoothLEAdvertisement](bluetoothleadvertisement.md) obtained from a [BluetoothLEAdvertisementReceivedEventArgs](bluetoothleadvertisementreceivedeventargs.md) because it contains duplication of actual payload in order to facilitate the access to common data sections. If a received [BluetoothLEAdvertisement](bluetoothleadvertisement.md) needs to be duplicated, only the [DataSections](bluetoothleadvertisement_datasections.md) property should be copied, as they represent the advertisement data sections in their raw form.

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
| 2004 | 19041 | UseExtendedAdvertisement |

## -examples

## -see-also
[BluetoothLEAdvertisement](bluetoothleadvertisement.md), [BluetoothLEAdvertisement.DataSections](bluetoothleadvertisement_datasections.md), [BluetoothLEAdvertisementReceivedEventArgs](bluetoothleadvertisementreceivedeventargs.md)
## -capabilities
bluetooth
