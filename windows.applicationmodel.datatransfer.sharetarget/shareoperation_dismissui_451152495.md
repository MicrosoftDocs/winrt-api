---
-api-id: M:Windows.ApplicationModel.DataTransfer.ShareTarget.ShareOperation.DismissUI
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void DismissUI()
-->

# Windows.ApplicationModel.DataTransfer.ShareTarget.ShareOperation.DismissUI

## -description
Closes the share pane.

## -remarks
Call the DismissUI method to dismiss the share pane programmatically. Calling DismissUI is similar to the user dismissing the share pane by tapping away from it. If the share operation takes a long time, the app continues to run in the background. If the operation isn't long-running, it has 10 seconds to run before being terminated.

This API was marked as deprecated in SDK versions 1511 and 1607. However, this API is no longer deprecated as of 1703. You can suppress the deprecation warning in Visual Studio by following instructions in the [How to: Suppress Compiler Warnings](/visualstudio/ide/how-to-suppress-compiler-warnings) topic.
## -examples

## -see-also
