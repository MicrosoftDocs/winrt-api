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
When localizing the content of a message dialog with string resources ([WinJS.Resources](http://msdn.microsoft.com/library/54c097f6-80d6-4433-9182-374bb63bb50e)), the **lang** property returned by the [getString](http://msdn.microsoft.com/library/d77fefde-5bce-4db2-a455-8c8d4e3b3601) method is applied by the [MessageDialog](messagedialog.md) constructor automatically. You cannot specify this property in the constructor.

## -examples

## -see-also
[MessageDialog(String, String)](messagedialog_messagedialog_1571897524.md)