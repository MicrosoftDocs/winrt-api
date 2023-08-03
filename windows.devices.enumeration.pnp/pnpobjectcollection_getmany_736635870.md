---
-api-id: M:Windows.Devices.Enumeration.Pnp.PnpObjectCollection.GetMany(System.UInt32,Windows.Devices.Enumeration.Pnp.PnpObject[])
-api-type: winrt method
---

<!-- Method syntax
public uint GetMany(System.UInt32 startIndex, Windows.Devices.Enumeration.Pnp.PnpObject[] items)
-->

# Windows.Devices.Enumeration.Pnp.PnpObjectCollection.GetMany

## -description

> [!IMPORTANT]
> We no longer recommend that you use the types in the **Windows.Devices.Enumeration.Pnp** namespace. Instead, the types in the [Windows.Devices.Enumeration](/uwp/api/windows.devices.enumeration) namespace implement a modern, and better maintained, superset of the functionality of **Windows.Devices.Enumeration.Pnp**.
>
> The alternative to **PnpObjectType** is the [Windows.Devices.Enumeration.DeviceInformationKind](/uwp/api/windows.devices.enumeration.deviceinformationkind) enum, which you can pass as a parameter to **Windows.Devices.Enumeration** APIs. For example, instead of using **PnpObjectType** when you create a **PnpObjectWatcher**, use **DeviceInformationKind** when you create a [DeviceWatcher](/uwp/api/windows.devices.enumeration.devicewatcher).

Retrieves multiple elements in a single pass through the iterator.

## -parameters
### -param startIndex
The index from which to start retrieval.

### -param items
Provides the destination for the result. Size the initial array size as a "capacity" in order to specify how many results should be retrieved.

## -returns
The number of items retrieved.

## -remarks

## -examples

## -see-also
