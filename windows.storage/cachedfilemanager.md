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

Typically, Windows implicitly initiates updates for files that are provided by other apps when those files change.  However, you can control when updates are initiated by calling [DeferUpdates](cachedfilemanager_deferupdates.md). If you use this method are deferred until you call [CompleteUpdatesAsync](cachedfilemanager_completeupdatesasync.md) to initiate them.

## -examples
The [File picker sample](http://go.microsoft.com/fwlink/p/?linkid=234890) shows you how to use a [CachedFileManager](cachedfilemanager.md) to defer updates to a file until the app finishes modifying the file.

```javascript

if (file) {
    // Prevent updates to the remote version of the file until we finish making changes and call CompleteUpdatesAsync.
    Windows.Storage.CachedFileManager.deferUpdates(file);

    // Write to file
    Windows.Storage.FileIO.appendTextAsync(file, "Swift as a shadow").then(function () {

        // Complete updates. (May require Windows to ask for user input.)
        Windows.Storage.CachedFileManager.completeUpdatesAsync(file).then(function (fileUpdateStatus) {
            switch (fileUpdateStatus) {
                case Windows.Storage.Provider.FileUpdateStatus.complete:
                    // Perform additional tasks like notifying user of status
                    break;

                case Windows.Storage.Provider.FileUpdateStatus.completeAndRenamed:
                    // Perform additional tasks like notifying user of status, or storing the renamed file for future use
                    break;

                default:
                    // Perform additional tasks like notifying user of status
                    break;
            }
        // Handle errors with an error function
        }, function (error) {
            // Handle errors encountered during completeUpdatesAsync
        });
    // Handle errors with an error function
    }, function (error) {
        // Handle errors encountered during appendTextAsync
    });
}
```

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
[File picker sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=619994)