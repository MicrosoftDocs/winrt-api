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

The properties of the RemoteSystem class are used to determine the operations that can be done on a given remote system.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | GetCapabilitySupportedAsync |
| 1703 | 15063 | IsAuthorizationKindEnabled |
| 1703 | 15063 | IsAvailableBySpatialProximity |
| 1709 | 16299 | ManufacturerDisplayName |
| 1709 | 16299 | ModelDisplayName |
| 1803 | 17134 | Platform |
| 1809 | 17763 | Apps |
| 1903 | 18362 | CreateWatcherForUser(User) |
| 1903 | 18362 | CreateWatcherForUser(User,IEnumerable&lt;IRemoteSystemFilter&gt;) |
| 1903 | 18362 | User |

## -examples

## -see-also

[Connected apps and devices (Project Rome)](/windows/uwp/launch-resume/connected-apps-and-devices), [Remote systems sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/RemoteSystems)

## -capabilities

remoteSystem
