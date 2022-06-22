---
-api-id: E:Windows.UI.Xaml.Controls.PasswordBox.Paste
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.Controls.TextControlPasteEventHandler Paste
-->

# Windows.UI.Xaml.Controls.PasswordBox.Paste

## -description
Occurs when text is pasted into the control.



## -xaml-syntax
```xaml
<PasswordBox Paste="eventhandler"/>
```


## -remarks
The Paste event occurs before any content is inserted into the control. You can handle this event to check the contents of the clipboard and perform any actions on the content before it's inserted. If you perform any action, set the handled property to true; otherwise, the default paste action is performed. If you set the handled property to true, then it's assumed the app has handled the insertion, and no default action is performed. You are responsible for determining the insertion point and clipboard content to insert, and inserting the content.



## -examples

## -see-also
