---
-api-id: T:Windows.Devices.SerialCommunication.SerialParity
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.SerialCommunication.SerialParity : int
-->

# SerialParity

## -description
Defines values for the parity bit for the serial data transmission. The values are used by the [Parity](serialdevice_parity.md) property on the [SerialDevice](serialdevice.md) object.

## -enum-fields
### -field None:0
No parity check occurs.

### -field Odd:1
Sets the parity bit so that the total count of data bits set is an odd number.

### -field Even:2
Sets the parity bit so that the total count of data bits set is an even number.

### -field Mark:3
Leaves the parity bit set to 1.

### -field Space:4
Leaves the parity bit set to 0.


## -remarks

## -examples

## -see-also