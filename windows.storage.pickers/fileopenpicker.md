---
-api-id: T:Windows.Storage.Pickers.FileOpenPicker
-api-type: winrt class
---

<!-- Class syntax.
public class FileOpenPicker : Windows.Storage.Pickers.IFileOpenPicker, Windows.Storage.Pickers.IFileOpenPicker2, Windows.Storage.Pickers.IFileOpenPickerWithOperationId
-->

# Windows.Storage.Pickers.FileOpenPicker

## -description
Represents a UI element that lets the user choose and open files.

## -remarks
To get started accessing files and folders file picker, see [Quickstart: Accessing files with ](http://msdn.microsoft.com/library/df082239-381c-462f-9f97-d2b390a2052e).

To learn about using file pickers in Windows Phone Store app, see [How to continue your Windows Phone app after calling a file picker](http://msdn.microsoft.com/library/465bbb7a-9ed1-4b57-b60f-e5c6e7cd1470).



> [!IMPORTANT]
> In Windows 8 if you attempt to display the file picker while your app is snapped, the file picker will not be shown and an exception will be thrown. You can avoid this by making sure your app is not snapped, or by unsnapping it before you call the file picker. The following code examples and the [File picker sample](http://go.microsoft.com/fwlink/p/?linkid=234890) show you how. Note that Windows 8.1 does not define a specific snapped window size. Instead, users can resize apps to any width, down to the minimum. Therefore, if your app will deploy only on Windows 8.1, you can ignore the **EnsureUnsnapped** function and calls to it in this topic's example code.

## -examples
The [File picker sample](http://go.microsoft.com/fwlink/p/?linkid=234890) demonstrates how to check whether the app is snapped, how to set file picker properties, and how to show a file picker so that the user can pick one file.



[!code-csharp[all_openpicker_checksnapped_showsingle](../windows.storage.pickers/code/FilePicker/CS/Scenario1.xaml.cs#Snippetall_openpicker_checksnapped_showsingle)]

[!code-js[all_openpicker_checksnapped_showsingle](../windows.storage.pickers/code/FilePicker/js/js/scenario1.js#Snippetall_openpicker_checksnapped_showsingle)]



[!code-csharp[cs_checksnapped](../windows.storage.pickers/code/FilePicker/CS/Constants.cs#Snippetcs_checksnapped)]

> [!NOTE]
> You should always make sure that your app is not snapped (or that it can be unsnapped) and set file picker properties regardless of whether the user is picking a single file or multiple files.



[!code-csharp[all_openpicker_showmulti](../windows.storage.pickers/code/FilePicker/CS/Scenario2.xaml.cs#Snippetall_openpicker_showmulti)]

[!code-js[all_openpicker_showmulti](../windows.storage.pickers/code/FilePicker/js/js/scenario2.js#Snippetall_openpicker_showmulti)]

## -see-also
[File picker sample](http://go.microsoft.com/fwlink/p/?linkid=234890), [Quickstart: Accessing files with ](http://msdn.microsoft.com/library/df082239-381c-462f-9f97-d2b390a2052e), [How to continue your Windows Phone app after calling a file picker](http://msdn.microsoft.com/library/465bbb7a-9ed1-4b57-b60f-e5c6e7cd1470), [Blobs sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620573), [File picker sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=619994)
ample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=619994)
