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

## -remarks

To use an object of this class in a desktop app, cast it to the [IInitializeWithWindow](/windows/win32/api/shobjidl_core/nn-shobjidl_core-iinitializewithwindow) interface, and pass an owner window's handle to the [Initialize](/windows/win32/api/shobjidl_core/nf-shobjidl_core-iinitializewithwindow-initialize) method. For more info, and code examples, see [Display WinRT UI objects that depend on CoreWindow](/windows/apps/develop/ui-input/display-ui-objects).

To get started accessing files and folders with a picker, see [Open files and folders with a picker](/windows/uwp/files/quickstart-using-file-and-folder-pickers).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1903 | 18362 | CreateForUser |
| 1903 | 18362 | User |

## -examples

## -see-also

[File picker sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FilePicker), [Display WinRT UI objects that depend on CoreWindow](/windows/apps/develop/ui-input/display-ui-objects)

