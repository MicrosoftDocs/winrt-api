---
-api-id: P:Windows.Devices.SerialCommunication.SerialDevice.StopBits
-api-type: winrt property
---

<!-- Property syntax
public Windows.Devices.SerialCommunication.SerialStopBitCount StopBits { get;  set; }
-->

# Windows.Devices.SerialCommunication.SerialDevice.StopBits

## -description
Gets or sets the standard number of stop bits per byte.

## -property-value
One of the values defined in the [SerialStopBitCount](serialstopbitcount.md) enumeration.

## -remarks
In serial communication, a transmission begins with a start bit, followed by 8 bits of data, and ends with a stop bit. The purpose of the stop bit is to separate each unit of data or to indicate that no data is available for transmission.

## -examples

## -see-also
