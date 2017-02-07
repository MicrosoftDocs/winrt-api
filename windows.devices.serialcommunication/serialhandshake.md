---
-api-id: T:Windows.Devices.SerialCommunication.SerialHandshake
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.SerialCommunication.SerialHandshake : int
-->

# SerialHandshake

## -description
Defines values for hardware and software flow control protocols used in serial communication. The values are used by [Handshake](serialdevice_handshake.md) property on the [SerialDevice](serialdevice.md) object.

## -enum-fields
### -field None:0
No protocol is used for the handshake.

### -field RequestToSend:1
When the port is receiving data and if the read buffer is full, the Request-to-Send (RTS) line is set to **false**. When buffer is available, the line is set to **true**. When the serial port is transmitting data, CTS line is set to **false** and the port does not send data until there is room in the write buffer.

### -field XOnXOff:2
The serial port sends an Xoff control to inform the sender to stop sending data. When ready, the port sends an Xon control to inform he sender that the port is now ready to receive data.

### -field RequestToSendXOnXOff:3
Both **RequestToSend** and **XOnXOff** controls are used for flow control.


## -remarks

## -examples

## -see-also