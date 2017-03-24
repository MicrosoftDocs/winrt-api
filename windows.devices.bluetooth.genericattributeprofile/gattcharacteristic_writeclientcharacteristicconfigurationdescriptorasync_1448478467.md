---
-api-id: M:Windows.Devices.Bluetooth.GenericAttributeProfile.GattCharacteristic.WriteClientCharacteristicConfigurationDescriptorAsync(Windows.Devices.Bluetooth.GenericAttributeProfile.GattClientCharacteristicConfigurationDescriptorValue)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Bluetooth.GenericAttributeProfile.GattCommunicationStatus> WriteClientCharacteristicConfigurationDescriptorAsync(Windows.Devices.Bluetooth.GenericAttributeProfile.GattClientCharacteristicConfigurationDescriptorValue clientCharacteristicConfigurationDescriptorValue)
-->

# Windows.Devices.Bluetooth.GenericAttributeProfile.GattCharacteristic.WriteClientCharacteristicConfigurationDescriptorAsync

## -description
Writes the ClientCharacteristicConfigurationDescriptor to the Bluetooth LE device, and if the value to be written represents an indication or a notification and a ValueChanged event handler is registered, enables receiving ValueChanged events from the device.

## -parameters
### -param clientCharacteristicConfigurationDescriptorValue
Specifies a new value for the ClientCharacteristicConfigurationDescriptor of this Characteristic object.

## -returns
The object that manages the asynchronous operation, which, upon completion, returns the status with which the operation completed.

## -remarks

## -examples

## -see-also
