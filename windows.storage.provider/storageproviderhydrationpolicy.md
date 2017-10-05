---
-api-id: T:Windows.Storage.Provider.StorageProviderHydrationPolicy
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum StorageProviderHydrationPolicy : int 
-->

# Windows.Storage.Provider.StorageProviderHydrationPolicy

## -description
An enumeration of file hydration policy values for a placeholder file. The hydration policy allows a sync root to customize behavior for retrieving data for a placeholder file. 

## -enum-fields
### -field Partial:0
Hydration is performed at the user's request. Hydration does not continue in the background.

### -field Progressive:1
On demand hyrdration is performed. If hydration has not finished, it will continue in the background.

### -field Full:2
Full hydration is performed. Ensures that the placeholder is available locally before completing a request.

### -field AlwaysFull:3
If this is selected and a placeholder cannot be fully hydrated, the platform will fail with: ERROR_CLOUD_FILE_INVALID_REQUEST.

## -remarks

## -see-also

## -examples

