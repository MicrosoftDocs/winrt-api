---
-api-id: M:Windows.Gaming.XboxLive.Storage.GameSaveProvider.GetForUserAsync(Windows.System.User,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Gaming.XboxLive.Storage.GameSaveProviderGetResult> GetForUserAsync(Windows.System.User user, System.String serviceConfigId)
-->

# Windows.Gaming.XboxLive.Storage.GameSaveProvider.GetForUserAsync

## -description

Gets a game save provider for the specified user.

## -parameters
### -param user

Type: [User](w_sys.user)

User who the game saves are for.

### -param serviceConfigId

Type: **String** \[JavaScript\] | [System.String](https://msdn.microsoft.com/library/system.string.aspx) \[.NET\] | [Platform::String](https://msdn.microsoft.com/library/windows/apps/hh755812.aspx) \[C++\]

The service configuration ID (SCID) used by your game.

## -returns

Type: **IAsyncOperation\<;GameSaveProviderGetResult>;**

**IAsyncOperation\<;GameSaveProviderGetResult>;** that represents the state of the asynchronous operation.

## -remarks

GetForUserAsync obtains a [GameSaveProvider](gamesaveprovider.md) instance for the specified user. After the asynchronous operation completes, check the [Status](gamesaveprovidergetresult_status.md) property of the result to determine whether the operation succeeded with [GameSaveErrorStatus.Ok](gamesaveerrorstatus.md).

Your title ID and service configuration ID (SCID) must be properly configured or this method will fail.

## -examples

## -see-also

[GameSaveProvider](gamesaveprovider.md)