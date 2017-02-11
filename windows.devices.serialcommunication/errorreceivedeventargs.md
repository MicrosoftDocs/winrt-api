---
-api-id: T:Windows.Devices.SerialCommunication.ErrorReceivedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class ErrorReceivedEventArgs : Windows.Devices.SerialCommunication.IErrorReceivedEventArgs
-->

# Windows.Devices.SerialCommunication.ErrorReceivedEventArgs

## -description
Represents the object that is passed as a parameter to the event handler that is invoked when error occurs on the serial port.

## -remarks
[ErrorReceivedEventArgs](errorreceivedeventargs.md) is used to determine the type of error condition. When error occurs on the port, the previously registered [ErrorReceived](serialdevice_errorreceived.md) event handler is invoked. That event handler's parameter is a [ErrorReceivedEventArgs](errorreceivedeventargs.md) object. After the event handler is invoked, you can determine the error condition by using the [Error](serialerror.md) property.

## -examples

## -see-also
