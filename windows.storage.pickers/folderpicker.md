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

To get started accessing files and folders with a picker, see [Open files and folders with a picker](/windows/uwp/files/quickstart-using-file-and-folder-pickers).

> [!NOTE]
> To use an instance of this class in a desktop app (.NET or native C++), you must cast the instance to the [IInitializeWithWindow](/windows/win32/api/shobjidl_core/nn-shobjidl_core-iinitializewithwindow) interface and pass the owner window for the operation to the [Initialize](/windows/win32/api/shobjidl_core/nf-shobjidl_core-iinitializewithwindow-initialize) method. For more information, see [Classes that use IInitializeWithWindow](/windows/apps/desktop/modernize/desktop-to-uwp-supported-api#classes-that-use-iinitializewithwindow).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1903 | 18362 | CreateForUser |
| 1903 | 18362 | User |

## -examples

## -see-also

[File picker sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FilePicker), [Classes that use IInitializeWithWindow](/windows/apps/desktop/modernize/desktop-to-uwp-supported-api#classes-that-use-iinitializewithwindow)

