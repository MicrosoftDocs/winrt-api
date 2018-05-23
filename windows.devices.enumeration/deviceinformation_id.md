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

By default, calling [DeviceInformation.FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md) returns a collection of  [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) objects that describe device interfaces (rather than devices). Consequently, the value of **DeviceInformation.Id** for those objects is a device interface identifier (rather than a device identifier). There are overloads of **DeviceInformation.FindAllAsync** to which you can pass a [DeviceInformationKind](deviceinformationkind.md) to control whether the returned **DeviceInformation** objects represent devices, device interfaces, or other kinds of information.

## -examples

## -see-also
