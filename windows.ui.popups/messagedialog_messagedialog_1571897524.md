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
When localizing the content of a message dialog with string resources ([WinJS.Resources](http://msdn.microsoft.com/library/54c097f6-80d6-4433-9182-374bb63bb50e)), the **lang** property returned by the [getString](http://msdn.microsoft.com/library/d77fefde-5bce-4db2-a455-8c8d4e3b3601) method is applied by the [MessageDialog](messagedialog.md) constructor automatically. You cannot specify this property in the constructor.

## -examples

## -see-also
[MessageDialog(String)](messagedialog_messagedialog_290278668.md)