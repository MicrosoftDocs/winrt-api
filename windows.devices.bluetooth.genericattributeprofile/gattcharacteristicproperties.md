---
-api-id: T:Windows.Devices.Bluetooth.GenericAttributeProfile.GattCharacteristicProperties
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.Bluetooth.GenericAttributeProfile.GattCharacteristicProperties : uint
-->

# GattCharacteristicProperties

## -description
Specifies the values for the GATT characteristic properties as well as the GATT Extended Characteristic Properties Descriptor.

Provides a collection of flags representing the GATT Characteristic Properties and if the GATT Extended Properties Descriptor is present the GATT Extended Characteristic properties of the characteristic.

Represents the GATT characteristic properties, as defined by the GATT profile, and if the ExtendedProperties flag is present it also represents the properties of the Extended Characteristic Properties Descriptor.

## -enum-fields
### -field None:0
The characteristic doesn’t have any properties that apply.

### -field Broadcast:1
The characteristic supports broadcasting

### -field Read:2
The characteristic is readable

### -field WriteWithoutResponse:4
The characteristic supports Write Without Response

### -field Write:8
The characteristic is writable

### -field Notify:16
The characteristic is notifiable

### -field Indicate:32
The characteristic is indicatable

### -field AuthenticatedSignedWrites:64
The characteristic supports signed writes

### -field ExtendedProperties:128
The ExtendedProperties Descriptor is present

### -field ReliableWrites:256
The characteristic supports reliable writes

### -field WritableAuxiliaries:512
The characteristic has writable auxiliaries


## -remarks

## -examples

## -see-also
## -capabilities
bluetooth
