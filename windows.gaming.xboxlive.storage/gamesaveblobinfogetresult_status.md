---
-api-id: P:Windows.Gaming.XboxLive.Storage.GameSaveBlobInfoGetResult.Status
-api-type: winrt property
---

<!-- Property syntax
public Windows.Gaming.XboxLive.Storage.GameSaveErrorStatus Status { get; }
-->

# Windows.Gaming.XboxLive.Storage.GameSaveBlobInfoGetResult.Status

## -description

Status result of the asynchronous game save blob info request.

## -property-value

Type: [GameSaveErrorStatus](gamesaveerrorstatus.md)

[GameSaveErrorStatus](gamesaveerrorstatus.md) containing the status result of the asynchronous game save blob info request.

## -remarks

If **Status** is [GameSaveErrorStatus.Ok](gamesaveerrorstatus.md), the operation completed successfully and [GameSaveBlobInfoGetResult.Value](gamesaveblobinfogetresult_value.md) is valid.

## -examples

## -see-also

[GameSaveBlobInfoGetResult](gamesaveblobinfogetresult.md)