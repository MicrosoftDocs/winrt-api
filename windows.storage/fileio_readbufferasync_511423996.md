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
The [File Access sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FileAccess) shows you how to use ReadBufferAsync to read the contents of a file and return a buffer, like this:

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

In the example, `file` is a local variable that contains a [StorageFile](storagefile.md) that represents the file to read.

After [ReadTextAsync](fileio_readtextasync_1063800.md) completes, the `buffer` variable gets the contents of the file as an [IBuffer](../windows.storage.streams/ibuffer.md) object. You can then read from the buffer using a [DataReader](../windows.storage.streams/datareader.md) object and process the file contents as appropriate (as shown in the example.)

## -see-also
