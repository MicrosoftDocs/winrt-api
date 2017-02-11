---
-api-id: M:Windows.Phone.System.UserProfile.GameServices.Core.GameService.PostResult(System.UInt32,Windows.Phone.System.UserProfile.GameServices.Core.GameServiceScoreKind,System.Int64,Windows.Phone.System.UserProfile.GameServices.Core.GameServiceGameOutcome,Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public void PostResult(System.UInt32 gameVariant, Windows.Phone.System.UserProfile.GameServices.Core.GameServiceScoreKind scoreKind, System.Int64 scoreValue, Windows.Phone.System.UserProfile.GameServices.Core.GameServiceGameOutcome gameOutcome, Windows.Storage.Streams.IBuffer buffer)
-->

# Windows.Phone.System.UserProfile.GameServices.Core.GameService.PostResult

## -description
Terminate and post the results of a game.

## -parameters
### -param gameVariant
An app-specific game variant identifier.

### -param scoreKind
The kind of score in the result.

### -param scoreValue
The score value in the result.

### -param gameOutcome
The outcome of the game.

### -param buffer
A data buffer to be included with the result.

## -remarks
All members of the Windows.Phone.System.UserProfile.GameServices.Core namespace can only be used by the XBox Live SDK. These APIs cannot be called except by applications that have the ID_CAP_GAMERSERVICES capability.

## -examples

## -see-also
