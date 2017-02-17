---
-api-id: T:Windows.System.RemoteSystems.RemoteSystem
-api-type: winrt class
---

<!-- Class syntax.
public class RemoteSystem : Windows.System.RemoteSystems.IRemoteSystem, Windows.System.RemoteSystems.IRemoteSystemResource
-->

# Windows.System.RemoteSystems.RemoteSystem

## -description
This class manages the attributes of a discovered remote system (device) and provides the capabilities to discover remote systems as part of Project Rome.

## -remarks
This class is instantiated whenever a remote system (device) is discovered, is updated, or disappears (the instance is referenced as a property of the [RemoteSystemAddedEventArgs](remotesystemaddedeventargs.md), [RemoteSystemUpdatedEventArgs](remotesystemupdatedeventargs.md), or [RemoteSystemRemovedEventArgs](remotesystemremovedeventargs.md) class).

The properties of the [RemoteSystem](remotesystem.md) class are used to determine the operations that can be done on a given remote system.

## -examples

## -see-also
[Connected apps and devices (Project Rome)](https://msdn.microsoft.com/en-us/windows/uwp/launch-resume/connected-apps-and-devices)

## -capabilities
remoteSystem