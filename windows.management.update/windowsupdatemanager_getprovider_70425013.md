---
-api-id: M:Windows.Management.Update.WindowsUpdateManager.GetProvider(System.String)
-api-type: winrt method
---

# Windows.Management.Update.WindowsUpdateManager.GetProvider(System.String)

<!--
public Windows.Management.Update.WindowsSoftwareUpdateProvider GetProvider (string id);
-->


## -description

Gets the registered software-update provider that has the specified ID.

## -parameters

### -param id

The ID of the provider to retrieve.

## -returns

The [WindowsSoftwareUpdateProvider](./windowssoftwareupdateprovider.md) with the specified ID, or `null` if no such provider is registered.

## -remarks

Use [ProviderIds](./windowsupdatemanager_providerids.md) to discover the IDs of the registered providers.

## -see-also

[WindowsSoftwareUpdateProvider](./windowssoftwareupdateprovider.md)

## -examples

