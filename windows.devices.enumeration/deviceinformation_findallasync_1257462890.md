---
-api-id: M:Windows.Devices.Enumeration.DeviceInformation.FindAllAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Enumeration.DeviceInformationCollection> FindAllAsync(System.String aqsFilter)
-->

# Windows.Devices.Enumeration.DeviceInformation.FindAllAsync

## -description
Enumerates [DeviceInformation](deviceinformation.md) objects matching the specified Advanced Query Syntax (AQS) device interface selector string.

## -parameters
### -param aqsFilter
An AQS device interface selector string that filters the [DeviceInformation](deviceinformation.md) objects to enumerate. Typically this string is retrieved from the **GetDeviceSelector** method of a class that interacts with devices. For example, [GetDeviceSelector](../windows.devices.portable/storagedevice_getdeviceselector.md) retrieves the string for the [StorageDevice](../windows.devices.portable/storagedevice.md) class.

## -returns
The object for managing the asynchronous operation.

## -remarks
> [!IMPORTANT]
> This method is not available using JavaScript. If you try to use it, your code will instead call [FindAllAsync(DeviceClass)](deviceinformation_findallasync_1653398836.md) with an invalid class and return a collection with all devices. Instead, you should use [FindAllAsync(String, IIterable(String)](deviceinformation_findallasync_1469032970.md) with **null** as the second parameter if no other properties are needed.

## -examples

## -see-also
[FindAllAsync](deviceinformation_findallasync_326280522.md), [FindAllAsync(DeviceClass)](deviceinformation_findallasync_1653398836.md), [FindAllAsync(String, IIterable_1)](deviceinformation_findallasync_1469032970.md)