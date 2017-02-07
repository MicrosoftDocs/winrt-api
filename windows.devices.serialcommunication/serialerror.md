---
-api-id: T:Windows.Devices.SerialCommunication.SerialError
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.SerialCommunication.SerialError : int
-->

# SerialError

## -description
Defines values for error conditions that can occur on the serial port.

## -enum-fields
### -field Frame:0
The hardware detected a framing error.

### -field BufferOverrun:1
A character-buffer overrun has occurred. The next character is lost.

### -field ReceiveFull:2
An input buffer overflow has occurred. There is either no room in the input buffer, or a character was received after the end-of-file (EOF) character.

### -field ReceiveParity:3
The hardware detected a parity error.

### -field TransmitFull:4
The application tried to transmit a character, but the output buffer was full.


## -remarks

## -examples

## -see-also