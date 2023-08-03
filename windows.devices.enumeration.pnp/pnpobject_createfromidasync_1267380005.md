---
-api-id: M:Windows.Devices.Enumeration.Pnp.PnpObject.CreateFromIdAsync(Windows.Devices.Enumeration.Pnp.PnpObjectType,System.String,Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Enumeration.Pnp.PnpObject> CreateFromIdAsync(Windows.Devices.Enumeration.Pnp.PnpObjectType type, System.String id, Windows.Foundation.Collections.IIterable<System.String> requestedProperties)
-->

# Windows.Devices.Enumeration.Pnp.PnpObject.CreateFromIdAsync

## -description

> [!IMPORTANT]
> We no longer recommend that you use the types in the **Windows.Devices.Enumeration.Pnp** namespace. Instead, the types in the [Windows.Devices.Enumeration](/uwp/api/windows.devices.enumeration) namespace implement a modern, and better maintained, superset of the functionality of **Windows.Devices.Enumeration.Pnp**.
>
> The alternative to **PnpObjectType** is the [Windows.Devices.Enumeration.DeviceInformationKind](/uwp/api/windows.devices.enumeration.deviceinformationkind) enum, which you can pass as a parameter to **Windows.Devices.Enumeration** APIs. For example, instead of using **PnpObjectType** when you create a **PnpObjectWatcher**, use **DeviceInformationKind** when you create a [DeviceWatcher](/uwp/api/windows.devices.enumeration.devicewatcher).

Creates a [PnpObject](pnpobject.md) object asynchronously from a previously saved [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) ID.

## -parameters
### -param type
The type of the [PnpObject](pnpobject.md).

### -param id
The string value identifying the [PnpObject](pnpobject.md).

### -param requestedProperties
An iterable list of additional properties to include in the [Properties](../windows.devices.enumeration/deviceinformation_properties.md) property of the [PnpObject](pnpobject.md) object to create. For more info on what the properties represent, see [Device information properties](/windows/uwp/devices-sensors/device-information-properties).

## -returns
The [PnpObject](pnpobject.md) created from the previously saved [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) ID.

## -remarks

## -examples

## -see-also
