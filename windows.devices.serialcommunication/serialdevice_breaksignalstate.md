---
-api-id: P:Windows.Devices.SerialCommunication.SerialDevice.BreakSignalState
-api-type: winrt property
---

<!-- Property syntax
public bool BreakSignalState { get;  set; }
-->

# Windows.Devices.SerialCommunication.SerialDevice.BreakSignalState

## -description
Gets or sets the break signal state.

## -property-value
Toggles the TX line to enable or disable data transmission.

## -remarks
In serial communication, the break signal state is used to toggle the TX line. To suspend data transmission, set the property value to **true**. In that state, you cannot write to the serial port. To resume transmission, set to **false**.

## -examples

## -see-also
