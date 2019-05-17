---
-api-id: T:Windows.Devices.Enumeration.Pnp.PnpObjectType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.Enumeration.Pnp.PnpObjectType : int
-->

# PnpObjectType

## -description

Indicates the type of device represented by the [PnpObject](pnpobject.md).

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

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1809 | 17763 | DevicePanel |

## -examples

## -see-also

[PnpObject](pnpobject.md)
