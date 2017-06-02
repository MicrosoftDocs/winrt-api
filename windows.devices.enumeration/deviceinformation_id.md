---
-api-id: P:Windows.Devices.Enumeration.DeviceInformation.Id
-api-type: winrt property
---

<!-- Property syntax
public string Id { get; }
-->

# Windows.Devices.Enumeration.DeviceInformation.Id

## -description
A string representing the identity of the device.

## -property-value
A string representing the identity of the device.

## -remarks
This ID can be used to activate device functionality using the [CreateFromIdAsync](deviceinformation_createfromidasync.md) methods on classes that implement device functionality.

The [DeviceInformation](deviceinformation.md) object that the Id property identifies is actually a device interface . For simplicity in this documentation, the [DeviceInformation](deviceinformation.md) object is called a device, and the identifier in its [Id](deviceinformation_id.md) property is called a [DeviceInformation](deviceinformation.md) ID.

## -examples

## -see-also
