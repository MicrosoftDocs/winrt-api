---
-api-id: N:Windows.Storage.Pickers
-api-type: winrt namespace
---

# Windows.Storage.Pickers

## -description

The **Windows.Storage.Pickers** namespace contains classes that create file and folder picker dialogs. Use these classes to let users browse, select files to open, and choose where to save files with specific names and extensions.

## -remarks

The file and folder picker APIs (Windows.Storage.Pickers) in the Windows SDK don't work when apps run as administrator (elevated mode). To address this gap, the [Microsoft.Windows.Storage.Pickers](/windows/windows-app-sdk/api/winrt/microsoft.windows.storage.pickers) APIs are added to the Windows App SDK and support file and folder selection in elevated mode. It's designed for desktop apps and uses a WindowId property to link the picker to its host window.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Open files and folders with a picker](/windows/uwp/files/quickstart-using-file-and-folder-pickers).

> [!div class="nextstepaction"]
> [Open the WinUI 3 Gallery app and see file picker features in action](winui3gallery://item/FilePicker).

> The **WinUI 3 Gallery** app includes interactive examples of most WinUI 3 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9P3JFPWWDZRC) or get the source code on [GitHub](https://github.com/microsoft/WinUI-Gallery)

## -see-also

[HomeGroup sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/HomeGroup), [File picker sample (Windows 10)](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePicker), [Basic face detection sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620512), [File picker contracts sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePickerContracts), [Blobs sample](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/MsBlobBuilder), [Microsoft.Windows.Storage.Pickers](/windows/windows-app-sdk/api/winrt/microsoft.windows.storage.pickers)
