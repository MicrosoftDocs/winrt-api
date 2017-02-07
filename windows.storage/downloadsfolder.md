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

When your app creates a file in the Downloads folder, other apps can't interfere with or access your file unless the user explicitly gives the other app access. The user can give another app access to your file by selecting the file from the file picker. Your app can also use the file picker to get access to the files in the Downloads folder that it didn't create. Learn more about opening files with the file picker in [Quickstart: Accessing files with a file picker](http://msdn.microsoft.com/library/df082239-381c-462f-9f97-d2b390a2052e).

Capabilities are not needed to create or access files in the Downloads folder. Learn more about capabilities in [Access to user resources using the Windows Runtime](http://msdn.microsoft.com/library/7b4402ea-55f6-438d-b9d1-8e65d56c8f42).

To learn more about what locations your app can access, see [File access permissions](http://msdn.microsoft.com/library/3a404cc0-a997-45c8-b2e8-44745539759d).

## -examples
You can create an empty file in the Downloads folder like this:

```javascript
Windows.Storage.DownloadsFolder.createFileAsync("sample.txt").done(
    function (file) {
        // Process file
    }
);
```

```csharp
StorageFile file = await Windows.Storage.DownloadsFolder.CreateFileAsync("sample.txt");
// Process file
```

After [createFileAsync](downloadsfolder_createfileasync.md) completes, `file` gets the new file as a [StorageFile](storagefile.md).

## -see-also