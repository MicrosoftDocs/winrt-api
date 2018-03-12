---
-api-id: P:Windows.Gaming.XboxLive.Storage.GameSaveContainerInfoGetResult.Status
-api-type: winrt property
---

<!-- Property syntax
public Windows.Gaming.XboxLive.Storage.GameSaveErrorStatus Status { get; }
-->

# Windows.Gaming.XboxLive.Storage.GameSaveContainerInfoGetResult.Status

## -description

Status result of the asynchronous game save container info request.

## -property-value

Type: [GameSaveErrorStatus](gamesaveerrorstatus.md)

[GameSaveErrorStatus](gamesaveerrorstatus.md) containing the status result of the asynchronous game save container info request.

## -remarks

If **Status** is [GameSaveErrorStatus.Ok](gamesaveerrorstatus.md), the operation completed successfully and [GameSaveContainerInfoGetResult.Value](gamesavecontainerinfogetresult_value.md) is valid.

## -examples

## -see-also

[GameSaveContainerInfoGetResult](gamesavecontainerinfogetresult.md)
