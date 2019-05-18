---
-api-id: E:Windows.Devices.SerialCommunication.SerialDevice.ErrorReceived
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ErrorReceived<Windows.Devices.SerialCommunication.SerialDevice,  Windows.Devices.SerialCommunication.ErrorReceivedEventArgs>
-->

# Windows.Devices.SerialCommunication.SerialDevice.ErrorReceived

## -description
Event handler that is invoked when error occurs on the serial port.

## -remarks
This event is used to detect and respond to errors when communicating data through a serial port. When an error condition occurs, the ErrorReceived event handler is invoked and error information is received in an [ErrorReceivedEventArgs](errorreceivedeventargs.md) object. Determine the type of error by retrieving the [Error](errorreceivedeventargs_error.md) property of the [ErrorReceivedEventArgs](errorreceivedeventargs.md) class. Those property values are defined in the [SerialError](serialerror.md) enumeration.

## -examples

## -see-also
