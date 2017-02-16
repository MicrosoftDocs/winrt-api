---
-api-id: M:Windows.Devices.Enumeration.Pnp.PnpObject.CreateFromIdAsync(Windows.Devices.Enumeration.Pnp.PnpObjectType,System.String,Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Enumeration.Pnp.PnpObject> CreateFromIdAsync(Windows.Devices.Enumeration.Pnp.PnpObjectType type, System.String id, Windows.Foundation.Collections.IIterable<System.String> requestedProperties)
-->

# Windows.Devices.Enumeration.Pnp.PnpObject.CreateFromIdAsync

## -description
Creates a [PnpObject](pnpobject.md) object asynchronously from a previously saved [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) ID.

## -parameters
### -param type
The type of the [PnpObject](pnpobject.md).

### -param id
The string value identifying the [PnpObject](pnpobject.md).

### -param requestedProperties
An iterable list of additional properties to include in the [Properties](../windows.devices.enumeration/deviceinformation_properties.md) property of the [PnpObject](pnpobject.md) object to create. For more info on what the properties represent, see [Device information properties](http://msdn.microsoft.com/library/4a4c2802-e674-4c04-8a6d-d7c1bbf1bd20).

## -returns
The [PnpObject](pnpobject.md) created from the previously saved [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) ID.

## -remarks

## -examples

## -see-also
