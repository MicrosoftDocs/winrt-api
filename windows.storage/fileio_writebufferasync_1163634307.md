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
The [File Access sample]( http://go.microsoft.com/fwlink/p/?linkid=231445) shows you how to use [WriteBufferAsync](fileio_writebufferasync.md) to write data from a buffer to a file.

```csharp

try
{
    if (file != null)
    {
        IBuffer buffer = GetBufferFromString("Swift as a shadow");
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

```javascript

if (file !== null) {
    // Create buffer
    var memoryStream = new Windows.Storage.Streams.InMemoryRandomAccessStream();
    var dataWriter = new Windows.Storage.Streams.DataWriter(memoryStream);
    dataWriter.writeString("Swift as a shadow");
    var buffer = dataWriter.detachBuffer();
    dataWriter.close();

    // Write buffer to file
    Windows.Storage.FileIO.writeBufferAsync(file, buffer).done(function () {
        // Perform additional tasks after file is written
    },
    // Handle errors with an error function
    function (error) {
        // Handle errors encountered during write
    });
}
```

In the example, `file` is a local variable that contains a [storageFile](storagefile.md) that represents the file to write.

Although the [writeBufferAsync](fileio_writebufferasync.md) methods don't have a return value, you can still perform additional tasks after the text is written to the file, as the example shows.

## -see-also
