---
-api-id: P:Windows.Management.Update.WindowsUpdateManager.ProviderIds
-api-type: winrt property
---

# Windows.Management.Update.WindowsUpdateManager.ProviderIds

<!--
public string[] ProviderIds { get; }
-->


## -description

Gets the IDs of the software-update providers that are registered on the device (filtered to the set this manager was scoped to, if any).

## -property-value

An array of registered provider IDs.

## -remarks

Pass an ID to [GetProvider](./windowsupdatemanager_getprovider_70425013.md) to obtain the corresponding [WindowsSoftwareUpdateProvider](./windowssoftwareupdateprovider.md).

## -see-also

[WindowsSoftwareUpdateProvider](./windowssoftwareupdateprovider.md)

## -examples

