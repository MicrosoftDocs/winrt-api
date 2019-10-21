---
-api-id: T:Windows.Media.PlayTo.PlayToConnectionError
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.PlayTo.PlayToConnectionError : int
-->

# PlayToConnectionError

## -description
Describes an error on a Play To connection.

## -enum-fields
### -field None:0
No error occurred.

### -field DeviceNotResponding:1
The Play To target device has not responded for at least 5 seconds.

### -field DeviceError:2
The Play To target device has encountered an error.

### -field DeviceLocked:3
The Play To target device is locked.

### -field ProtectedPlaybackFailed:4
The Play To target device failed to play the protected content.


## -remarks


## -examples

## -see-also
[PlayToConnectionErrorEventArgs.Code Property](playtoconnectionerroreventargs_code.md), [PlayToConnection.Error Event](playtoconnection_error.md), [Play To sample](https://go.microsoft.com/fwlink/p/?linkid=245166), [PlayToReceiver sample](https://go.microsoft.com/fwlink/p/?linkid=245167), [Media Server sample](https://go.microsoft.com/fwlink/p/?linkid=245168)
