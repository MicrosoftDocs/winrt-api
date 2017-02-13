---
-api-id: P:Windows.Devices.SerialCommunication.SerialDevice.Parity
-api-type: winrt property
---

<!-- Property syntax
public Windows.Devices.SerialCommunication.SerialParity Parity { get;  set; }
-->

# Windows.Devices.SerialCommunication.SerialDevice.Parity

## -description
Gets or sets the parity bit for error-checking.

## -property-value
One of the values defined in [SerialParity](serialparity.md) enumeration.

## -remarks
In serial communication, the parity bit is used as an error-checking procedure. In data transmission that uses parity checking, the bit format is 7 data bits-*x*-1 stop bit, where *x* is the parity bit. That bit indicates whether the number of 1s in the data byte is even or odd. The parity bit can be E (even), O (odd), M (mark), or S (space). Those values are defined in the [SerialParity](serialparity.md) enumeration.

For example, if the format is 7-E-1 and the data bits are 0001000, the parity bit is set to 1 to make sure there are even number of 1s.

## -examples

## -see-also
