---
-api-id: M:Windows.Gaming.XboxLive.Storage.GameSaveBlobInfoQuery.GetBlobInfoAsync(System.UInt32,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Gaming.XboxLive.Storage.GameSaveBlobInfoGetResult> GetBlobInfoAsync(System.UInt32 startIndex, System.UInt32 maxNumberOfItems)
-->

# Windows.Gaming.XboxLive.Storage.GameSaveBlobInfoQuery.GetBlobInfoAsync

## -description

Asynchronously retrieves information for the specified subset of blobs that match this query.

## -parameters
### -param startIndex

Type: **Number** \[JavaScript\] | [System.UInt32](/dotnet/api/system.uint32?view=dotnet-uwp-10.0&preserve-view=true) \[.NET\] | **uint32** \[C++\]

Index of the first item to return.

### -param maxNumberOfItems

Type: **Number** \[JavaScript\] | [System.UInt32](/dotnet/api/system.uint32?view=dotnet-uwp-10.0&preserve-view=true) \[.NET\] | **uint32** \[C++\]

Maximum number of items to return.

## -returns

Type: **IAsyncOperation\<;GameSaveBlobInfoGetResult>;**

**IAsyncOperation\<;GameSaveBlobInfoGetResult>;** that represents the state of the asynchronous operation.

## -remarks

After the asynchronous operation completes, check the [Status](gamesaveblobinfogetresult_status.md) property of the result to determine whether the operation succeeded with [GameSaveErrorStatus.Ok](gamesaveerrorstatus.md).

## -examples

## -see-also

[GameSaveBlobInfoQuery](gamesaveblobinfoquery.md),
[GetBlobInfoAsync](gamesaveblobinfoquery_getblobinfoasync_517889704.md)