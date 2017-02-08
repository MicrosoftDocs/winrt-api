---
-api-id: P:Windows.Devices.SerialCommunication.SerialDevice.Handshake
-api-type: winrt property
---

<!-- Property syntax
public Windows.Devices.SerialCommunication.SerialHandshake Handshake { get;  set; }
-->

# Windows.Devices.SerialCommunication.SerialDevice.Handshake

## -description
Gets or sets the handshaking protocol for flow control.

## -property-value
One of the values defined in [SerialHandshake](serialhandshake.md) enumeration.

## -remarks
The handshaking protocol is used by the serial port to establish flow control between the port and the connected device. There are two types of control protocol.


+ Hardware control: The Request-to-Send (RTS) line is set to false when the receiver's buffer is full. This indicates to the sender that it must stop sending data. When the buffer is able to hold data, the RTS line is set to true that indicates to the send that it is now ready to receive data again.
+ Software control: The receiver sends an Xoff control code to the sender to stop transmission of data. When the receiver is ready, it sends the Xon code and the sender resumes data transmission.
 The [SerialHandshake](serialhandshake.md) enumeration defines the preceding control type values.

You can set hardware, software, or both types of control protocol.

## -examples

## -see-also
