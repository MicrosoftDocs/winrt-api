---
-api-id: M:Windows.ApplicationModel.DataTransfer.Clipboard.SetContent(Windows.ApplicationModel.DataTransfer.DataPackage)
-api-type: winrt method
---

<!-- Method syntax
public void SetContent(Windows.ApplicationModel.DataTransfer.DataPackage content)
-->

# Windows.ApplicationModel.DataTransfer.Clipboard.SetContent

## -description
Sets the current content that is stored in the clipboard object.

## -parameters
### -param content
Contains the content of the clipboard. If **NULL**, the clipboard is emptied.

## -remarks
Use this method after creating and defining a [DataPackage](datapackage.md) with the data you want to put on the clipboard. Call this method only when the application is in the foreground, or when a debugger is attached.

## -examples


## -see-also
