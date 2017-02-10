---
-api-id: T:Windows.Devices.SerialCommunication.PinChangedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class PinChangedEventArgs : Windows.Devices.SerialCommunication.IPinChangedEventArgs
-->

# Windows.Devices.SerialCommunication.PinChangedEventArgs

## -description
Represents the object that is passed as a parameter to the event handler that is invoked when the state of a signal line changes on the serial port.

## -remarks
At times, the state of a signal line can change on the serial port. For example, when the break state is enabled on the serial port causing data transmission to stop. The event is reported by invoking the app-implemented [PinChanged](serialdevice_pinchanged.md) event handler. That event handler's parameter is a [PinChangedEventArgs](pinchangedeventargs.md) object. Inspect the [PinChange](pinchangedeventargs_pinchange.md) property to determine the type of signal line. Those values are defined in the [SerialPinChange](serialpinchange.md) enumeration.

## -examples

## -see-also
