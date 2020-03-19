---
-api-id: M:Windows.Gaming.XboxLive.Storage.GameSaveBlobInfoQuery.GetBlobInfoAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Gaming.XboxLive.Storage.GameSaveBlobInfoGetResult> GetBlobInfoAsync()
-->

# Windows.Gaming.XboxLive.Storage.GameSaveBlobInfoQuery.GetBlobInfoAsync

## -description

Asynchronously retrieves information for all blobs that match this query.

## -returns

Type: **IAsyncOperation\<;GameSaveBlobInfoGetResult>;**

**IAsyncOperation\<;GameSaveBlobInfoGetResult>;** that represents the state of the asynchronous operation.

## -remarks

After the asynchronous operation completes, check the [Status](gamesaveblobinfogetresult_status.md) property of the result to determine whether the operation succeeded with [GameSaveErrorStatus.Ok](gamesaveerrorstatus.md).

## -examples

## -see-also

[GameSaveBlobInfoQuery](gamesaveblobinfoquery.md),
[GetBlobInfoAsync(UInt32, UInt32)](gamesaveblobinfoquery_getblobinfoasync_1697460829.md)