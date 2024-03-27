---
-api-id: T:Windows.Devices.Enumeration.Pnp.PnpObjectType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.Enumeration.Pnp.PnpObjectType : int
-->

# PnpObjectType

## -description

> [!IMPORTANT]
> We no longer recommend that you use the types in the **Windows.Devices.Enumeration.Pnp** namespace. Instead, the types in the [Windows.Devices.Enumeration](/uwp/api/windows.devices.enumeration) namespace implement a modern, and better maintained, superset of the functionality of **Windows.Devices.Enumeration.Pnp**.
>
> The alternative to **PnpObjectType** is the [Windows.Devices.Enumeration.DeviceInformationKind](/uwp/api/windows.devices.enumeration.deviceinformationkind) enum, which you can pass as a parameter to **Windows.Devices.Enumeration** APIs. For example, instead of using **PnpObjectType** when you create a **PnpObjectWatcher**, use **DeviceInformationKind** when you create a [DeviceWatcher](/uwp/api/windows.devices.enumeration.devicewatcher).

Defines constants that specify the type of device represented by the [PnpObject](pnpobject.md).

## -enum-fields

### -field Unknown:0

The object is of an unknown type. This value is not used.

### -field DeviceInterface:1

The [PnpObject](pnpobject.md) represents a device interface.

### -field DeviceContainer:2

The [PnpObject](pnpobject.md) represents a device container.

### -field Device:3

The [PnpObject](pnpobject.md) represents a device.

### -field DeviceInterfaceClass:4

The [PnpObject](pnpobject.md) represents a device interface class.

### -field AssociationEndpoint:5

The [PnpObject](pnpobject.md) represents an association endpoint.

### -field AssociationEndpointContainer:6

The [PnpObject](pnpobject.md) represents an association endpoint container.

### -field AssociationEndpointService:7

The [PnpObject](pnpobject.md) represents an association endpoint service.

### -field DevicePanel:8

The [PnpObject](pnpobject.md) represents a device input panel.

### -field AssociationEndpointProtocol: 9

Specifies that the [PnpObject](pnpobject.md) represents an association endpoint protocol.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1809 | 17763 | DevicePanel |

## -examples

## -see-also

[PnpObject](pnpobject.md)
