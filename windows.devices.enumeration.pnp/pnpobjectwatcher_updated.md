---
-api-id: E:Windows.Devices.Enumeration.Pnp.PnpObjectWatcher.Updated
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler Updated<Windows.Devices.Enumeration.Pnp.PnpObjectWatcher,  Windows.Devices.Enumeration.Pnp.PnpObjectUpdate>
-->

# Windows.Devices.Enumeration.Pnp.PnpObjectWatcher.Updated

## -description

> [!IMPORTANT]
> We no longer recommend that you use the types in the **Windows.Devices.Enumeration.Pnp** namespace. Instead, the types in the [Windows.Devices.Enumeration](/uwp/api/windows.devices.enumeration) namespace implement a modern, and better maintained, superset of the functionality of **Windows.Devices.Enumeration.Pnp**.
>
> The alternative to **PnpObjectType** is the [Windows.Devices.Enumeration.DeviceInformationKind](/uwp/api/windows.devices.enumeration.deviceinformationkind) enum, which you can pass as a parameter to **Windows.Devices.Enumeration** APIs. For example, instead of using **PnpObjectType** when you create a **PnpObjectWatcher**, use **DeviceInformationKind** when you create a [DeviceWatcher](/uwp/api/windows.devices.enumeration.devicewatcher).

Occurs when the properties of a [PnpObject](pnpobject.md) in the collection enumerated by the [PnpObjectWatcher](pnpobjectwatcher.md) are updated.

## -remarks

## -examples

## -see-also
