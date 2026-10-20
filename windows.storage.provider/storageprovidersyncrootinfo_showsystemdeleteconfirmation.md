---
-api-id: P:Windows.Storage.Provider.StorageProviderSyncRootInfo.ShowSystemDeleteConfirmation
-api-type: winrt property
---

<!-- Property syntax.
public bool ShowSystemDeleteConfirmation { get; set; }
-->

# StorageProviderSyncRootInfo.ShowSystemDeleteConfirmation

## -description
Gets or sets whether Windows displays a system delete confirmation dialog when the user deletes items from the storage provider sync root in File Explorer.

## -property-value
Type: **Boolean**

**True** if the system delete confirmation dialog is enabled and displayed by Windows when items are deleted in the sync root. **False** if the system delete confirmation dialog is disabled and not displayed by Windows. The default value is **True**.

## -remarks

Set this property before registering a sync root by calling [StorageProviderSyncRootManager.Register](storageprovidersyncrootmanager_register_1146790023.md).

Set **ShowSystemDeleteConfirmation** to `false` if your cloud storage provider displays its own delete confirmation experience. Disabling the Windows confirmation dialog can help avoid presenting multiple confirmation prompts for the same delete operation.

When this property is `false`, the provider is responsible for any confirmation, undo, restore, or recovery experience associated with deleting items.

This property affects only whether Windows displays its built-in delete confirmation dialog for delete operations in the sync root. It does not change how items are deleted, synchronized, restored, or recycled by the provider.

Apps should check for this property before setting it to ensure compatibility with versions of Windows that do not support it.

## -see-also

[StorageProviderSyncRootInfo](storageprovidersyncrootinfo.md), [StorageProviderSyncRootManager.Register](storageprovidersyncrootmanager_register_1146790023.md), [ApiInformation.IsPropertyPresent](../windows.foundation.metadata/apiinformation_ispropertypresent_963133031.md)

## -examples

The following example suppresses the Windows delete confirmation dialog for a sync root when the property is available.

```csharp
using Windows.Foundation.Metadata;
using Windows.Storage.Provider;

StorageProviderSyncRootInfo syncRootInfo = new StorageProviderSyncRootInfo();

// Set the other required sync root properties before registration.

if (ApiInformation.IsPropertyPresent(
    "Windows.Storage.Provider.StorageProviderSyncRootInfo",
    "ShowSystemDeleteConfirmation"))
{
    syncRootInfo.ShowSystemDeleteConfirmation = false;
}

StorageProviderSyncRootManager.Register(syncRootInfo);
```
