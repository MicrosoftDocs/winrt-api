---
-api-id: T:Windows.Media.Core.MediaStreamSourceErrorStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Core.MediaStreamSourceErrorStatus : int
-->

# MediaStreamSourceErrorStatus

## -description
Specifies errors related to [MediaStreamSource](mediastreamsource.md).

## -enum-fields
### -field Other:0
An unspecified error has occurred in the application.

### -field OutOfMemory:1
The application ran out of memory.

### -field FailedToOpenFile:2
The application failed to open a file

### -field FailedToConnectToServer:3
The application failed to connect to a streaming media server or web server.

### -field ConnectionToServerLost:4
The network connection to the server was lost.

### -field UnspecifiedNetworkError:5
An unspecified network related error has occurred.

### -field DecodeError:6
The application encountered an error while attempting to decode the media data.

### -field UnsupportedMediaFormat:7
The application does not support the media storage format or media encoding format.


## -remarks

## -examples

## -see-also