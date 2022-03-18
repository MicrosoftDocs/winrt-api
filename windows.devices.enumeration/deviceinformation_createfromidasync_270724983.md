---
-api-id: M:Windows.Devices.Enumeration.DeviceInformation.CreateFromIdAsync(System.String,Windows.Foundation.Collections.IIterable{System.String},Windows.Devices.Enumeration.DeviceInformationKind)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Enumeration.DeviceInformation> CreateFromIdAsync(System.String deviceId, Windows.Foundation.Collections.IIterable<System.String> additionalProperties, Windows.Devices.Enumeration.DeviceInformationKind kind)
-->

# Windows.Devices.Enumeration.DeviceInformation.CreateFromIdAsync

## -description
Creates a [DeviceInformation](deviceinformation.md) object from a [DeviceInformation](deviceinformation.md) ID, a list of additional properties, and a [DeviceInformationKind](deviceinformationkind.md) parameter.

## -parameters
### -param deviceId
A string containing the [DeviceInformation](deviceinformation.md) ID.

### -param additionalProperties
An iterable list of additional properties to include in the [Properties](deviceinformation_properties.md) property of the [DeviceInformation](deviceinformation.md) objects in the enumeration results. For more info on what the properties represent, see [Device information properties](/windows/uwp/devices-sensors/device-information-properties).

### -param kind
The type of [DeviceInformation](deviceinformation.md) object you want to create.

## -returns
An object for starting and managing the asynchronous creation of the [DeviceInformation](deviceinformation.md) object.

## -remarks

## -examples

## -see-also
[CreateFromIdAsync(String)](deviceinformation_createfromidasync_728202765.md), [CreateFromIdAsync(String, IIterable(String))](deviceinformation_createfromidasync_907774063.md)