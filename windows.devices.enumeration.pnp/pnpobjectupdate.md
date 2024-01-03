---
-api-id: T:Windows.Devices.Enumeration.Pnp.PnpObjectUpdate
-api-type: winrt class
---

<!-- Class syntax.
public class PnpObjectUpdate : Windows.Devices.Enumeration.Pnp.IPnpObjectUpdate
-->

# Windows.Devices.Enumeration.Pnp.PnpObjectUpdate

## -description

> [!IMPORTANT]
> We no longer recommend that you use the types in the **Windows.Devices.Enumeration.Pnp** namespace. Instead, the types in the [Windows.Devices.Enumeration](/uwp/api/windows.devices.enumeration) namespace implement a modern, and better maintained, superset of the functionality of **Windows.Devices.Enumeration.Pnp**.
>
> The alternative to **PnpObjectType** is the [Windows.Devices.Enumeration.DeviceInformationKind](/uwp/api/windows.devices.enumeration.deviceinformationkind) enum, which you can pass as a parameter to **Windows.Devices.Enumeration** APIs. For example, instead of using **PnpObjectType** when you create a **PnpObjectWatcher**, use **DeviceInformationKind** when you create a [DeviceWatcher](/uwp/api/windows.devices.enumeration.devicewatcher).

Contains the updated properties of a [PnpObject](pnpobject.md).

## -remarks
Retrieve an instance of this class from the [Updated](pnpobjectwatcher_updated.md) event.

Instantiate an instance of this class to pass to the [Update](pnpobject_update_414576016.md) method.

## -examples

## -see-also