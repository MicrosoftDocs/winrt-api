---
-api-id: P:Windows.Devices.Bluetooth.GenericAttributeProfile.GattSession.MaxPduSize
-api-type: winrt property
---

<!-- Property syntax.
public ushort MaxPduSize { get; }
-->

# Windows.Devices.Bluetooth.GenericAttributeProfile.GattSession.MaxPduSize

## -description
Gets the maximum protocol data unit (PDU) size. This metric is also known as the *maximum transmission unit (MTU)* size.

Also see the [GattSession.MaxPduSizeChanged](/uwp/api/windows.devices.bluetooth.genericattributeprofile.gattsession.maxpdusizechanged) event.

## -property-value
The maximum protocol data unit (PDU) size.

## -remarks

The Windows operating system automatically fragments down larger protocol data unit (PDU) sizes sent to a remote device (wherever supported by the Bluetooth GATT/ATT spec). So under normal circumstances, there's no need for you to know the maximum transmission unit (MTU) size at the application layer if your application's goal is just to send data efficiently.

You can send large amounts of data, and it will be fragmented automatically by the OS using the MTU. Your application is not limited by the MTU size as to the data transfer of each packet.

If you want your application to customize the data sent based on the MTU (for example, encoding/codec), or to communicate the MTU size information out-of-band, then you can access the the MTU value using **MaxPduSize** and [GattSession.MaxPduSizeChanged](/uwp/api/windows.devices.bluetooth.genericattributeprofile.gattsession.maxpdusizechanged).

## -see-also

## -examples

## -capabilities
bluetooth