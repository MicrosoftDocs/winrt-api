---
-api-id: M:Windows.UI.Popups.MessageDialog.#ctor(System.String)
-api-type: winrt method
---

<!-- Method syntax
public MessageDialog(System.String content)
-->

# Windows.UI.Popups.MessageDialog.MessageDialog

## -description
 Initializes a new instance of the [MessageDialog](messagedialog.md) class to display an untitled message dialog that can be used to ask your user simple questions.

The dialog dims the screen behind it and blocks touch events from passing to the app's canvas until the user responds.

Message dialogs should be used sparingly, and only for critical messages or simple questions that must block the user's flow.

## -parameters
### -param content
The message displayed to the user.

## -remarks
When localizing the content of a message dialog with string resources ([WinJS.Resources](/previous-versions/windows/apps/br229779(v=win.10))), the **lang** property returned by the [getString](/previous-versions/windows/apps/hh701590(v=win.10)) method is applied by the [MessageDialog](messagedialog.md) constructor automatically. You cannot specify this property in the constructor.

To use this object from a desktop app, create the object, and then use [the IInitializeWithWindow::Initialize method](/en-us/windows/desktop/api/shobjidl_core/nf-shobjidl_core-iinitializewithwindow-initialize) to associate the object with a window handle.

## -examples

## -see-also
[MessageDialog(String, String)](messagedialog_messagedialog_1571897524.md)