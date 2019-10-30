---
-api-id: M:Windows.Networking.Connectivity.ConnectionProfile.TryDeleteAsync
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public IAsyncOperation<ConnectionProfileDeleteStatus> ConnectionProfile.TryDeleteAsync()
-->

# Windows.Networking.Connectivity.ConnectionProfile.TryDeleteAsync

## -description
Asynchronously attempts to delete this connection profile; the operation may or may not succeed. Examine the return value to determine the outcome of the operation.

## -returns
An asynchronous operation object which, when it completes, returns a [ConnectionProfileDeleteStatus](connectionprofiledeletestatus.md) indicating whether or not the connection profile was deleted.

## -remarks
If you're unable to delete a connection profile, then that might be due to policies that have been configured by a network administrator. Also, you may need to configure additional capabilities in order to delete certain types of connection profiles. For Wi-Fi connection profiles, the wiFiControl capability is needed. Calling [WiFiAdapter.RequestAccessAsync](../windows.devices.wifi/wifiadapter_requestaccessasync_380675631.md) prior to attempting to delete any Wi-Fi connection profiles may allow additional connection profiles to be deleted.

## -see-also

## -examples
