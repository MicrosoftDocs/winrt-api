---
-api-id: T:Windows.Storage.Pickers.FolderPicker
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class FolderPicker : Windows.Storage.Pickers.IFolderPicker, Windows.Storage.Pickers.IFolderPicker2
-->

# Windows.Storage.Pickers.FolderPicker

## -description

Represents a UI element that lets the user choose folders.

In a desktop app, before using an instance of this class in a way that displays UI, you'll need to associate the object with its owner's window handle. For more info, and code examples, see [Display WinRT UI objects that depend on CoreWindow](/windows/apps/develop/ui-input/display-ui-objects#winui-3-with-c).

## -remarks

To get started accessing files and folders with a picker, see [Open files and folders with a picker](/windows/uwp/files/quickstart-using-file-and-folder-pickers).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1903 | 18362 | CreateForUser |
| 1903 | 18362 | User |

## -examples

## -see-also

[File picker sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FilePicker), [Display WinRT UI objects that depend on CoreWindow](/windows/apps/develop/ui-input/display-ui-objects)

