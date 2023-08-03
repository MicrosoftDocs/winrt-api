---
-api-id: M:Windows.Devices.Enumeration.Pnp.PnpObject.Update(Windows.Devices.Enumeration.Pnp.PnpObjectUpdate)
-api-type: winrt method
---

<!-- Method syntax
public void Update(Windows.Devices.Enumeration.Pnp.PnpObjectUpdate updateInfo)
-->

# Windows.Devices.Enumeration.Pnp.PnpObject.Update

## -description

> [!IMPORTANT]
> We no longer recommend that you use the types in the **Windows.Devices.Enumeration.Pnp** namespace. Instead, the types in the [Windows.Devices.Enumeration](/uwp/api/windows.devices.enumeration) namespace implement a modern, and better maintained, superset of the functionality of **Windows.Devices.Enumeration.Pnp**.
>
> The alternative to **PnpObjectType** is the [Windows.Devices.Enumeration.DeviceInformationKind](/uwp/api/windows.devices.enumeration.deviceinformationkind) enum, which you can pass as a parameter to **Windows.Devices.Enumeration** APIs. For example, instead of using **PnpObjectType** when you create a **PnpObjectWatcher**, use **DeviceInformationKind** when you create a [DeviceWatcher](/uwp/api/windows.devices.enumeration.devicewatcher).

Updates the properties of an existing [PnpObject](pnpobject.md) by applying the changes described in a [PnpObjectUpdate](pnpobjectupdate.md) object.

## -parameters
### -param updateInfo
Indicates the properties to update.

## -remarks

## -examples

## -see-also
[PnpObjectUpdate](pnpobjectupdate.md)