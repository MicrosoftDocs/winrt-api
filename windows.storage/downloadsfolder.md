---
-api-id: T:Windows.Storage.DownloadsFolder
-api-type: winrt class
---

<!-- Class syntax.
public class DownloadsFolder 
-->

# Windows.Storage.DownloadsFolder

## -description
Creates files and folders inside the Downloads folder.

## -remarks
This class is static and cannot be instantiated. Call the methods directly instead.

### File and folder permissions in the Downloads folder

All apps can create files and folders in the Downloads folder and can access the files that they create. But apps can't access files in the Downloads folder that they didn't create.

When your app creates a file in the Downloads folder, other apps can't interfere with or access your file unless the user explicitly gives the other app access. The user can give another app access to your file by selecting the file from the file picker. Your app can also use the file picker to get access to the files in the Downloads folder that it didn't create. Learn more about opening files with the file picker in [Open files and folders with a picker](/windows/uwp/files/quickstart-using-file-and-folder-pickers).

Capabilities are not needed to create or access files in the Downloads folder. Learn more about capabilities in [App capability declarations](/windows/uwp/packaging/app-capability-declarations).

To learn more about what locations your app can access, see [File access permissions](/windows/uwp/files/file-access-permissions).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | CreateFileForUserAsync(User,String) |
| 1511 | 10586 | CreateFileForUserAsync(User,String,CreationCollisionOption) |
| 1511 | 10586 | CreateFolderForUserAsync(User,String) |
| 1511 | 10586 | CreateFolderForUserAsync(User,String,CreationCollisionOption) |

## -examples
You can create an empty file in the Downloads folder like this:

```csharp
StorageFile file = await Windows.Storage.DownloadsFolder.CreateFileAsync("sample.txt");
// Process file
```

After [createFileAsync](downloadsfolder_createfileasync_1058061470.md) completes, `file` gets the new file as a [StorageFile](storagefile.md).

## -see-also
