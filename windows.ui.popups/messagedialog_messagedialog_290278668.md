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

In a desktop app, before using an instance of this class in a way that displays UI, you'll need to associate the object with its owner's window handle. For more info, and code examples, see [Display WinRT UI objects that depend on CoreWindow](/windows/apps/develop/ui-input/display-ui-objects#winui-3-with-c).

The dialog dims the screen behind it and blocks touch events from passing to the app's canvas until the user responds.

Message dialogs should be used sparingly, and only for critical messages or simple questions that must block the user's flow.

## -parameters
### -param content
The message displayed to the user.

## -remarks
When localizing the content of a message dialog with string resources ([WinJS.Resources](/previous-versions/windows/apps/br229779(v=win.10))), the **lang** property returned by the [getString](/previous-versions/windows/apps/hh701590(v=win.10)) method is applied by the [MessageDialog](messagedialog.md) constructor automatically. You cannot specify this property in the constructor.

## -examples

## -see-also
[MessageDialog(String, String)](messagedialog_messagedialog_1571897524.md)