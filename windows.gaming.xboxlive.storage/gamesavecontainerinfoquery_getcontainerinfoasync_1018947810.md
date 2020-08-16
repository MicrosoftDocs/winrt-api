---
-api-id: M:Windows.Gaming.XboxLive.Storage.GameSaveContainerInfoQuery.GetContainerInfoAsync(System.UInt32,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Gaming.XboxLive.Storage.GameSaveContainerInfoGetResult> GetContainerInfoAsync(System.UInt32 startIndex, System.UInt32 maxNumberOfItems)
-->

# Windows.Gaming.XboxLive.Storage.GameSaveContainerInfoQuery.GetContainerInfoAsync

## -description

Asynchronously retrieves information for the specified subset of game save containers that match this query. Containers are enumerated in order of the most recently modified first.

## -parameters
### -param startIndex

Type: **Number** \[JavaScript\] | [System.UInt32](https://docs.microsoft.com/dotnet/api/system.uint32?redirectedfrom=MSDN) \[.NET\] | **uint32** \[C++\]

Index of the first item to return.

### -param maxNumberOfItems

Type: **Number** \[JavaScript\] | [System.UInt32](https://docs.microsoft.com/dotnet/api/system.uint32?redirectedfrom=MSDN) \[.NET\] | **uint32** \[C++\]

Maximum number of items to return.

## -returns

Type: **IAsyncOperation\<;GameSaveContainerInfoGetResult>;**

**IAsyncOperation\<;GameSaveContainerInfoGetResult>;** that represents the state of the asynchronous operation.

## -remarks

After the asynchronous operation completes, check the [Status](gamesavecontainerinfogetresult_status.md) property of the result to determine whether the operation succeeded with [GameSaveErrorStatus.Ok](gamesaveerrorstatus.md).

## -examples

## -see-also

[GameSaveContainerInfoQuery](gamesavecontainerinfoquery.md),
[GetContainerInfoAsync](gamesavecontainerinfoquery_getcontainerinfoasync_1195934741.md)