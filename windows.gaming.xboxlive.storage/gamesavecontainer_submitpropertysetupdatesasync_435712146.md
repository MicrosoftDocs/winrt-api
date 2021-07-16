---
-api-id: M:Windows.Gaming.XboxLive.Storage.GameSaveContainer.SubmitPropertySetUpdatesAsync(Windows.Foundation.Collections.IPropertySet,Windows.Foundation.Collections.IIterable{System.String},System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Gaming.XboxLive.Storage.GameSaveOperationResult> SubmitPropertySetUpdatesAsync(Windows.Foundation.Collections.IPropertySet blobsToWrite, Windows.Foundation.Collections.IIterable<System.String> blobsToDelete, System.String displayName)
-->

# Windows.Gaming.XboxLive.Storage.GameSaveContainer.SubmitPropertySetUpdatesAsync

## -description

Similar to [SubmitUpdatesAsync](gamesavecontainer_submitupdatesasync_1002100950.md), except that this method operates on a **PropertySet** instead of a mapped view (or dictionary in C\#).

## -parameters
### -param blobsToWrite

Type: [IPropertySet](../windows.foundation.collections/ipropertyset.md)

Collection of blob names and the data to write for each blob.

### -param blobsToDelete

Type: **IIterable\<;String>;** \[JavaScript/C++\] | [System.Collections.Generic.IEnumerable\<;String>;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) \[.NET\]

Collection containing the string names of blobs to delete.

### -param displayName

Type: **String** \[JavaScript\] | [System.String](/dotnet/api/system.string?view=dotnet-uwp-10.0&preserve-view=true) \[.NET\] | [Platform::String](/cpp/cppcx/platform-string-class) \[C++\]

The save game container's display name. Set this to the name that will be displayed for the game save.

## -returns

Type: **IAsyncOperation\<;GameSaveOperationResult>;**

**IAsyncOperation\<;GameSaveOperationResult>;** that represents the state of the asynchronous operation.

## -remarks

This method can be called from JavaScript, unlike [SubmitUpdatesAsync](gamesavecontainer_submitupdatesasync_1002100950.md) which requires creating a mapped view (or dictionary in C\#).

*blobsToWrite* is a **PropertySet** that should contain key-value pairs of a blob name and a Windows.Storage.Streams.IBuffer (Windows.Storage.Streams.DataWriter, for example).

After the asynchronous operation completes, check the [Status](gamesaveoperationresult_status.md) property of the result to determine whether the operation succeeded with [GameSaveErrorStatus.Ok](gamesaveerrorstatus.md).

## -examples

## -see-also

[GameSaveContainer](gamesavecontainer.md), [SubmitUpdatesAsync](gamesavecontainer_submitupdatesasync_1002100950.md)
