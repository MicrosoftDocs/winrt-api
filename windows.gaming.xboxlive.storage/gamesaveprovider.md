---
-api-id: T:Windows.Gaming.XboxLive.Storage.GameSaveProvider
-api-type: winrt class
---

<!-- Class syntax.
public class GameSaveProvider : Windows.Gaming.XboxLive.Storage.IGameSaveProvider
-->

# Windows.Gaming.XboxLive.Storage.GameSaveProvider

## -description

**GameSaveProvider** is used to create, save, enumerate, and load Xbox Live game saves.

## -remarks

Call [GetForUserAsync](gamesaveprovider_getforuserasync_1027182495.md) or [GetSyncOnDemandForUserAsync](gamesaveprovider_getsyncondemandforuserasync_1696921570.md) to obtain a **GameSaveProvider** instance.

> [!IMPORTANT]
> This API is targeted towards UWP games and apps with Xbox Live Enabled. Calls to these APIs made from sources that are not Xbox Live enabled will not be able to sync data to the cloud.

## -examples

## -see-also

[Object](/dotnet/api/system.object?view=dotnet-uwp-10.0&preserve-view=true)