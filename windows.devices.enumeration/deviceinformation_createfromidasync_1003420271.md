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

The argument passed in *settings* is an object that implements **IDeviceEnumerationSettings**; but otherwise, the object is of an opaque marker class (that is, it has no public properties or methods). The purpose of *settings* is to retrieve extended parameters from a device-specific API for device-specific scenarios that aren't possible in the standard WDE API. You can think of the parameters like extra knobs that the API surface doesn't allow.

The *settings* object would come from a device API's **GetDeviceEnumerationSettings** method, and would contain opaque data. But currently there are no APIs that produce the object.

## -returns

An asynchronous operation object which, when it completes, contains a newly created [DeviceInformation](deviceinformation.md) object.

## -remarks

## -see-also
