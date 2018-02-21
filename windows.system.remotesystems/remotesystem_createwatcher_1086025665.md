---
-api-id: M:Windows.System.RemoteSystems.RemoteSystem.CreateWatcher(Windows.Foundation.Collections.IIterable{Windows.System.RemoteSystems.IRemoteSystemFilter})
-api-type: winrt method
---

<!-- Method syntax
public Windows.System.RemoteSystems.RemoteSystemWatcher CreateWatcher(Windows.Foundation.Collections.IIterable<Windows.System.RemoteSystems.IRemoteSystemFilter> filters)
-->

# Windows.System.RemoteSystems.RemoteSystem.CreateWatcher

## -description
Returns a [RemoteSystemWatcher](remotesystemwatcher.md) object that filters the remote systems it can see. The *filters* parameter determines which remote systems will be seen.

## -parameters
### -param filters
A list of objects implementing the [IRemoteSystemFilter](iremotesystemfilter.md) interface. Each item in the list acts as a filter for the set of remote systems that can be discovered.

## -returns
A watcher that can raise events related to the status of any discoverable devices that pass the given filter(s).

## -remarks
> [!IMPORTANT]
> You must confirm access to the remote system platform with a call to **[RemoteSystem.RequestAccessAsync](remotesystem_requestaccessasync_380675631.md)** before you call this method.

## -examples

## -see-also
[CreateWatcher](remotesystem_createwatcher_1506431823.md)

## -capabilities
remoteSystem
