---
-api-id: E:Windows.System.RemoteSystems.RemoteSystemWatcher.ErrorOccurred
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler ErrorOccurred<RemoteSystemWatcher, RemoteSystemWatcherErrorOccurredEventArgs>
-->

# Windows.System.RemoteSystems.RemoteSystemWatcher.ErrorOccurred

## -description
This event is raised when an error occurs during discovery. The discovery process will continue if possible. For example, if the error occurs with a value of **RemoteSystemWatcherError.InternetNotAvailable** (see **[RemoteSystemWatcherError](RemoteSystemWatcherError.md)**), proximal discovery will continue because the error applies only to cloud discovery (see **[RemoteSystemDiscoveryType](remotesystemdiscoverytype.md)**).

## -remarks
The listener for this event should notify the user of the type of error that was encountered. See the **[RemoteSystemWatcherError](RemoteSystemWatcherError.md)** enum for details.

## -see-also

## -examples

