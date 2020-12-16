---
-api-id: M:Windows.Gaming.XboxLive.Storage.GameSaveContainer.GetAsync(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Gaming.XboxLive.Storage.GameSaveBlobGetResult> GetAsync(Windows.Foundation.Collections.IIterable<System.String> blobsToRead)
-->

# Windows.Gaming.XboxLive.Storage.GameSaveContainer.GetAsync

## -description

Asynchronously retrieves blobs from the container.

## -parameters
### -param blobsToRead

Type: **IIterable\<;String>;** \[JavaScript/C++\] | [System.Collections.Generic.IEnumerable\<;String>;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) \[.NET\]

String names of the blobs to read

## -returns

Type: **IAsyncOperation\<;GameSaveBlobGetResult>;**

**IAsyncOperation\<;GameSaveBlobGetResult>;** that represents the state of the asynchronous operation.

## -remarks

GetAsync allocates new buffers to store the returned data.

After the asynchronous operation completes, check the [Status](gamesaveblobgetresult_status.md) property of the result to determine whether the operation succeeded with [GameSaveErrorStatus.Ok](gamesaveerrorstatus.md).

## -examples

## -see-also

[GameSaveContainer](gamesavecontainer.md)
