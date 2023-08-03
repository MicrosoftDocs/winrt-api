---
-api-id: M:Windows.Devices.Enumeration.Pnp.PnpObject.CreateWatcher(Windows.Devices.Enumeration.Pnp.PnpObjectType,Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Enumeration.Pnp.PnpObjectWatcher CreateWatcher(Windows.Devices.Enumeration.Pnp.PnpObjectType type, Windows.Foundation.Collections.IIterable<System.String> requestedProperties)
-->

# Windows.Devices.Enumeration.Pnp.PnpObject.CreateWatcher

## -description

> [!IMPORTANT]
> We no longer recommend that you use the types in the **Windows.Devices.Enumeration.Pnp** namespace. Instead, the types in the [Windows.Devices.Enumeration](/uwp/api/windows.devices.enumeration) namespace implement a modern, and better maintained, superset of the functionality of **Windows.Devices.Enumeration.Pnp**.
>
> The alternative to **PnpObjectType** is the [Windows.Devices.Enumeration.DeviceInformationKind](/uwp/api/windows.devices.enumeration.deviceinformationkind) enum, which you can pass as a parameter to **Windows.Devices.Enumeration** APIs. For example, instead of using **PnpObjectType** when you create a **PnpObjectWatcher**, use **DeviceInformationKind** when you create a [DeviceWatcher](/uwp/api/windows.devices.enumeration.devicewatcher).

Returns a [PnpObjectWatcher](pnpobjectwatcher.md) object that is used to enumerate the PnP objects in the collection using events.

## -parameters
### -param type
The type of the [PnpObject](pnpobject.md).

### -param requestedProperties
An iterable list of additional properties to include in the [Properties](pnpobject_properties.md) property of the [PnpObject](pnpobject.md) objects included in enumeration results. For more info on what the properties represent, see [Device information properties](/windows/uwp/devices-sensors/device-information-properties).

## -returns
A [PnpObjectWatcher](pnpobjectwatcher.md) object used to enumerate the collection by registering event notification delegates and by issuing start and stop event notifications.

## -remarks
[CreateWatcher](pnpobject_createwatcher_1842907357.md) is a primary starting point method for enumerating device objects. A client should use this API to enumerate [PnpObject](pnpobject.md)s if they want the enumeration to happen incrementally, or if they want the results to be updated as things change. For example, if a [PnpObject](pnpobject.md) is added, removed or its properties are updated, the client will register event handlers with the returned watcher object to receive the enumerated [PnpObject](pnpobject.md) as well as the later updates.

## -examples

## -see-also
[CreateWatcher(PnpObjectType, IIterable_1, String)](pnpobject_createwatcher_1842907357.md), [Device information properties](/windows/uwp/devices-sensors/device-information-properties)
