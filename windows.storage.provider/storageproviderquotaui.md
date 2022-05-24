---
-api-id: T:Windows.Storage.Provider.StorageProviderQuotaUI
-api-type: winrt class
---

# Windows.Storage.Provider.StorageProviderQuotaUI

<!--
public sealed class StorageProviderQuotaUI
-->

## -description

The container for the quota UI section of the storage provider flyout. This specifies the total amount of storage in the cloud files account and how much is used.

## -remarks

This section will be collapsed unless the [StorageProviderQuotaUIQuotaUsedLabel](storageproviderquotaui_quotausedlabel.md) is non-empty. This ensures enough context is given to the quota bar, whose percentage is defined by the fraction [StorageProviderQuotaUIQuotaUsedInBytes](storageproviderquotaui_quotausedinbytes.md) over [StorageProviderQuotaUIQuotaTotalInBytes](storageproviderquotaui_quotatotalinbytes.md).

## -see-also

[StorageProviderStatusUI](storageproviderstatusui.md)
