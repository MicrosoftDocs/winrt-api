---
-api-id: T:Windows.Gaming.XboxLive.Storage.GameSaveBlobInfo
-api-type: winrt class
---

<!-- Class syntax.
public class GameSaveBlobInfo : Windows.Gaming.XboxLive.Storage.IGameSaveBlobInfo
-->

# Windows.Gaming.XboxLive.Storage.GameSaveBlobInfo

## -description

Contains information about a game save blob. Call [GameSaveBlobInfoQuery.GetBlobInfoAsync](gamesaveblobinfoquery_getblobinfoasync_517889704.md) to obtain a **GameSaveBlobInfo** instance.

## -remarks

Call [GameSaveContainer.CreateBlobInfoQuery](gamesavecontainer_createblobinfoquery_1392439372.md) to create a [GameSaveBlobInfoQuery](gamesaveblobinfoquery.md) that contains **GameSaveBlobInfo** instances of the specified blobs.

> [!IMPORTANT]
> This API is targeted towards UWP games and apps with Xbox Live Enabled. Calls to these APIs made from sources that are not Xbox Live enabled will not be able to sync data to the cloud.

## -examples

## -see-also

[Object](/dotnet/api/system.object?view=dotnet-uwp-10.0&preserve-view=true)