---
-api-id: E:Windows.Devices.Bluetooth.GenericAttributeProfile.GattCharacteristic.ValueChanged
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ValueChanged<Windows.Devices.Bluetooth.GenericAttributeProfile.GattCharacteristic,  Windows.Devices.Bluetooth.GenericAttributeProfile.GattValueChangedEventArgs>
-->

# Windows.Devices.Bluetooth.GenericAttributeProfile.GattCharacteristic.ValueChanged

## -description
An App can register an event handler in order to receive events when notification or indications are received from a device, after setting the Client Characteristic Configuration Descriptor.

## -remarks
The [GattValueChangedEventArgs](gattvaluechangedeventargs.md) object represents the arguments received by a [ValueChanged](gattcharacteristic_valuechanged.md) event handler used to process characteristic value change notification and indication events sent by a Bluetooth LE device.

## -examples

## -see-also
[GattValueChangedEventArgs](gattvaluechangedeventargs.md)
## -capabilities
bluetooth
