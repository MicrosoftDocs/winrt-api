---
-api-id: T:Windows.Gaming.XboxLive.Storage.GameSaveBlobInfoGetResult
-api-type: winrt class
---

<!-- Class syntax.
public class GameSaveBlobInfoGetResult : Windows.Gaming.XboxLive.Storage.IGameSaveBlobInfoGetResult
-->

# Windows.Gaming.XboxLive.Storage.GameSaveBlobInfoGetResult

## -description

Result of a [GameSaveBlobInfoQuery.GetBlobInfoAsync](gamesaveblobinfoquery_getblobinfoasync_517889704.md) operation.

## -remarks

GameSaveBlobInfoGetResult is returned when [GameSaveBlobInfoQuery.GetBlobInfoAsync](gamesaveblobinfoquery_getblobinfoasync_517889704.md) completes, and contains the result of the asynchronous operation. If the operation completed with no errors, [GameSaveBlobInfoGetResult.Value](gamesaveblobinfogetresult_value.md) contains the blob info.

> [!IMPORTANT]
> This API is targeted towards UWP games and apps with Xbox Live Enabled. Calls to these APIs made from sources that are not Xbox Live enabled will not be able to sync data to the cloud.

## -examples

## -see-also

[Object](/dotnet/api/system.object?view=dotnet-uwp-10.0&preserve-view=true)