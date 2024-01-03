---
-api-id: M:Windows.Devices.Enumeration.Pnp.PnpObjectCollection.First
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IIterator<Windows.Devices.Enumeration.Pnp.PnpObject> First()
-->

# Windows.Devices.Enumeration.Pnp.PnpObjectCollection.First

## -description

> [!IMPORTANT]
> We no longer recommend that you use the types in the **Windows.Devices.Enumeration.Pnp** namespace. Instead, the types in the [Windows.Devices.Enumeration](/uwp/api/windows.devices.enumeration) namespace implement a modern, and better maintained, superset of the functionality of **Windows.Devices.Enumeration.Pnp**.
>
> The alternative to **PnpObjectType** is the [Windows.Devices.Enumeration.DeviceInformationKind](/uwp/api/windows.devices.enumeration.deviceinformationkind) enum, which you can pass as a parameter to **Windows.Devices.Enumeration** APIs. For example, instead of using **PnpObjectType** when you create a **PnpObjectWatcher**, use **DeviceInformationKind** when you create a [DeviceWatcher](/uwp/api/windows.devices.enumeration.devicewatcher).

Returns the iterator for iteration over the items in the collection.

## -returns
The iterator object. The iterator's current position is at the 0-index position, or at the end of the collection if the collection is empty.

## -remarks

## -examples

## -see-also
