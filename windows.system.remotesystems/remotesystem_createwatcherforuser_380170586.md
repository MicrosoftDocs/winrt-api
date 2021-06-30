---
-api-id: M:Windows.System.RemoteSystems.RemoteSystem.CreateWatcherForUser(Windows.System.User,Windows.Foundation.Collections.IIterable{Windows.System.RemoteSystems.IRemoteSystemFilter})
-api-type: winrt method
---

<!-- Method syntax.
public RemoteSystemWatcher RemoteSystem.CreateWatcherForUser(User user, IIterable<IRemoteSystemFilter> filters)
-->

# Windows.System.RemoteSystems.RemoteSystem.CreateWatcherForUser

## -description
Returns a [RemoteSystemWatcher](remotesystemwatcher.md) object that operates in the context of a given User and filters the remote systems it can see. The *user* parameter indicates the User to discover remote systems for. The *filters* parameter determines which remote systems will be seen.

## -parameters
### -param user
The specific User for which the RemoteSystemWatcher will discover remote systems.

### -param filters
A list of objects implementing the [IRemoteSystemFilter](iremotesystemfilter.md) interface. Each item in the list acts as a filter for the set of remote systems that can be discovered.

## -returns
A watcher that can raise events related to the status of any discoverable devices that pass the given user and filter(s) parameters.

## -remarks

## -see-also
[CreateWatcher](remotesystem_createwatcher_1506431823.md), [CreateWatcherForUser](remotesystem_createwatcherforuser_608864326.md), [RemoteSystemWatcher](remotesystemwatcher.md)

## -examples
