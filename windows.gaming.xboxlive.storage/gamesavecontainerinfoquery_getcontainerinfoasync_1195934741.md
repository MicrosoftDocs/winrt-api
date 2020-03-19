---
-api-id: M:Windows.Gaming.XboxLive.Storage.GameSaveContainerInfoQuery.GetContainerInfoAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Gaming.XboxLive.Storage.GameSaveContainerInfoGetResult> GetContainerInfoAsync()
-->

# Windows.Gaming.XboxLive.Storage.GameSaveContainerInfoQuery.GetContainerInfoAsync

## -description

Asynchronously retrieves information for all game save containers that match this query. Containers are enumerated in order of the most recently modified first.

## -returns

Type: **IAsyncOperation\<;GameSaveContainerInfoGetResult>;**

**IAsyncOperation\<;GameSaveContainerInfoGetResult>;** that represents the state of the asynchronous operation.

## -remarks

After the asynchronous operation completes, check the [Status](gamesavecontainerinfogetresult_status.md) property of the result to determine whether the operation succeeded with [GameSaveErrorStatus.Ok](gamesaveerrorstatus.md).

## -examples

## -see-also

[GameSaveContainerInfoQuery](gamesavecontainerinfoquery.md),
[GetContainerInfoAsync(UInt32, UInt32)](gamesavecontainerinfoquery_getcontainerinfoasync_1018947810.md)