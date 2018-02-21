---
-api-id: M:Windows.System.RemoteSystems.RemoteSystem.CreateWatcher
-api-type: winrt method
---

<!-- Method syntax
public Windows.System.RemoteSystems.RemoteSystemWatcher CreateWatcher()
-->

# Windows.System.RemoteSystems.RemoteSystem.CreateWatcher

## -description
Returns a [RemoteSystemWatcher](remotesystemwatcher.md) object with no filters.

## -returns
A watcher that can raise events related to the status of any discoverable device.

## -remarks
> [!IMPORTANT]
> You must confirm access to the remote system platform with a call to **[RemoteSystem.RequestAccessAsync](remotesystem_requestaccessasync_380675631.md)** before you call this method.

## -examples

## -see-also
[CreateWatcher(IIterable(IRemoteSystemFilter))](remotesystem_createwatcher_1086025665.md)

## -capabilities
remoteSystem
