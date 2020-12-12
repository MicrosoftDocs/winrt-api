---
-api-id: T:Windows.Storage.PathIO
-api-type: winrt class
---

<!-- Class syntax.
public class PathIO 
-->

# Windows.Storage.PathIO

## -description
Provides helper methods for reading and writing a file using the absolute path or Uniform Resource Identifier (URI) of the file.

## -remarks
To read or write to a file using a path or Uniform Resource Identifier (URI), you must have permission to access the file's location. To learn more about what locations your app has permission to access, see [File access permissions](/windows/uwp/files/file-access-permissions).

You can specify an app Uniform Resource Identifier (URI) to read or write files in app-specific locations like your app data folder ("ms-appdata://"). To learn more about app Uniform Resource Identifier (URI), see [How to reference content](/previous-versions/windows/apps/hh781215(v=win.10)).

## -examples
You can use [WriteTextAsync(filePathOrURI, contents)](pathio_writetextasync_1597275652.md) to write text to a file. In the example, `filePathOrURI` is a local variable that contains a URI (like an app URI "ms-appdata://sampleFile.dat") or a file system path (like C:\examplepath\sampleFile.dat) for the file to read. Although the [WriteTextAsync](pathio_writetextasync_1597275652.md) methods don't have a return value, you can still perform additional tasks after the text is written to the file, as the example shows.

```csharp

try
{
    if (file != null)
    {
        await PathIO.WriteTextAsync(filePathOrURI, "Swift as a shadow");
    }
}
// Handle errors with catch blocks
catch (FileNotFoundException)
{
    // For example, handle file not found
}
```

You can use [ReadTextAsync(filePathOrURI)](pathio_readtextasync_532716801.md) to read text from a file. After [ReadTextAsync](pathio_readtextasync_532716801.md) completes, the `fileContent` variable gets the contents of the file as a text string. You can then process the contents as appropriate.

```csharp
try
{
    if (file != null)
    {
        string fileContent = await PathIO.ReadTextAsync(filePathOrURI);
    }
}
// Handle errors with catch blocks
catch (FileNotFoundException)
{
    // For example, handle file not found
}
```

For more, related examples, see [File Access sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FileAccess) and [FileIO](fileio.md).

## -see-also
[File Access sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FileAccess), [FileIO](fileio.md)