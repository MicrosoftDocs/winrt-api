---
-api-id: T:Windows.Gaming.XboxLive.Storage.GameSaveBlobGetResult
-api-type: winrt class
---

<!-- Class syntax.
public class GameSaveBlobGetResult : Windows.Gaming.XboxLive.Storage.IGameSaveBlobGetResult
-->

# Windows.Gaming.XboxLive.Storage.GameSaveBlobGetResult

## -description
A collection of named game save blobs retrieved from a [GameSaveContainer](gamesavecontainer.md).

## -remarks
**GameSaveBlobGetResult** is returned when [GameSaveContainer.GetAsync](gamesavecontainer_getasync_465620582.md) completes, and contains the result of the asynchronous operation. If the operation completed with no errors, [GameSaveBlobGetResult.Value](gamesaveblobgetresult_value.md) contains the game save data.

> [!IMPORTANT]
> This API is targeted towards UWP games and apps with Xbox Live Enabled. Calls to these APIs made from sources that are not Xbox Live enabled will not be able to sync data to the cloud.

## -examples

## -see-also
[Object](/dotnet/api/system.object?view=dotnet-uwp-10.0&preserve-view=true)