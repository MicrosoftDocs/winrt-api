---
-api-id: T:Windows.Storage.StreamedFileDataRequestedHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void StreamedFileDataRequestedHandler(Windows.Storage.StreamedFileDataRequest stream)
-->
# Windows.Storage.StreamedFileDataRequestedHandler

## -description
Represents the method that will stream data into a [StorageFile](storagefile.md) when that file is first accessed.

## -parameters
### -param stream
The request for the streamed data in the [StorageFile](storagefile.md) that was created by the [CreateStreamedFileAsync](storagefile_createstreamedfileasync_1143300277.md) or [ReplaceWithStreamedFileAsync](storagefile_replacewithstreamedfileasync_1583738949.md) method.


## -remarks
The instance of the delegate that you create will produce the data stream for the [StorageFile](storagefile.md) that was returned by the [CreateStreamedFileAsync](storagefile_createstreamedfileasync_1143300277.md) or [ReplaceWithStreamedFileAsync](storagefile_replacewithstreamedfileasync_1583738949.md) method.

When you use the [CreateStreamedFileAsync](storagefile_createstreamedfileasync_1143300277.md) or [ReplaceWithStreamedFileAsync](storagefile_replacewithstreamedfileasync_1583738949.md) method together with an instance of StreamedFileDataRequestedHandler, you can provide the data for a file on demand instead of writing the contents of a file when you create it. That is, you can defer expensive operations to produce the data for the file until the file is first accessed.

## -examples
The following simple example demonstrates how to create an instance of the StreamedFileDataRequestedHandler delegate. The example also shows how this instance produces the data stream for the [StorageFile](storagefile.md) that was returned by the [CreateStreamedFileAsync](storagefile_createstreamedfileasync_1143300277.md) when the file is first accessed.

This simple example is intended only to demonstrate the programming pattern for using the StreamedFileDataRequestedHandler delegate. For a small file with data that's easy to produce, the streaming pattern is not useful.

```csharp
using Windows.Storage;
using Windows.Storage.Streams;

private async void CreateStreamedFile()
{
    // Create a streamed file.
    StorageFile file =
    await StorageFile.CreateStreamedFileAsync("file.txt",
        StreamedFileWriter, null);

    // Prepare to copy the file.
    StorageFolder localFolder = ApplicationData.Current.LocalFolder;
    string newName = "copied_file.txt";

    // Copy the streamed file. At this point,
    // the data is streamed into the source file.
    await file.CopyAsync(localFolder, newName,
        NameCollisionOption.ReplaceExisting);
}

private async void StreamedFileWriter(StreamedFileDataRequest request)
{
    try
    {
        using (var stream = request.AsStreamForWrite())
        using (var streamWriter = new StreamWriter(stream))
        {
            for (int l = 0; l < 50; l++)
            {
                await streamWriter.WriteLineAsync("Data.");
            }
        }
        request.Dispose();
    }
    catch (Exception ex)
    {
        request.FailAndClose(StreamedFileFailureMode.Incomplete);
    }
}
```



## -see-also
