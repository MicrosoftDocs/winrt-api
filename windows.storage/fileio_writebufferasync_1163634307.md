---
-api-id: M:Windows.Storage.FileIO.WriteBufferAsync(Windows.Storage.IStorageFile,Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction WriteBufferAsync(Windows.Storage.IStorageFile file, Windows.Storage.Streams.IBuffer buffer)
-->

# Windows.Storage.FileIO.WriteBufferAsync

## -description
Writes data from a buffer to the specified file.

## -parameters
### -param file
The file that the buffer of data is written to.

### -param buffer
The buffer that contains the data to write.

## -returns
No object or value is returned when this method completes.

## -remarks

## -examples
The [File Access sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FileAccess) shows you how to use `WriteBufferAsync` to write data from a buffer to a file.

```csharp

try
{
    if (file != null)
    {
        IBuffer buffer = CryptographicBuffer.GenerateRandom(10);
        await FileIO.WriteBufferAsync(file, buffer);
        // Perform additional tasks after file is written
    }
}
// Handle errors with catch blocks
catch (FileNotFoundException)
{
    // For example, handle file not found
}
```

In the example, `file` is a local variable that contains a [StorageFile](storagefile.md) that represents the file to write.

Although the `WriteBufferAsync` methods don't have a return value, you can still perform additional tasks after the text is written to the file, as the example shows.

## -see-also
