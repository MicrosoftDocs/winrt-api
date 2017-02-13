---
-api-id: E:Windows.Devices.SerialCommunication.SerialDevice.PinChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler PinChanged<Windows.Devices.SerialCommunication.SerialDevice,  Windows.Devices.SerialCommunication.PinChangedEventArgs>
-->

# Windows.Devices.SerialCommunication.SerialDevice.PinChanged

## -description
Event handler that is invoked when the state of a signal or line changes on the serial port.

## -remarks
This event is used to detect and respond to changes in the signal state of the serial port. When state changes, the [PinChanged](serialdevice_pinchanged.md) event handler is invoked and information is received in a [PinChangedEventArgs](pinchangedeventargs.md) object. Determine the type of signal by retrieving the [PinChange](pinchangedeventargs_pinchange.md) property. Those property values are defined in the [SerialPinChange](serialpinchange.md) enumeration.

## -examples

## -see-also
