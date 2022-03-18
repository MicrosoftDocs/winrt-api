---
-api-id: T:Windows.System.RemoteSystems.RemoteSystemUpdatedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class RemoteSystemUpdatedEventArgs : Windows.System.RemoteSystems.IRemoteSystemUpdatedEventArgs
-->

# Windows.System.RemoteSystems.RemoteSystemUpdatedEventArgs

## -description
Gets information about a [RemoteSystemUpdated](remotesystemwatcher_remotesystemupdated.md) event, namely the [RemoteSystem](remotesystem.md) that was updated.

## -remarks
This class is instantiated whenever the [RemoteSystemUpdated](remotesystemwatcher_remotesystemupdated.md) event is raised (that is, whenever a previously discovered [RemoteSystem](remotesystem.md) has any of its properties changed), and it should be handled by the method(s) registered to this event.

## -examples

## -see-also
[Connected apps and devices (Project Rome)](/windows/uwp/launch-resume/connected-apps-and-devices)

## -capabilities
remoteSystem
