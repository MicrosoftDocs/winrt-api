---
-api-id: T:Windows.Gaming.XboxLive.Storage.GameSaveContainerInfoGetResult
-api-type: winrt class
---

<!-- Class syntax.
public class GameSaveContainerInfoGetResult : Windows.Gaming.XboxLive.Storage.IGameSaveContainerInfoGetResult
-->

# Windows.Gaming.XboxLive.Storage.GameSaveContainerInfoGetResult

## -description

Result of a [GameSaveContainerInfoQuery](gamesavecontainerinfoquery.md) operation.

## -remarks

**GameSaveContainerInfoGetResult** is returned when [GameSaveContainerInfoQuery.GetContainerInfoAsync](gamesavecontainerinfoquery_getcontainerinfoasync_1018947810.md) completes, and contains the result of the asynchronous operation. If the operation completed with no errors, [GameSaveContainerInfoGetResult.Value](gamesavecontainerinfogetresult_value.md) has the container info.

> [!IMPORTANT]
> This API is targeted towards UWP games and apps with Xbox Live Enabled. Calls to these APIs made from sources that are not Xbox Live enabled will not be able to sync data to the cloud.

## -examples

## -see-also

[Object](/dotnet/api/system.object?view=dotnet-uwp-10.0&preserve-view=true)