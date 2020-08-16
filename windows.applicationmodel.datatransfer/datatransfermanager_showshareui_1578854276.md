---
-api-id: M:Windows.ApplicationModel.DataTransfer.DataTransferManager.ShowShareUI
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void ShowShareUI()
-->

# Windows.ApplicationModel.DataTransfer.DataTransferManager.ShowShareUI

## -description
Programmatically initiates the user interface for sharing content with another app.

## -remarks
A [DataPackage](datapackage.md) must have its [Title](datapackagepropertyset_title.md) set in order to be shared. Ensure [Title](datapackagepropertyset_title.md) is set before calling this method.

## -examples
This example demonstrates how to call the **ShowShareUI** method to launch the Share user interface. Notice that this example only launches the interface— it does not add any content to share with another app.



[!code-js[DataTransferManager_3](../windows.applicationmodel.datatransfer/code/DataTransferManagerSample/javascript/DataTransferClassSample/js/default.js#SnippetDataTransferManager_3)]

## -see-also
