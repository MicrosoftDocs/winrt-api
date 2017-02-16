---
-api-id: M:Windows.Storage.CachedFileManager.DeferUpdates(Windows.Storage.IStorageFile)
-api-type: winrt method
---

<!-- Method syntax
public void DeferUpdates(Windows.Storage.IStorageFile file)
-->

# Windows.Storage.CachedFileManager.DeferUpdates

## -description
Lets apps defer real-time updates for a specified file.

## -parameters
### -param file
The file to defer updates for.

## -remarks
Typically, Windows implicitly initiates updates for files that are provided by other apps when those files change.  However, you can control when updates are initiated by calling [DeferUpdates](cachedfilemanager_deferupdates.md).

## -examples

## -see-also
