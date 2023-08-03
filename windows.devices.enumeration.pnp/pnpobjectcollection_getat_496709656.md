---
-api-id: M:Windows.Devices.Enumeration.Pnp.PnpObjectCollection.GetAt(System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Enumeration.Pnp.PnpObject GetAt(System.UInt32 index)
-->

# Windows.Devices.Enumeration.Pnp.PnpObjectCollection.GetAt

## -description

> [!IMPORTANT]
> We no longer recommend that you use the types in the **Windows.Devices.Enumeration.Pnp** namespace. Instead, the types in the [Windows.Devices.Enumeration](/uwp/api/windows.devices.enumeration) namespace implement a modern, and better maintained, superset of the functionality of **Windows.Devices.Enumeration.Pnp**.
>
> The alternative to **PnpObjectType** is the [Windows.Devices.Enumeration.DeviceInformationKind](/uwp/api/windows.devices.enumeration.deviceinformationkind) enum, which you can pass as a parameter to **Windows.Devices.Enumeration** APIs. For example, instead of using **PnpObjectType** when you create a **PnpObjectWatcher**, use **DeviceInformationKind** when you create a [DeviceWatcher](/uwp/api/windows.devices.enumeration.devicewatcher).

Returns the [PnpObject](pnpobject.md) located at the specified index.

## -parameters
### -param index
The integer index for the value to retrieve.

## -returns
The [PnpObject](pnpobject.md) at the specified index.

## -remarks

## -examples

## -see-also
