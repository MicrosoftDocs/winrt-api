---
-api-id: M:Windows.Devices.Enumeration.Pnp.PnpObjectCollection.IndexOf(Windows.Devices.Enumeration.Pnp.PnpObject,System.UInt32@)
-api-type: winrt method
---

<!-- Method syntax
public bool IndexOf(Windows.Devices.Enumeration.Pnp.PnpObject value, System.UInt32 index)
-->

# Windows.Devices.Enumeration.Pnp.PnpObjectCollection.IndexOf

## -description

> [!IMPORTANT]
> We no longer recommend that you use the types in the **Windows.Devices.Enumeration.Pnp** namespace. Instead, the types in the [Windows.Devices.Enumeration](/uwp/api/windows.devices.enumeration) namespace implement a modern, and better maintained, superset of the functionality of **Windows.Devices.Enumeration.Pnp**.
>
> The alternative to **PnpObjectType** is the [Windows.Devices.Enumeration.DeviceInformationKind](/uwp/api/windows.devices.enumeration.deviceinformationkind) enum, which you can pass as a parameter to **Windows.Devices.Enumeration** APIs. For example, instead of using **PnpObjectType** when you create a **PnpObjectWatcher**, use **DeviceInformationKind** when you create a [DeviceWatcher](/uwp/api/windows.devices.enumeration.devicewatcher).

Retrieves the index of the specified item.

## -parameters
### -param value
The value to find in the collection.

### -param index
The index of the item to find, if found.

## -returns
True if an item with the specified value was found; otherwise, False.

## -remarks

## -examples

## -see-also
