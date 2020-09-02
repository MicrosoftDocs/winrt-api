---
-api-id: M:Windows.Storage.Provider.StorageProviderSyncRootManager.Unregister(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public void StorageProviderSyncRootManager.Unregister(String id)
-->

# Windows.Storage.Provider.StorageProviderSyncRootManager.Unregister

## -description
Unregisters a sync root from the operating system.

## -parameters
### -param id
The Id of the sync root to unregister.

## -remarks

Desktop apps that are not packaged using [MSIX](/windows/msix/) must call this method when uninstalled in order to unregister the sync root. 

Packaged desktop apps do not need to call this method on uninstall, because the sync root will be automatically unregistered by the OS.


## -see-also

## -examples

