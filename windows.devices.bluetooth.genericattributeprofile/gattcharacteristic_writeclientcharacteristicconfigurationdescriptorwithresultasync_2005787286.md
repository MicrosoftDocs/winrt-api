---
-api-id: M:Windows.Devices.Bluetooth.GenericAttributeProfile.GattCharacteristic.WriteClientCharacteristicConfigurationDescriptorWithResultAsync(Windows.Devices.Bluetooth.GenericAttributeProfile.GattClientCharacteristicConfigurationDescriptorValue)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<GattWriteResult> GattCharacteristic.WriteClientCharacteristicConfigurationDescriptorWithResultAsync(GattClientCharacteristicConfigurationDescriptorValue clientCharacteristicConfigurationDescriptorValue)
-->

# Windows.Devices.Bluetooth.GenericAttributeProfile.GattCharacteristic.WriteClientCharacteristicConfigurationDescriptorWithResultAsync

## -description
Writes the ClientCharacteristicConfigurationDescriptor to the Bluetooth LE device, and if the value to be written represents an indication or a notification and a ValueChanged event handler is registered, enables receiving ValueChanged events from the device.

## -parameters

### -param clientCharacteristicConfigurationDescriptorValue
Specifies a new value for the ClientCharacteristicConfigurationDescriptor of this Characteristic object.

## -returns
Returns an asynchronous operation that completes with a GattWriteResult object.

## -remarks

## -see-also

## -examples

