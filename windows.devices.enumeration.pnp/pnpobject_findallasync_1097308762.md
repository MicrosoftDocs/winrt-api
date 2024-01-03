---
-api-id: M:Windows.Devices.Enumeration.Pnp.PnpObject.FindAllAsync(Windows.Devices.Enumeration.Pnp.PnpObjectType,Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Enumeration.Pnp.PnpObjectCollection> FindAllAsync(Windows.Devices.Enumeration.Pnp.PnpObjectType type, Windows.Foundation.Collections.IIterable<System.String> requestedProperties)
-->

# Windows.Devices.Enumeration.Pnp.PnpObject.FindAllAsync

## -description

> [!IMPORTANT]
> We no longer recommend that you use the types in the **Windows.Devices.Enumeration.Pnp** namespace. Instead, the types in the [Windows.Devices.Enumeration](/uwp/api/windows.devices.enumeration) namespace implement a modern, and better maintained, superset of the functionality of **Windows.Devices.Enumeration.Pnp**.
>
> The alternative to **PnpObjectType** is the [Windows.Devices.Enumeration.DeviceInformationKind](/uwp/api/windows.devices.enumeration.deviceinformationkind) enum, which you can pass as a parameter to **Windows.Devices.Enumeration** APIs. For example, instead of using **PnpObjectType** when you create a **PnpObjectWatcher**, use **DeviceInformationKind** when you create a [DeviceWatcher](/uwp/api/windows.devices.enumeration.devicewatcher).

Returns all of the PnP objects of a specified type that match the specified criteria.

## -parameters
### -param type
The type of the [PnpObject](pnpobject.md).

### -param requestedProperties
An iterable list of additional properties to include in the [Properties](pnpobject_properties.md) property of the [PnpObject](pnpobject.md) objects included in enumeration results. For more info on what the properties represent, see [Device information properties](/windows/uwp/devices-sensors/device-information-properties).

## -returns
An object that represents the asynchronous operation.

## -remarks

## -examples

## -see-also
[FindAllAsync(PnpObjectType, IIterable_1, String)](pnpobject_findallasync_660635354.md)