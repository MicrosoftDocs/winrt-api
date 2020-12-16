---
-api-id: M:Windows.Gaming.XboxLive.Storage.GameSaveProvider.CreateContainer(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Gaming.XboxLive.Storage.GameSaveContainer CreateContainer(System.String name)
-->

# Windows.Gaming.XboxLive.Storage.GameSaveProvider.CreateContainer

## -description

Creates a new [GameSaveContainer](gamesavecontainer.md) to store a game save.

## -parameters
### -param name

Type: **String** \[JavaScript\] | [System.String](/dotnet/api/system.string?view=dotnet-uwp-10.0&preserve-view=true) \[.NET\] | [Platform::String](/cpp/cppcx/platform-string-class) \[C++\]

Name of the new game save container. The maximum length for the container name is 256 characters.

## -returns

Type: [GameSaveContainer](gamesavecontainer.md)

A new, empty, named [GameSaveContainer](gamesavecontainer.md) instance.

## -remarks

Valid characters for the path portion of the container name (up to and including the final forward slash) include uppercase letters (A-Z), lowercase letters (a-z), numbers (0-9), underscore (\_), and forward slash (/). The path portion may be empty.

Valid characters for the filename portion (everything after the final forward slash) include uppercase letters (A-Z), lowercase letters (a-z), numbers (0-9), underscore (\_), period (.), and hyphen (-). The filename may not be empty, end in a period, or contain two consecutive periods.

If *name* is invalid, the operation fails with [GameSaveErrorStatus.InvalidContainerName](gamesaveerrorstatus.md).

The string specified in *name* is used to programmatically refer to the game save, and is not the display name shown to the user.

The returned [GameSaveContainer](gamesavecontainer.md) is empty and contains no game save blobs.

Use [GameSaveContainer.SubmitUpdatesAsync](gamesavecontainer_submitupdatesasync_1002100950.md) to write game save blobs to the container.

## -examples

## -see-also

[GameSaveProvider](gamesaveprovider.md)
