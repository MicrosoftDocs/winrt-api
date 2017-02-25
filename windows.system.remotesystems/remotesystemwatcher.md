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
This class is instantiated when the static method [CreateWatcher](remotesystem_createwatcher.md) is called. Objects of this class begin watching activity when the [Start](remotesystemwatcher_start.md) method is called and stop when [Stop](remotesystemwatcher_stop.md) is called, when the operation times out, or when the app exits or is suspended by the system.

## -examples

## -see-also
[Connected apps and devices (Project Rome)](https://msdn.microsoft.com/en-us/windows/uwp/launch-resume/connected-apps-and-devices)

## -capabilities
remoteSystem