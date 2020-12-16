---
-api-id: M:Windows.Gaming.XboxLive.Storage.GameSaveProvider.DeleteContainerAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Gaming.XboxLive.Storage.GameSaveOperationResult> DeleteContainerAsync(System.String name)
-->

# Windows.Gaming.XboxLive.Storage.GameSaveProvider.DeleteContainerAsync

## -description

Asynchronously deletes the specified game save container.

## -parameters
### -param name

Type: **String** \[JavaScript\] | [System.String](/dotnet/api/system.string?view=dotnet-uwp-10.0&preserve-view=true) \[.NET\] | [Platform::String](/cpp/cppcx/platform-string-class) \[C++\]

String name of the container to delete.

## -returns

Type: **IAsyncOperation\<;GameSaveOperationResult>;**

**IAsyncOperation\<;GameSaveOperationResult>;** that represents the state of the asynchronous operation.

## -remarks

After the asynchronous operation completes, check the [Status](gamesaveoperationresult_status.md) property of the result to determine whether the operation succeeded with [GameSaveErrorStatus.Ok](gamesaveerrorstatus.md).

## -examples

## -see-also

[GameSaveProvider](gamesaveprovider.md)