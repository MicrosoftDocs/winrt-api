---
-api-id: T:Windows.Storage.Pickers.FileSavePicker
-api-type: winrt class
---

<!-- Class syntax.
public class FileSavePicker : Windows.Storage.Pickers.IFileSavePicker, Windows.Storage.Pickers.IFileSavePicker2, Windows.Storage.Pickers.IFileSavePicker3
-->

# Windows.Storage.Pickers.FileSavePicker

## -description

Represents a file picker that lets the user choose the file name, extension, and storage location for a file.

In a desktop app, before using an instance of this class in a way that displays UI, you'll need to associate the object with its owner's window handle. For more info, and code examples, see [Display WinRT UI objects that depend on CoreWindow](/windows/apps/develop/ui-input/display-ui-objects#winui-3-with-c).

## -remarks

> [!IMPORTANT]
> You must use the [FileTypeChoices property](filesavepicker_filetypechoices.md) property to specify one or more file types before you call the PickSaveFileAsync method, or the picker will thrown an exception. 

To learn how to save files through the file picker, see [How to save files through file pickers](/windows/uwp/files/quickstart-save-a-file-with-a-picker).

To get started accessing files and folders file picker, see [Files, folders, and libraries ](/windows/uwp/files/index).

> [!WARNING]
> If you try to show the file picker while your app is snapped, the file picker will not be shown and an exception will be thrown. You can avoid this by making sure your app is not snapped or by unsnapping it before you call the file picker. The following code examples and the [File picker sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePicker) show you how.

### In a desktop app that requires elevation

In a desktop app (which includes WinUI 3 apps), you can use **FileSavePicker** (and other types from **Windows.Storage.Pickers**). But if the desktop app requires elevation to run, then you'll need a different approach (that's because these APIs aren't designed to be used in an elevated app). The code snippet below illustrates how you can use the [C#/Win32 P/Invoke Source Generator](https://github.com/microsoft/CsWin32) (CsWin32) to call the Win32 picking APIs instead. To learn how to use CsWin32, follow that link for the documentation.

```csharp
// NativeMethods.txt
CoCreateInstance
FileSaveDialog
IFileSaveDialog
SHCreateItemFromParsingName

// MainWindow.xaml
...
<TextBlock x:Name="OutputTextBlock"/>
...

// MainWindow.xaml.cs
using Microsoft.UI.Xaml;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.System.Com;
using Windows.Win32.UI.Shell;
using Windows.Win32.UI.Shell.Common;

namespace FileSavePickerExample
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private unsafe void myButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Retrieve the window handle (HWND) of the main WinUI 3 window.
                var hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);

                int hr = PInvoke.CoCreateInstance<IFileSaveDialog>(
                    typeof(FileSaveDialog).GUID,
                    null,
                    CLSCTX.CLSCTX_INPROC_SERVER,
                    out var fsd);
                if (hr < 0)
                {
                    Marshal.ThrowExceptionForHR(hr);
                }

                // Set file type filters.
                string filter = "Word Documents|*.docx|JPEG Files|*.jpg";

                List<COMDLG_FILTERSPEC> extensions = new List<COMDLG_FILTERSPEC>();

                if (!string.IsNullOrEmpty(filter))
                {
                    string[] tokens = filter.Split('|');
                    if (0 == tokens.Length % 2)
                    {
                        // All even numbered tokens should be labels.
                        // Odd numbered tokens are the associated extensions.
                        for (int i = 1; i < tokens.Length; i += 2)
                        {
                            COMDLG_FILTERSPEC extension;

                            extension.pszSpec = (char*)Marshal.StringToHGlobalUni(tokens[i]);
                            extension.pszName = (char*)Marshal.StringToHGlobalUni(tokens[i - 1]);
                            extensions.Add(extension);
                        }
                    }
                }

                fsd.SetFileTypes(extensions.ToArray());

                // Set the default folder.
                hr = PInvoke.SHCreateItemFromParsingName(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    null,
                    typeof(IShellItem).GUID,
                    out var directoryShellItem);
                if (hr < 0)
                {
                    Marshal.ThrowExceptionForHR(hr);
                }

                fsd.SetFolder((IShellItem)directoryShellItem);
                fsd.SetDefaultFolder((IShellItem)directoryShellItem);

                // Set the default file name.
                fsd.SetFileName($"{DateTime.Now:yyyyMMddHHmm}");

                // Set the default extension.
                fsd.SetDefaultExtension(".docx");

                fsd.Show(new HWND(hWnd));

                fsd.GetResult(out var ppsi);

                PWSTR filename;
                ppsi.GetDisplayName(SIGDN.SIGDN_FILESYSPATH, &filename);

                OutputTextBlock.Text = filename.ToString();
            }
            catch (Exception ex)
            {
                OutputTextBlock.Text = "a problem occured: " + ex.Message;
            }
        }
    }
}
```

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1903 | 18362 | CreateForUser |
| 1903 | 18362 | User |

## -examples

The [File picker sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FilePicker) is available in C# and C++/WinRT versions. It demonstrates how to check whether the app is snapped, how to set file picker properties, and how to show a file picker so that the user can save a file.

Here's an excerpt from the C# version of the sample app.

[!code-csharp[all_savepicker_checksnapped_show](../windows.storage.pickers/code/FilePicker/CS/Scenario4.xaml.cs#Snippetall_savepicker_checksnapped_show)]

## -see-also

[File picker sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FilePicker), [Files, folders, and libraries](/windows/uwp/files/index), [How to save files with a file picker](/windows/uwp/files/quickstart-save-a-file-with-a-picker),  [Windows.Storage.StorageFile class](../windows.storage/storagefile.md), [Display WinRT UI objects that depend on CoreWindow](/windows/apps/develop/ui-input/display-ui-objects)
