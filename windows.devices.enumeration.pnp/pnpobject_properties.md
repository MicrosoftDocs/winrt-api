---
-api-id: P:Windows.Devices.Enumeration.Pnp.PnpObject.Properties
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IMapView<string, object> Properties { get; }
-->

# Windows.Devices.Enumeration.Pnp.PnpObject.Properties

## -description

> [!IMPORTANT]
> We no longer recommend that you use the types in the **Windows.Devices.Enumeration.Pnp** namespace. Instead, the types in the [Windows.Devices.Enumeration](/uwp/api/windows.devices.enumeration) namespace implement a modern, and better maintained, superset of the functionality of **Windows.Devices.Enumeration.Pnp**.
>
> The alternative to **PnpObjectType** is the [Windows.Devices.Enumeration.DeviceInformationKind](/uwp/api/windows.devices.enumeration.deviceinformationkind) enum, which you can pass as a parameter to **Windows.Devices.Enumeration** APIs. For example, instead of using **PnpObjectType** when you create a **PnpObjectWatcher**, use **DeviceInformationKind** when you create a [DeviceWatcher](/uwp/api/windows.devices.enumeration.devicewatcher).

A property store containing well-known values as well as additional specified properties.

## -property-value
A pointer to the property store.

## -remarks
For more info on what the properties represent, see [Device information properties](/windows/uwp/devices-sensors/device-information-properties).

## -examples

## -see-also
