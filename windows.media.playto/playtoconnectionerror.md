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
[PlayToConnectionErrorEventArgs.Code Property](playtoconnectionerroreventargs_code.md), [PlayToConnection.Error Event](playtoconnection_error.md), [Play To sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Play%20To%20sample%20(Windows%208)), [PlayToReceiver sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Play%20To%20sample%20(Windows%208)), [Media Server sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Server%20client%20sample%20(Windows%208)/C%2B%2B)