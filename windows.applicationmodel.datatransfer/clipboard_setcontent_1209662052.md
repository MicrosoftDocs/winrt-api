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

If the content cannot be set to the clipboard (for example, because the application is not in the foreground), the method throws an exception. Use the [SetContentWithOptions](clipboard_setcontentwithoptions_595822094.md) method to set clipboard content without an exception.

The content is eligible for clipboard history and can be synced to other devices. To exclude the content from clipboard history and syncing, use the [SetContentWithOptions](clipboard_setcontentwithoptions_595822094.md) method.

## -examples


## -see-also
[SetContentWithOptions](clipboard_setcontentwithoptions_595822094.md)
