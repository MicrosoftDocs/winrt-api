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

This API is for Universal Windows Platform (UWP) apps. The alternative API to use for a desktop app is described in [Display WinRT UI objects that depend on CoreWindow](/windows/apps/develop/ui-input/display-ui-objects#for-classes-that-implement-idatatransfermanagerinterop).

## -parameters

### -param options
The options.

## -remarks
We recommend that you provide the user a Share affordance only when there is something shareable in your app. The prominence of the affordance can vary based on the nature of the content. For example, if the user gets a high score in a game, you may wish to put a Share button next to the congratulatory message. A news app, on the other hand, may put a Share button in an AppBar.

A [DataPackage](datapackage.md) must have its [Title](datapackagepropertyset_title.md) set in order to be shared. Ensure [Title](datapackagepropertyset_title.md) is set before calling this method.

## -see-also

## -examples

[Display WinRT UI objects that depend on CoreWindow](/windows/apps/develop/ui-input/display-ui-objects#for-classes-that-implement-idatatransfermanagerinterop)
