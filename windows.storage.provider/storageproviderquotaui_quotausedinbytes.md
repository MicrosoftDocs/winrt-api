---
-api-id: P:Windows.Storage.Provider.StorageProviderQuotaUI.QuotaUsedInBytes
-api-type: winrt property
---

# Windows.Storage.Provider.StorageProviderQuotaUI.QuotaUsedInBytes

<!--
public ulong QuotaUsedInBytes { get; set; }
-->

## -description

The amount of storage used in the current cloud files account.

## -property-value

## -remarks

Note that even if this value is **0**, what appears to be a non-zero value will be seen on the quota bar. This prevents the quota bar from appearing as a separator. Otherwise, the quota bar value is evaluated by dividing this value by [StorageProviderQuotaUIQuotaTotalInBytes](storageproviderquotaui_quotatotalinbytes.md).

## -see-also

[StorageProviderQuotaUI](storageproviderquotaui.md)
