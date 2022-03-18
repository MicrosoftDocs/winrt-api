---
-api-id: M:Windows.Gaming.XboxLive.Storage.GameSaveContainer.ReadAsync(Windows.Foundation.Collections.IMapView{System.String,Windows.Storage.Streams.IBuffer})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Gaming.XboxLive.Storage.GameSaveOperationResult> ReadAsync(Windows.Foundation.Collections.IMapView<System.String, Windows.Storage.Streams.IBuffer> blobsToRead)
-->

# Windows.Gaming.XboxLive.Storage.GameSaveContainer.ReadAsync

## -description

Reads blobs from this container, as specified by *blobsToRead*. The buffers passed in *blobsToRead* must be large enough to store the blob data.

## -parameters
### -param blobsToRead

Type: **IMapView\<;String, IBuffer>;** \[JavaScript/C++\] | [System.Collections.Generic.IReadOnlyDictionary\<;String, IBuffer>;](/dotnet/api/system.collections.generic.ireadonlydictionary-2?view=dotnet-uwp-10.0&preserve-view=true) \[.NET\]

Collection of blob names and data buffers to receive blob data.

## -returns

Type: **IAsyncOperation\<;GameSaveOperationResult>;**

**IAsyncOperation\<;GameSaveOperationResult>;** that represents the state of the asynchronous operation.

## -remarks

Use [GameSaveBlobInfoQuery](gamesaveblobinfoquery.md) to determine the required buffer size for each game save blob requested.

If the operation completes successfully, the length property of the returned buffers specifies the amount of data contained in each buffer.

**ReadAsync** differs from [GetAsync](gamesavecontainer_getasync_465620582.md) in that **GetAsync** automatically allocates the required buffers for the blob data, and returns that data in a [GameSaveBlobGetResult](gamesaveblobgetresult.md) object. **ReadAsync** instead writes directly into the buffers passed in the *blobsToRead* parameter.

After the asynchronous operation completes, check the [Status](gamesaveoperationresult_status.md) property of the result to determine whether the operation succeeded with [GameSaveErrorStatus.Ok](gamesaveerrorstatus.md).

## -examples

## -see-also

[GameSaveContainer](gamesavecontainer.md)
