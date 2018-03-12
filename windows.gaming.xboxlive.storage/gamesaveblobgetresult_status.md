---
-api-id: P:Windows.Gaming.XboxLive.Storage.GameSaveBlobGetResult.Status
-api-type: winrt property
---

<!-- Property syntax
public Windows.Gaming.XboxLive.Storage.GameSaveErrorStatus Status { get; }
-->

# Windows.Gaming.XboxLive.Storage.GameSaveBlobGetResult.Status

## -description
The status result of the asynchronous game save blob request.

## -property-value
Type: [GameSaveErrorStatus](gamesaveerrorstatus.md)

[GameSaveErrorStatus](gamesaveerrorstatus.md) containing the status result of the asynchronous game save blob request.

## -remarks
If Status is [GameSaveErrorStatus.Ok](gamesaveerrorstatus.md), the operation completed successfully and [GameSaveBlobGetResult.Value](gamesaveblobgetresult_value.md) is valid.

## -examples

## -see-also
[GameSaveBlobGetResult](gamesaveblobgetresult.md)