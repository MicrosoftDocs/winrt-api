---
-api-id: P:Windows.Networking.Connectivity.ConnectionProfile.CanDelete
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public bool CanDelete { get; }
-->

# Windows.Networking.Connectivity.ConnectionProfile.CanDelete

## -description
Gets a value that indicates whether or not it is possible to delete this connection profile. This can help determine whether [TryDeleteAsync](connectionprofile_trydeleteasync_41251962.md) is likely to succeed.

## -property-value
`true` if it is possible to delete this connection profile, otherwise `false`.

## -remarks
If you're unable to delete a connection profile, then that might be due to policies that have been configured by a network administrator. Also, you may need to configure additional capabilities in order to delete certain types of connection profiles. For Wi-Fi connection profiles, the wiFiControl capability is needed. Calling [WiFiAdapter.RequestAccessAsync](../windows.devices.wifi/wifiadapter_requestaccessasync_380675631.md) prior to attempting to delete any Wi-Fi connection profiles may allow additional connection profiles to be deleted.

## -see-also

## -examples

