---
-api-id: T:Windows.System.FolderLauncherOptions
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class FolderLauncherOptions : Windows.System.IFolderLauncherOptions, Windows.System.ILauncherViewOptions
-->

# Windows.System.FolderLauncherOptions

## -description
Specifies the options to use when launching File Explorer to display the contents of a specific folder by calling the [LaunchFolderAsync(IStorageFolder, FolderLauncherOptions)](launcher_launchfolderasync_1551340761.md) method.

In a desktop app, before using an instance of this class in a way that displays UI, you'll need to associate the object with its owner's window handle. For more info, and code examples, see [Display WinRT UI objects that depend on CoreWindow](/windows/apps/develop/ui-input/display-ui-objects#winui-3-with-c).

## -remarks

## -examples

## -see-also
[ILauncherViewOptions](ilauncherviewoptions.md)