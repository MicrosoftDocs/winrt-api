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

In a desktop app, before using an instance of this class in a way that displays UI, you'll need to associate the object with its owner's window handle. For more info, and code examples, see [Display WinRT UI objects that depend on CoreWindow](/windows/apps/develop/ui-input/display-ui-objects#winui-3-with-c).

## -parameters
### -param content
The message displayed to the user.

### -param title
The title you want displayed on the dialog.

## -remarks
When localizing the content of a message dialog with string resources ([WinJS.Resources](/previous-versions/windows/apps/br229779(v=win.10))), the **lang** property returned by the [getString](/previous-versions/windows/apps/hh701590(v=win.10)) method is applied by the [MessageDialog](messagedialog.md) constructor automatically. You cannot specify this property in the constructor.

## -examples

## -see-also
[MessageDialog(String)](messagedialog_messagedialog_290278668.md)