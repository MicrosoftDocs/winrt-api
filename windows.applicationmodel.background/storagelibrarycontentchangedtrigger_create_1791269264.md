---
-api-id: M:Windows.ApplicationModel.Background.StorageLibraryContentChangedTrigger.Create(Windows.Storage.StorageLibrary)
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Background.StorageLibraryContentChangedTrigger Create(Windows.Storage.StorageLibrary storageLibrary)
-->

# Windows.ApplicationModel.Background.StorageLibraryContentChangedTrigger.Create

## -description
Creates a trigger that will fire when a file is changed in the specified library.

## -parameters
### -param storageLibrary
The location that the trigger monitors such as the music library or documents library.

## -returns
A trigger that monitors the specified location.

## -remarks
For more details on how to use the trigger and a code sample, please see [File System Monitoring in Universal Windows Platform Apps](/archive/msdn-magazine/2016/december/universal-windows-platform-file-system-monitoring-in-universal-windows-platform-apps)

## -examples
```csharp
//Get access to the library that you want to monitor 
StorageLibrary picturesLibrary = await StorageLibrary.GetLibraryAsync(KnownLibraryId.Pictures); 
var trigger = StorageLibraryContentChangedTrigger.Create(picturesLibrary);
```



## -see-also
[GetLibraryAsync](../windows.storage/storagelibrary_getlibraryasync_1997874509.md)
