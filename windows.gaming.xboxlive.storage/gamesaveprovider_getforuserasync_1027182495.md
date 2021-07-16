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

Type: [User](../windows.system/user.md)

User who the game saves are for.

### -param serviceConfigId

Type: **String** \[JavaScript\] | [System.String](/dotnet/api/system.string?view=dotnet-uwp-10.0&preserve-view=true) \[.NET\] | [Platform::String](/cpp/cppcx/platform-string-class) \[C++\]

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
