---
-api-id: P:Windows.Storage.ApplicationData.RoamingStorageQuota
-api-type: winrt property
---

<!-- Property syntax
public ulong RoamingStorageQuota { get; }
-->

# Windows.Storage.ApplicationData.RoamingStorageQuota

## -description
Gets the maximum size of the data that can be synchronized to the cloud from the roaming app data store.

## -property-value
The maximum size of the data, in KB.

## -remarks

> [!WARNING]
> As of Windows 10, version 1909, it was [announced](/windows/deployment/planning/windows-10-deprecated-features) that Package State Roaming (PSR) will be removed in a future update. PSR allows non-Microsoft developers to access roaming data on devices, enabling developers of UWP applications to write data to Windows and synchronize it to other instantiations of Windows for that user.
> 
>The recommended replacement for PSR is [Azure App Service](/azure/app-service/). Azure App Service is widely supported, well documented, reliable, and supports cross-platform/cross-ecosystem scenarios such as iOS, Android and web.

If the current size of the roaming data in the roaming app data store exceeds the maximum size specified by RoamingStorageQuota, the system suspends data replication for all apps in the package to the cloud until the current size no longer exceeds the maximum size.

## -examples

## -see-also
