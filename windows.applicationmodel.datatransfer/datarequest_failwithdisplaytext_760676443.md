---
-api-id: M:Windows.ApplicationModel.DataTransfer.DataRequest.FailWithDisplayText(System.String)
-api-type: winrt method
---

<!-- Method syntax
public void FailWithDisplayText(System.String value)
-->

# Windows.ApplicationModel.DataTransfer.DataRequest.FailWithDisplayText

## -description
Cancels the sharing operation and supplies an error string to display to the user.

## -parameters
### -param value
The text to display to the user.

## -remarks
Use the **FailWithDisplayText** method when your app is unable to supply a [DataPackage](datapackage.md) to a target app. This method cancels the share operation and supplies a text message to the target app. The target app can then display this text to the user to explain why the share operation failed.

This API was marked as deprecated in SDK versions 1511 and 1607. However, this API is no longer deprecated as of 1703. You can suppress the deprecation warning in Visual Studio by following instructions in the [How to: Suppress Compiler Warnings](/visualstudio/ide/how-to-suppress-compiler-warnings) topic.

## -examples

## -see-also
