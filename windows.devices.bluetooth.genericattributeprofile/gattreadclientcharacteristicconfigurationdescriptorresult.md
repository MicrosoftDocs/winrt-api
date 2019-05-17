---
-api-id: T:Windows.Devices.Bluetooth.GenericAttributeProfile.GattReadClientCharacteristicConfigurationDescriptorResult
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class GattReadClientCharacteristicConfigurationDescriptorResult : Windows.Devices.Bluetooth.GenericAttributeProfile.IGattReadClientCharacteristicConfigurationDescriptorResult, Windows.Devices.Bluetooth.GenericAttributeProfile.IGattReadClientCharacteristicConfigurationDescriptorResult2
-->

# Windows.Devices.Bluetooth.GenericAttributeProfile.GattReadClientCharacteristicConfigurationDescriptorResult

## -description
Represents the result of reading a GATT Client CharacteristicConfigurationClientDescriptor value.

## -remarks
The [ReadClientCharacteristicConfigurationDescriptorAsync](gattcharacteristic_readclientcharacteristicconfigurationdescriptorasync_310627851.md) method is used to retrieve a GattReadClientCharacteristicConfigurationDescriptorResult object.

The [Status](gattreadclientcharacteristicconfigurationdescriptorresult_status.md) property on the GattReadClientCharacteristicConfigurationDescriptorResult returned indicates if the result of the operation was successful.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | ProtocolError |

## -examples

## -see-also
[ClientCharacteristicConfigurationDescriptor](gattreadclientcharacteristicconfigurationdescriptorresult_clientcharacteristicconfigurationdescriptor.md), [GattCharacteristic](gattcharacteristic.md), [ReadClientCharacteristicConfigurationDescriptorAsync](gattcharacteristic_readclientcharacteristicconfigurationdescriptorasync_310627851.md), [Status](gattreadclientcharacteristicconfigurationdescriptorresult_status.md)
## -capabilities
bluetooth
