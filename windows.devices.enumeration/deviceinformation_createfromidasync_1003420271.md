---
-api-id: M:Windows.Devices.Enumeration.DeviceInformation.CreateFromIdAsync(System.String,Windows.Foundation.Collections.IIterable{System.String},Windows.Devices.Enumeration.DeviceInformationKind,Windows.Devices.Enumeration.IDeviceEnumerationSettings)
-api-type: winrt method
---

# Windows.Devices.Enumeration.DeviceInformation.CreateFromIdAsync(System.String,Windows.Foundation.Collections.IIterable{System.String},Windows.Devices.Enumeration.DeviceInformationKind,Windows.Devices.Enumeration.IDeviceEnumerationSettings)

<!--
public static Windows.Foundation.IAsyncOperation<Windows.Devices.Enumeration.DeviceInformation> CreateFromIdAsync (string deviceId, System.Collections.Generic.IEnumerable<string> additionalProperties, Windows.Devices.Enumeration.DeviceInformationKind kind, Windows.Devices.Enumeration.IDeviceEnumerationSettings settings);
-->


## -description

Asynchronously creates a [DeviceInformation](deviceinformation.md) object from a [DeviceInformation](deviceinformation.md) ID, a list of additional properties, a [DeviceInformationKind](deviceinformationkind.md), and a settings object.

## -parameters

### -param deviceId

A string containing the [DeviceInformation](deviceinformation.md) ID.

### -param additionalProperties

An iterable list of additional properties to include in the [Properties](deviceinformation_properties.md) property of the [DeviceInformation](deviceinformation.md) object in the enumeration results. For more info about what the properties represent, see [Device information properties](/windows/uwp/devices-sensors/device-information-properties).

### -param kind

The type of [DeviceInformation](deviceinformation.md) object that you want to create.

### -param settings

Enumeration settings come from a device API's **GetDeviceEnumerationSettings** method, and contain opaque data. An object implementing this must also implement the **IDeviceEnumerationSettings** interface.

## -returns

An asynchronous operation object which, when it completes, contains a newly created [DeviceInformation](deviceinformation.md) object.

## -remarks

## -see-also
