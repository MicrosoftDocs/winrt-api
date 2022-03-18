---
-api-id: M:Windows.Gaming.XboxLive.Storage.GameSaveContainer.CreateBlobInfoQuery(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Gaming.XboxLive.Storage.GameSaveBlobInfoQuery CreateBlobInfoQuery(System.String blobNamePrefix)
-->

# Windows.Gaming.XboxLive.Storage.GameSaveContainer.CreateBlobInfoQuery

## -description

Creates a [GameSaveBlobInfoQuery](gamesaveblobinfoquery.md) instance that retrieves the game save blobs within this container with names that begin with the specified prefix.

## -parameters
### -param blobNamePrefix

Type: **String** \[JavaScript\] | [System.String](/dotnet/api/system.string?view=dotnet-uwp-10.0&preserve-view=true) \[.NET\] | [Platform::String](/cpp/cppcx/platform-string-class) \[C++\]

String name prefix of the blobs to retrieve.

## -returns

Type: [GameSaveBlobInfoQuery](gamesaveblobinfoquery.md)

[GameSaveBlobInfoQuery](gamesaveblobinfoquery.md) instance that retrieves blobs within this container with names that begin with *blobNamePrefix*.

## -remarks

If *blobNamePrefix* is null or empty the query matches all blobs in the container. Otherwise, it matches the blobs with names that begin with *blobNamePrefix*.

## -examples

## -see-also

[GameSaveContainer](gamesavecontainer.md)