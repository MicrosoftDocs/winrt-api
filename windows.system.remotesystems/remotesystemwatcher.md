---
-api-id: T:Windows.System.RemoteSystems.RemoteSystemWatcher
-api-type: winrt class
---

<!-- Class syntax.
public class RemoteSystemWatcher : Windows.System.RemoteSystems.IRemoteSystemWatcher
-->

# Windows.System.RemoteSystems.RemoteSystemWatcher

## -description
Watches for activity related to the discovery of remote systems and raises the appropriate events.

## -remarks
This class is instantiated when the static method [CreateWatcher](remotesystem_createwatcher_1086025665.md) is called. Objects of this class begin watching activity when the [Start](remotesystemwatcher_start_1587696324.md) method is called and stop when [Stop](remotesystemwatcher_stop_1201535524.md) is called, when the app exits or is suspended by the system, or if an error occurs.

> [!IMPORTANT]
> You must confirm access to the remote system platform with a call to **[RemoteSystem.RequestAccessAsync](remotesystem_requestaccessasync_380675631.md)** before you instantiate this class.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | EnumerationCompleted |
| 1803 | 17134 | ErrorOccurred |
| 1903 | 18362 | User |

## -examples

## -see-also
[Connected apps and devices (Project Rome)](/windows/uwp/launch-resume/connected-apps-and-devices)

## -capabilities
remoteSystem
