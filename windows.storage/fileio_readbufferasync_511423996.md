---
-api-id: M:Windows.Storage.FileIO.ReadBufferAsync(Windows.Storage.IStorageFile)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.Streams.IBuffer> ReadBufferAsync(Windows.Storage.IStorageFile file)
-->

# Windows.Storage.FileIO.ReadBufferAsync

## -description
Reads the contents of the specified file and returns a buffer.

## -parameters
### -param file
The file to read.

## -returns
When this method completes, it returns an object (type [IBuffer](../windows.storage.streams/ibuffer.md)) that represents the contents of the file.

## -remarks

## -examples
The [File Access sample]( http://go.microsoft.com/fwlink/p/?linkid=231445) shows you how to use ReadBufferAsync to read the contents of a file and return a buffer, like this:

```csharp

try
{
    if (file != null)
    {
        IBuffer buffer = await FileIO.ReadBufferAsync(file);

        // Use a dataReader object to read from the buffer
        using (DataReader dataReader = DataReader.FromBuffer(buffer))
        {
            string fileContent = dataReader.ReadString(buffer.Length);
            // Perform additional tasks
        }
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
    Windows.Storage.FileIO.readBufferAsync(sampleFile).then(function (buffer) {
        // Perform additional tasks after file is read

        // Use a dataReader object to read from the buffer
        var dataReader = Windows.Storage.Streams.DataReader.fromBuffer(buffer);
        var fileContent = dataReader.readString(buffer.length);
        dataReader.close();
    },
    // Handle errors with an error function
    function (error) {
        // Handle errors encountered during write
    });
}
```

In the example, `file` is a local variable that contains a [storageFile](storagefile.md) that represents the file to read.

After [readTextAsync](fileio_readtextasync_1063800.md) completes, the `buffer` variable gets the contents of the file as an [IBuffer](/previous-versions/hh438362(v=vs.85)) object. You can then read from the buffer using a [dataReader](../windows.storage.streams/datareader.md) object and process the file contents as appropriate (as shown in the example.)

## -see-also
