---
-api-id: P:Windows.Gaming.XboxLive.Storage.GameSaveProviderGetResult.Status
-api-type: winrt property
---

<!-- Property syntax
public Windows.Gaming.XboxLive.Storage.GameSaveErrorStatus Status { get; }
-->

# Windows.Gaming.XboxLive.Storage.GameSaveProviderGetResult.Status

## -description

Status result of the asynchronous game save provider request.

## -property-value

Type: [GameSaveErrorStatus](gamesaveerrorstatus.md)

[GameSaveErrorStatus](gamesaveerrorstatus.md) containing the status result of the asynchronous game save provider request.

## -remarks

If **Status** is [GameSaveErrorStatus.Ok](gamesaveerrorstatus.md), the operation completed successfully and [GameSaveProviderGetResult.Value](gamesaveprovidergetresult_value.md) is valid.

## -examples

## -see-also

[GameSaveProviderGetResult](gamesaveprovidergetresult.md)
