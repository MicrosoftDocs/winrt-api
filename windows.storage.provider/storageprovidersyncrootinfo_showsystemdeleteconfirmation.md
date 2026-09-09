---
-api-id: P:Windows.Storage.Provider.StorageProviderSyncRootInfo.ShowSystemDeleteConfirmation
-api-type: winrt property
---

<!-- Property syntax.
public bool ShowSystemDeleteConfirmation { get; set; }
-->

# Windows.Storage.Provider.StorageProviderSyncRootInfo.ShowSystemDeleteConfirmation

## -description
Gets or sets whether Windows shows the system delete confirmation dialog when the user deletes items from the sync root in File Explorer.

## -property-value
**True** if Windows shows the system delete confirmation dialog for deleted items in the sync root; **False** if Windows suppresses the system delete confirmation dialog. The default value is **True**.

## -remarks

Set this property when registering a sync root with [StorageProviderSyncRootManager.Register](storageprovidersyncrootmanager_register_1146790023.md).

Set **ShowSystemDeleteConfirmation** to **False** when your cloud storage provider shows its own delete confirmation UI or has another user-confirmation model and the additional Windows confirmation dialog would be redundant or confusing. For example, a provider that asks the user to confirm deletion after it receives delete notifications can suppress the Windows dialog so users see only the provider-owned confirmation experience.

When this property is **False**, the provider is responsible for giving users any required confirmation, undo, restore, or recovery experience. Suppressing the Windows confirmation dialog does not change how items are deleted, recycled, restored, or synchronized by the provider. It only controls whether Windows shows its built-in confirmation dialog for delete operations in the sync root.

Existing apps should check for this property before setting it so they can continue to run on versions of Windows that do not support it.

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
