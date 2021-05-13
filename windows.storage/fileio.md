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

To learn more about what locations your app can access, see [File access permissions](/windows/uwp/files/file-access-permissions).

To learn how to read and write to files, see [Create, write, and read a file](/windows/uwp/files/quickstart-reading-and-writing-files).

## -examples

The [File Access sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FileAccess) shows you how to use [WriteTextAsync(file, contents)](fileio_writetextasync_1850452055.md) to write text to a file.

```csharp
try
{
    if (file != null)
    {
        await FileIO.WriteTextAsync(file, "Swift as a shadow");
    }
}
catch (FileNotFoundException)
{
    // For example, handle file not found
}
```

```cppwinrt
try
{
    if (file)
    {
        co_await FileIO::WriteTextAsync(file, L"Swift as a shadow");
    }
}
catch (hresult_error const& ex)
{
    if (ex.code() == HRESULT_FROM_WIN32(ERROR_FILE_NOT_FOUND))
    {
        // For example, handle file not found
    }
}
```

In the example, `file` is a local variable that contains a [StorageFile](storagefile.md) that represents the file to write.

Although the [WriteTextAsync](fileio_writetextasync_1850452055.md) methods don't have a return value, you can still perform additional tasks after the text is written to the file, as the example shows.The [File Access sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FileAccess) also shows you how to use [ReadTextAsync(file)](fileio_readtextasync_784288594.md) to read text from a file.

```csharp
try
{
    if (file != null)
    {
        string fileContent = await FileIO.ReadTextAsync(file);
    }
}
catch (FileNotFoundException)
{
    // For example, handle file not found
}
```

```cppwinrt
try
{
    if (file)
    {
        hstring fileContent = co_await FileIO::ReadTextAsync(file);
    }
}
catch (hresult_error const& ex)
{
    if (ex.code() == HRESULT_FROM_WIN32(ERROR_FILE_NOT_FOUND))
    {
        // For example, handle file not found
    }
}
```

In the example, `file` is a local variable that contains a [StorageFile](storagefile.md) that represents the file to read.

After [ReadTextAsync](fileio_readtextasync_1063800.md) completes, the `fileContent` variable gets the contents of the file as a text string. You can then process the contents as appropriate.

## -see-also
