---
-api-id: M:Windows.Storage.ApplicationData.ClearAsync(Windows.Storage.ApplicationDataLocality)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction ClearAsync(Windows.Storage.ApplicationDataLocality locality)
-->

# Windows.Storage.ApplicationData.ClearAsync

## -description
Removes all application data from the specified app data store.

> [!NOTE]
> [ClearAsync(ApplicationDataLocality)](applicationdata_clearasync_1576055195.md) method encounters an error if there are any open file handles. You should take care to close all open files prior to calling ClearAsync.

## -parameters
### -param locality
One of the enumeration values.

## -returns
An object that is used to manage the asynchronous clear operation.

## -remarks

## -examples

## -see-also
[ClearAsync](applicationdata_clearasync_1031039026.md)