---
-api-id: T:Windows.System.RemoteSystems.RemoteSystemWatcherError
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum RemoteSystemWatcherError : int 
-->

# Windows.System.RemoteSystems.RemoteSystemWatcherError

## -description
Contains values that describe a watcher error: an error that caused the remote system discovery process to stop.

## -enum-fields
### -field Unknown:0
The process stopped for an unknown reason.

### -field InternetNotAvailable:1
The process stopped because the Internet connection was lost or unavailable.

### -field AuthenticationError:2
The process stopped because the user's cross-device settings don't allow discovery. You can send users directly to their settings by launching the following text as a URI: `"ms-settings:crossdevice"`.

## -remarks

## -see-also
**[ErrorOcurred](remotesystemwatcher_errorocurred.md)** event

## -examples

