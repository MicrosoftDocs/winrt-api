---
-api-id: M:Windows.Gaming.XboxLive.Storage.GameSaveContainer.SubmitUpdatesAsync(Windows.Foundation.Collections.IMapView{System.String,Windows.Storage.Streams.IBuffer},Windows.Foundation.Collections.IIterable{System.String},System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Gaming.XboxLive.Storage.GameSaveOperationResult> SubmitUpdatesAsync(Windows.Foundation.Collections.IMapView<System.String, Windows.Storage.Streams.IBuffer> blobsToWrite, Windows.Foundation.Collections.IIterable<System.String> blobsToDelete, System.String displayName)
-->

# Windows.Gaming.XboxLive.Storage.GameSaveContainer.SubmitUpdatesAsync

## -description

Submits a set of changes to the game save blobs in this container. Changes can be writes to blobs or the deletion of existing blobs. If the container doesn't exist, then a new one is created. All writes and updates are applied atomically. Attempting to write and delete the same blob results in an error. Only 16MB of data may be written per call.

## -parameters
### -param blobsToWrite

Type: **IMapView\<;String, IBuffer>;** \[JavaScript/C++\] | [System.Collections.Generic.IReadOnlyDictionary\<;String, IBuffer>;](/dotnet/api/system.collections.generic.ireadonlydictionary-2?view=dotnet-uwp-10.0&preserve-view=true) \[.NET\]

Collection of blob names and the data to write for each blob. The max length for a blob name is 63 characters.

### -param blobsToDelete

Type: **IIterable\<;String>;** \[JavaScript/C++\] | [System.Collections.Generic.IEnumerable\<;String>;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) \[.NET\]

Collection containing the string names of blobs to delete. The max length for a blob name is 63 characters.

### -param displayName

Type: **String** \[JavaScript\] | [System.String](/dotnet/api/system.string?view=dotnet-uwp-10.0&preserve-view=true) \[.NET\] | [Platform::String](/cpp/cppcx/platform-string-class) \[C++\]

The save game container's display name. Set this to the name that will be displayed for the game save. The max length for the display name is 127 characters.

## -returns

Type: **IAsyncOperation\<;GameSaveOperationResult>;**

**IAsyncOperation\<;GameSaveOperationResult>;** that represents the state of the asynchronous operation.

## -remarks

After the asynchronous operation completes, check the [Status](gamesaveoperationresult_status.md) property of the result to determine whether the operation succeeded with [GameSaveErrorStatus.Ok](gamesaveerrorstatus.md).

Each TitleID/SCID is limited to a total of 256MB of storage per user.

When a title has reached its storage limit for a user, calls to **SubmitUpdatesAsync** will fail.

If a blob name or the display name exceeds the max length, the game save will fail to upload.

**SubmitUpdatesAsync** calls must not assume that a future **SubmitUpdatesAsync** call will be completed successfully in order to leave the container in a valid state. Each **SubmitUpdatesAsync** call must leave the contents of the specified container in a valid state for the app to read later. For example, if a player purchases food with gold in a game, the new values for the gold and food should be updated in the same call to **SubmitUpdatesAsync**. This ensures that both values will be updated at the same time or in the event of a power failure or some other event preventing the update, both food and gold will still have their original values.

## -examples

## -see-also

[GameSaveContainer](gamesavecontainer.md)