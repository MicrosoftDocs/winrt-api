---
-api-id: M:Windows.Devices.Enumeration.Pnp.PnpObject.CreateWatcher(Windows.Devices.Enumeration.Pnp.PnpObjectType,Windows.Foundation.Collections.IIterable{System.String},System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Enumeration.Pnp.PnpObjectWatcher CreateWatcher(Windows.Devices.Enumeration.Pnp.PnpObjectType type, Windows.Foundation.Collections.IIterable<System.String> requestedProperties, System.String aqsFilter)
-->

# Windows.Devices.Enumeration.Pnp.PnpObject.CreateWatcher

## -description

> [!IMPORTANT]
> We no longer recommend that you use the types in the **Windows.Devices.Enumeration.Pnp** namespace. Instead, the types in the [Windows.Devices.Enumeration](/uwp/api/windows.devices.enumeration) namespace implement a modern, and better maintained, superset of the functionality of **Windows.Devices.Enumeration.Pnp**.
>
> The alternative to **PnpObjectType** is the [Windows.Devices.Enumeration.DeviceInformationKind](/uwp/api/windows.devices.enumeration.deviceinformationkind) enum, which you can pass as a parameter to **Windows.Devices.Enumeration** APIs. For example, instead of using **PnpObjectType** when you create a **PnpObjectWatcher**, use **DeviceInformationKind** when you create a [DeviceWatcher](/uwp/api/windows.devices.enumeration.devicewatcher).

Returns a [PnpObjectWatcher](pnpobjectwatcher.md) object that is used to enumerate a filtered collection of PnP objects using events.

## -parameters
### -param type
The type of the [PnpObject](pnpobject.md).

### -param requestedProperties
An iterable list of additional properties to include in the [Properties](pnpobject_properties.md) property of the [PnpObject](pnpobject.md) objects included in enumeration results. For more info on what the properties represent, see [Device information properties](/windows/uwp/devices-sensors/device-information-properties).

### -param aqsFilter
An AQS string that filters the PnP objects that will be returned. Typically, this string is retrieved from the  method of a class that interacts with devices.

## -returns
A [PnpObjectWatcher](pnpobjectwatcher.md) object used to enumerate the collection by registering event notification delegates and by issuing start and stop event notifications.

## -remarks

## -examples

## -see-also
[CreateWatcher(PnpObjectType, IIterable_1)](pnpobject_createwatcher_199191645.md), [Device information properties](/windows/uwp/devices-sensors/device-information-properties)
