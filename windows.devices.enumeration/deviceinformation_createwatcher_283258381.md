---
-api-id: M:Windows.Devices.Enumeration.DeviceInformation.CreateWatcher(System.String,Windows.Foundation.Collections.IIterable{System.String},Windows.Devices.Enumeration.DeviceInformationKind,Windows.Devices.Enumeration.IDeviceEnumerationSettings)
-api-type: winrt method
---

# Windows.Devices.Enumeration.DeviceInformation.CreateWatcher(System.String,Windows.Foundation.Collections.IIterable{System.String},Windows.Devices.Enumeration.DeviceInformationKind,Windows.Devices.Enumeration.IDeviceEnumerationSettings)

<!--
public static Windows.Devices.Enumeration.DeviceWatcher CreateWatcher (string aqsFilter, System.Collections.Generic.IEnumerable<string> additionalProperties, Windows.Devices.Enumeration.DeviceInformationKind kind, Windows.Devices.Enumeration.IDeviceEnumerationSettings settings);
-->


## -description

Creates a [DeviceWatcher](devicewatcher.md) for devices matching the specified Advanced Query Syntax (AQS) string, the specified collection of properties, the kind of device, and the settings.

## -parameters

### -param aqsFilter

An AQS string that filters the [DeviceInformation](deviceinformation.md) objects to enumerate. Typically this string is retrieved from the **GetDeviceSelector** method of a class that interacts with devices. For example, [GetDeviceSelector](../windows.devices.portable/storagedevice_getdeviceselector_838466080.md) retrieves the string for the [StorageDevice](../windows.devices.portable/storagedevice.md) class.

### -param additionalProperties

An iterable list of additional properties to include in the [Properties](deviceinformation_properties.md) property of the [DeviceInformation](deviceinformation.md) objects in the enumeration results. For more info on what the properties represent, see [Device information properties](/windows/uwp/devices-sensors/device-information-properties).

### -param kind

The specific types of devices the [DeviceWatcher](devicewatcher.md) is interested in.

### -param settings

Enumeration settings come from a device API's **GetDeviceEnumerationSettings** method, and contain opaque data. An object implementing this must also implement the **IDeviceEnumerationSettings** interface.

## -returns

The created [DeviceWatcher](devicewatcher.md).

## -remarks

## -see-also
