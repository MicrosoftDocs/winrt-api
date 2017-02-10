---
-api-id: M:Windows.ApplicationModel.DataTransfer.Clipboard.Flush
-api-type: winrt method
---

<!-- Method syntax
public void Flush()
-->

# Windows.ApplicationModel.DataTransfer.Clipboard.Flush

## -description
Adds the content to the Clipboard and releases the [DataPackage](datapackage.md) object from the source app. This method allows the content to remain available after the application shuts down.

## -remarks
When you call the [Flush](clipboard_flush.md) method, the content of the [DataPackage](datapackage.md) is added to the Clipboard and then released from the source app. This action makes the content available on the Clipboard even after the source app is no longer available.

## -examples

## -see-also
