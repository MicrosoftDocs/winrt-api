---
-api-id: M:Windows.ApplicationModel.DataTransfer.Clipboard.SetContentWithOptions(Windows.ApplicationModel.DataTransfer.DataPackage,Windows.ApplicationModel.DataTransfer.ClipboardContentOptions)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public bool Clipboard.SetContentWithOptions(DataPackage content, ClipboardContentOptions options)
-->

# Windows.ApplicationModel.DataTransfer.Clipboard.SetContentWithOptions

## -description
Sets the content that is stored in the clipboard object with options for the content.

## -parameters
### -param content
Contains the content to store in the clipboard. This parameter may not be null.

### -param options
An object that specifies options for the clipboard content, such as whether the content is allowed in the clipboard history and whether it will be synced to other devices. This parameter may be null, in which case default options are used.

## -returns
True if the content was set to the clipboard. False if the content could not be set, for example, because the clipboard is already in use by another process.

## -remarks

## -see-also

## -examples
