---
-api-id: P:Windows.Devices.Bluetooth.GenericAttributeProfile.GattSession.MaintainConnection
-api-type: winrt property
---

<!-- Property syntax.
public bool MaintainConnection { get;  set; }
-->

# Windows.Devices.Bluetooth.GenericAttributeProfile.GattSession.MaintainConnection

## -description
Gets or sets a Boolean value that indicates whether the connection should be maintained.

## -property-value
`true` if the connection should be maintained, otherwise `false`. `false` by default.

## -remarks
If **GattSession.MaintainConnection** is set to `true`, then the system waits indefinitely for a connection, and it will connect when the device is available. There's nothing for your application to wait on, since **GattSession.MaintainConnection** is a property.

## -see-also

## -examples

## -capabilities
bluetooth
