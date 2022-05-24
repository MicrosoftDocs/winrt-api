---
-api-id: M:Windows.System.RemoteSystems.RemoteSystem.CreateWatcherForUser(Windows.System.User)
-api-type: winrt method
---

<!-- Method syntax.
public RemoteSystemWatcher RemoteSystem.CreateWatcherForUser(User user)
-->

# Windows.System.RemoteSystems.RemoteSystem.CreateWatcherForUser

## -description
Returns a [RemoteSystemWatcher](remotesystemwatcher.md) object that operates in the context of the specified User. The *user* parameter indicates the User to discover devices for.

## -parameters
### -param user
The specific User for which the RemoteSystemWatcher will discover remote systems.

## -returns
A watcher that can raise events related to the status of a specific User's discoverable devices.

## -remarks

## -see-also
[CreateWatcher](remotesystem_createwatcher_1506431823.md), [CreateWatcherForUser](remotesystem_createwatcherforuser_380170586.md), [RemoteSystemWatcher](remotesystemwatcher.md)

## -examples
