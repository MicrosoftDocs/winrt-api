---
-api-id: T:Windows.Storage.FileIO
-api-type: winrt class
---

<!-- Class syntax.
public class FileIO 
-->

# Windows.Storage.FileIO

## -description

Provides helper methods for reading and writing files that are represented by objects of type [IStorageFile](istoragefile.md).

## -remarks

This class is static and cannot be instantiated. Call the methods directly instead.

To learn more about what locations your app can access, see [File access permissions](https://docs.microsoft.com/windows/uwp/files/file-access-permissions).

To learn how to read and write to files, see [Create, write, and read a file](https://docs.microsoft.com/windows/uwp/files/quickstart-reading-and-writing-files).

## -examples

The [File Access sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FileAccess) shows you how to use [writeTextAsync(file, contents)](fileio_writetextasync_1850452055.md) to write text to a file.

```javascript
if (file !== null) {
    Windows.Storage.FileIO.writeTextAsync(file, "Swift as a shadow").done(function () {
        // Perform additional tasks after file is written
    },
    // Handle errors with an error function
    function (error) {
        // Handle errors encountered during write
    });
}
```

```csharp
try
{
    if (file != null)
    {
        await FileIO.WriteTextAsync(file, "Swift as a shadow");
    }
}
// Handle errors with catch blocks
catch (FileNotFoundException)
{
    // For example, handle file not found
}
```

In the example, `file` is a local variable that contains a [storageFile](storagefile.md) that represents the file to write.

Although the [writeTextAsync](fileio_writetextasync_1850452055.md) methods don't have a return value, you can still perform additional tasks after the text is written to the file, as the example shows.The [File Access sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FileAccess) also shows you how to use [readTextAsync(file)](fileio_readtextasync_784288594.md) to read text from a file.

```javascript
if (file !== null) {
    Windows.Storage.FileIO.readTextAsync(file).done(function (fileContent) {
        // Process content read from the file
    },
    // Handle errors with an error function
    function (error) {
        // Handle errors encountered during read
    });
}
```

```csharp
try
{
    if (file != null)
    {
        string fileContent = await FileIO.ReadTextAsync(file);
    }
}
// Handle errors with catch blocks
catch (FileNotFoundException)
{
    // For example, handle file not found
}
```

In the example, `file` is a local variable that contains a [storageFile](storagefile.md) that represents the file to read.

After [readTextAsync](fileio_readtextasync_1063800.md) completes, the `fileContent` variable gets the contents of the file as a text string. You can then process the contents as appropriate.

## -see-also

[RSS reader end-to-end (JavaScript) sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FeedReader)