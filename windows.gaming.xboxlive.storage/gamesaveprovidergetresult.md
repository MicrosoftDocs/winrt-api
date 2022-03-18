---
-api-id: T:Windows.Gaming.XboxLive.Storage.GameSaveProviderGetResult
-api-type: winrt class
---

<!-- Class syntax.
public class GameSaveProviderGetResult : Windows.Gaming.XboxLive.Storage.IGameSaveProviderGetResult
-->

# Windows.Gaming.XboxLive.Storage.GameSaveProviderGetResult

## -description

Result of a [GetForUserAsync](gamesaveprovider_getforuserasync_1027182495.md) or [GetSyncOnDemandForUserAsync](gamesaveprovider_getsyncondemandforuserasync_1696921570.md). operation.

## -remarks

**GameSaveProviderGetResult** is returned when [GetForUserAsync](gamesaveprovider_getforuserasync_1027182495.md) or [GetSyncOnDemandForUserAsync](gamesaveprovider_getsyncondemandforuserasync_1696921570.md). completes, and contains the result of the asynchronous operation. If the operation completed with no errors, [GameSaveProviderGetResult.Value](gamesaveprovidergetresult_value.md) contains the game save provider.

> [!IMPORTANT]
> This API is targeted towards UWP games and apps with Xbox Live Enabled. Calls to these APIs made from sources that are not Xbox Live enabled will not be able to sync data to the cloud.

## -examples

## -see-also

[Object](/dotnet/api/system.object?view=dotnet-uwp-10.0&preserve-view=true)