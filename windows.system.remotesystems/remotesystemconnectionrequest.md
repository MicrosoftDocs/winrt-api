---
-api-id: T:Windows.System.RemoteSystems.RemoteSystemConnectionRequest
-api-type: winrt class
---

<!-- Class syntax.
public class RemoteSystemConnectionRequest : Windows.System.RemoteSystems.IRemoteSystemConnectionRequest
-->

# Windows.System.RemoteSystems.RemoteSystemConnectionRequest

## -description
Represents an intent to communicate with a specific remote system (device).

## -remarks
An instance of this class is constructed from a given [RemoteSystem](remotesystem.md) object. All of the remote system features, such as remote launch or remote app service connection, require the use of this object to determine which system (device) to connect to.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1809 | 17763 | CreateForApp |
| 1809 | 17763 | RemoteSystemApp |
| 1903 | 18362 | ConnectionToken |
| 1903 | 18362 | CreateFromConnectionToken |
| 1903 | 18362 | CreateFromConnectionTokenForUser |

## -examples

## -see-also
[Connected apps and devices (Project Rome)](/windows/uwp/launch-resume/connected-apps-and-devices)

## -capabilities
remoteSystem
