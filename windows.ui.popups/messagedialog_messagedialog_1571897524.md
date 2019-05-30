---
-api-id: M:Windows.UI.Popups.MessageDialog.#ctor(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public MessageDialog(System.String content, System.String title)
-->

# Windows.UI.Popups.MessageDialog.MessageDialog

## -description
Initializes a new instance of the [MessageDialog](messagedialog.md) class to display a titled message dialog that can be used to ask your user simple questions.

## -parameters
### -param content
The message displayed to the user.

### -param title
The title you want displayed on the dialog.

## -remarks
When localizing the content of a message dialog with string resources ([WinJS.Resources](https://docs.microsoft.com/previous-versions/windows/apps/br229779(v=win.10))), the **lang** property returned by the [getString](https://docs.microsoft.com/previous-versions/windows/apps/hh701590(v=win.10)) method is applied by the [MessageDialog](messagedialog.md) constructor automatically. You cannot specify this property in the constructor.

To use this object from a desktop app, create the object, and then use [the IInitializeWithWindow::Initialize method](https://docs.microsoft.com/en-us/windows/desktop/api/shobjidl_core/nf-shobjidl_core-iinitializewithwindow-initialize) to associate the object with a window handle.

## -examples

## -see-also
[MessageDialog(String)](messagedialog_messagedialog_290278668.md)