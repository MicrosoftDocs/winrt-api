---
-api-id: M:Windows.System.RemoteSystems.RemoteSystem.FindByHostNameAsync(Windows.Networking.HostName)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.System.RemoteSystems.RemoteSystem> FindByHostNameAsync(Windows.Networking.HostName hostName)
-->

# Windows.System.RemoteSystems.RemoteSystem.FindByHostNameAsync

## -description
Attempts to discover a single remote system specified by the *HostName* parameter.

## -parameters
### -param hostName
A wrapper object for the address of a remote system to be discovered. For information on how to instantiate a , see the [HostName constructor](../windows.networking/hostname_hostname_290278668.md).

## -returns
An asynchronous operation that returns the [RemoteSystem](remotesystem.md) that was found. Returns *null* if no  was found.

## -remarks
> [!IMPORTANT]
> You must confirm access to the remote system platform with a call to **[RemoteSystem.RequestAccessAsync](remotesystem_requestaccessasync_380675631.md)** before you call this method.

## -examples

## -see-also


## -capabilities
remoteSystem
