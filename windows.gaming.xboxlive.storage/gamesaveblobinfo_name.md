---
-api-id: P:Windows.Gaming.XboxLive.Storage.GameSaveBlobInfo.Name
-api-type: winrt property
---

<!-- Property syntax
public string Name { get; }
-->

# Windows.Gaming.XboxLive.Storage.GameSaveBlobInfo.Name

## -description

Name of the blob.

## -property-value

Type: **String** \[JavaScript\] | [System.String](/dotnet/api/system.string?view=dotnet-uwp-10.0&preserve-view=true) \[.NET\] | [Platform::String](/cpp/cppcx/platform-string-class) \[C++\]

## -remarks

Blob names are used when writing blobs with [SubmitUpdatesAsync](gamesavecontainer_submitupdatesasync_1002100950.md) or [SubmitPropertySetUpdatesAsync](gamesavecontainer_submitpropertysetupdatesasync_435712146.md), to request blobs when calling [GameSaveContainer.GetAsync](gamesavecontainer_getasync_465620582.md) and [GameSaveContainer.ReadAsync](gamesavecontainer_readasync_130997576.md), to request blob info when calling [GameSaveContainer.CreateBlobInfoQuery](gamesavecontainer_createblobinfoquery_1392439372.md), and to identify blobs returned in [GameSaveBlobGetResult.Value](gamesaveblobgetresult_value.md).

## -examples

## -see-also
[GameSaveBlobInfo](gamesaveblobinfo.md)