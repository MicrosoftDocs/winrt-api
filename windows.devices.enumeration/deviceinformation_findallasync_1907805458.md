---
-api-id: M:Windows.Devices.Enumeration.DeviceInformation.FindAllAsync(System.String,Windows.Foundation.Collections.IIterable{System.String},Windows.Devices.Enumeration.DeviceInformationKind)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Enumeration.DeviceInformationCollection> FindAllAsync(System.String aqsFilter, Windows.Foundation.Collections.IIterable<System.String> additionalProperties, Windows.Devices.Enumeration.DeviceInformationKind kind)
-->

# Windows.Devices.Enumeration.DeviceInformation.FindAllAsync

## -description
Enumerates [DeviceInformation](deviceinformation.md) objects matching the specified Advanced Query Syntax (AQS) device interface selector string, the device kind, and including the specified collection of properties.

## -parameters
### -param aqsFilter
An AQS device interface selector string that filters the [DeviceInformation](deviceinformation.md) objects to enumerate. Typically this string is retrieved from the **GetDeviceSelector** method of a class that interacts with devices. For example, [GetDeviceSelector](../windows.devices.portable/storagedevice_getdeviceselector_838466080.md) retrieves the string for the [StorageDevice](../windows.devices.portable/storagedevice.md) class.

### -param additionalProperties
An iterable list of additional properties to include in the [Properties](deviceinformation_properties.md) property of the [DeviceInformation](deviceinformation.md) objects in the enumeration results. For more info on what the properties represent, see [Device information properties](/windows/uwp/devices-sensors/device-information-properties).

### -param kind
The specific type of device to find.

## -returns
The object for managing the asynchronous operation.

## -remarks

## -examples

## -see-also
[FindAllAsync](deviceinformation_findallasync_326280522.md), [FindAllAsync(DeviceClass)](deviceinformation_findallasync_1653398836.md), [FindAllAsync(String)](deviceinformation_findallasync_1257462890.md), [FindAllAsync(String, IIterable(String))](deviceinformation_findallasync_1469032970.md)