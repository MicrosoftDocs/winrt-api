---
-api-id: M:Windows.ApplicationModel.DataTransfer.Clipboard.GetContent
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.DataTransfer.DataPackageView GetContent()
-->

# Windows.ApplicationModel.DataTransfer.Clipboard.GetContent

## -description
Gets the current content that is stored in the clipboard object.

## -returns
Contains the content of the Clipboard.

## -remarks
If the **GetContent** call is successful, you can use the [DataPackageView](datapackageview.md) it returns to get information such as the file types it supports and any properties that the source app assigned through the [DataPackagePropertySet](datapackagepropertyset.md) class.

## -examples


[!code-js[GetClipboardContent](../windows.applicationmodel.datatransfer/code/ClipBoardBeta/js/default.js#SnippetGetClipboardContent)]

## -see-also
