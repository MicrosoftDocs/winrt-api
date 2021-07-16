---
-api-id: M:Windows.Gaming.XboxLive.Storage.GameSaveProvider.GetSyncOnDemandForUserAsync(Windows.System.User,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Gaming.XboxLive.Storage.GameSaveProviderGetResult> GetSyncOnDemandForUserAsync(Windows.System.User user, System.String serviceConfigId)
-->

# Windows.Gaming.XboxLive.Storage.GameSaveProvider.GetSyncOnDemandForUserAsync

## -description

Gets a partially-synced game save provider that syncs containers on demand.

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

A sync-on-demand provider is not guaranteed to have all containers synced locally. A sync is required when there is a conflict the user must resolve, or, more commonly, when the container has newer data in the cloud that must be downloaded. This condition is indicated by [GameSaveContainerInfo.NeedsSync](gamesavecontainerinfo_needssync.md).

Calls to read, delete, or query blobs from a container will sync the container if it needs to sync.

Attempts to submit updates to a container will fail (with [GameSaveErrorStatus.ContainerNotInSync](gamesaveerrorstatus.md)) while the container still needs to sync.

**GetSyncOnDemandForUserAsync** obtains a [GameSaveProvider](gamesaveprovider.md) instance for the specified user. After the asynchronous operation completes, check the [Status](gamesaveprovidergetresult_status.md) property of the result to determine whether the operation succeeded with [GameSaveErrorStatus.Ok](gamesaveerrorstatus.md).

Your title ID and service configuration ID (SCID) must be properly configured or this method will fail.

## -examples

## -see-also

[GameSaveProvider](gamesaveprovider.md)
