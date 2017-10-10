---
-api-id: M:Windows.Devices.Bluetooth.GenericAttributeProfile.GattLocalCharacteristic.NotifyValueAsync(Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<IVectorView<GattClientNotificationResult>> GattLocalCharacteristic.NotifyValueAsync(IBuffer value)
-->

# Windows.Devices.Bluetooth.GenericAttributeProfile.GattLocalCharacteristic.NotifyValueAsync

## -description
Send and notifies all subscribed clients a GattSubscribedClient of a value.

## -parameters

### -param value
The buffer that contains the value to send to the GattSubscribedClient.

## -returns
An asynchronous operation that completes with a vector list of all the GattClientNotificationResult for each subscribed client.
## -remarks

## -see-also

## -examples


## -capabilities
bluetooth
