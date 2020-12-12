---
-api-id: T:Windows.Storage.CachedFileManager
-api-type: winrt class
---

<!-- Class syntax.
public class CachedFileManager 
-->

# Windows.Storage.CachedFileManager

## -description

Lets apps manage real-time updates to files.

## -remarks

This class is static and cannot be instantiated. Call the methods directly instead.

Typically, Windows implicitly initiates updates for files that are provided by other apps when those files change.  However, you can control when updates are initiated by calling [DeferUpdates](cachedfilemanager_deferupdates_1404792989.md). If you use this method are deferred until you call [CompleteUpdatesAsync](cachedfilemanager_completeupdatesasync_1507988567.md) to initiate them.

## -examples

The [File picker sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePicker) shows you how to use a CachedFileManager to defer updates to a file until the app finishes modifying the file.

```csharp
if (file != null)
{
    // Prevent updates to the remote version of the file until we finish making changes and call CompleteUpdatesAsync.
    CachedFileManager.DeferUpdates(file);

    // Write to file
    await FileIO.AppendTextAsync(file, "Swift as a shadow");
    // Let Windows know that we're finished changing the file so the server app can update the remote version of the file.

    // Complete updates. (May require Windows to ask for user input.)
    FileUpdateStatus status = await CachedFileManager.CompleteUpdatesAsync(file);
    switch (status)
    {
        case FileUpdateStatus.Complete:
            // Perform additional tasks like notifying user of status
            break;

        case FileUpdateStatus.CompleteAndRenamed:
            // Perform additional tasks like notifying user of status, or storing the renamed file for future use
            break;

        default:
            // Perform additional tasks like notifying user of status
            break;
    }
}

```

In the example, `file` is a local variable that contains a [StorageFile](storagefile.md) that represents the file to defer updates for.

## -see-also

[File picker sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FilePicker)
