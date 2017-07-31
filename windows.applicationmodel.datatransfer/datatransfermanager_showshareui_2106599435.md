---
-api-id: M:Windows.ApplicationModel.DataTransfer.DataTransferManager.ShowShareUI(Windows.ApplicationModel.DataTransfer.ShareUIOptions)
-api-type: winrt method
---

<!-- Method syntax.
public void DataTransferManager.ShowShareUI(ShareUIOptions shareOptions)
-->

# Windows.ApplicationModel.DataTransfer.DataTransferManager.ShowShareUI

## -description
Programmatically initiates the user interface for sharing content with another app.

## -parameters
### -param options
The options.

## -remarks
We recommend that you use this method only when absolutely necessary. Users expect to launch the Share user interface through the Share charm. Launching the user interface programmatically can create a confusing user experience.

As a general rule, use this method only when it isn't obvious to a user that some content is shareable. For example, if a user gets a high score in a game, it may not be obvious that they can share that high score with their friends. In this situation, it makes sense to use the **showShareUI** method.

A [DataPackage](datapackage.md) must have its [Title](datapackagepropertyset_title.md) set in order to be shared. Ensure [Title](datapackagepropertyset_title.md) is set before calling this method.

## -see-also

## -examples


