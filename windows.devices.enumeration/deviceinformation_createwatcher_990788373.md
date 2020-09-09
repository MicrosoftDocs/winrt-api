---
-api-id: M:Windows.Devices.Enumeration.DeviceInformation.CreateWatcher(System.String,Windows.Foundation.Collections.IIterable{System.String},Windows.Devices.Enumeration.DeviceInformationKind)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Enumeration.DeviceWatcher CreateWatcher(System.String aqsFilter, Windows.Foundation.Collections.IIterable<System.String> additionalProperties, Windows.Devices.Enumeration.DeviceInformationKind kind)
-->

# Windows.Devices.Enumeration.DeviceInformation.CreateWatcher

## -description
Creates a [DeviceWatcher](devicewatcher.md) for devices matching the specified Advanced Query Syntax (AQS) string, the specified collection of properties, and the kind of devices.

## -parameters
### -param aqsFilter
An AQS string that filters the [DeviceInformation](deviceinformation.md) objects to enumerate. Typically this string is retrieved from the **GetDeviceSelector** method of a class that interacts with devices. For example, [GetDeviceSelector](../windows.devices.portable/storagedevice_getdeviceselector_838466080.md) retrieves the string for the [StorageDevice](../windows.devices.portable/storagedevice.md) class.

### -param additionalProperties
An iterable list of additional properties to include in the [Properties](deviceinformation_properties.md) property of the [DeviceInformation](deviceinformation.md) objects in the enumeration results. For more info on what the properties represent, see [Device information properties](/windows/uwp/devices-sensors/device-information-properties).

### -param kind
The specific types of devices the [DeviceWatcher](devicewatcher.md) is interested in.

## -returns
The created [DeviceWatcher](devicewatcher.md).

## -remarks

## -examples

## -see-also
[CreateWatcher](deviceinformation_createwatcher_1506431823.md), [CreateWatcher(DeviceClass)](deviceinformation_createwatcher_674507571.md), [CreateWatcher(String)](deviceinformation_createwatcher_4958831.md), [CreateWatcher(String, IIterable(String))](deviceinformation_createwatcher_490167309.md)