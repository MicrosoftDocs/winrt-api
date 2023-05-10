---
-api-id: M:Windows.Networking.XboxLive.XboxLiveEndpointPair.DeleteAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction DeleteAsync()
-->

# Windows.Networking.XboxLive.XboxLiveEndpointPair.DeleteAsync

## -description

Begins gracefully terminating the **XboxLiveEndpointPair** security relationship between the two endpoints. A best-effort attempt to notify the remote device is performed, though there's no guarantee that this notification will be received if the remote device is no longer available or reachable. The remote device might instead time out the **XboxLiveEndpointPair**. The action will complete successfully regardless of the remote device or the prior status of the **XboxLiveEndpointPair**.

> [!IMPORTANT]
> This API is not available to all apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -returns

An asynchronous delete operation on an **XboxLiveEndpointPair** instance. 

## -remarks

## -examples

## -see-also
