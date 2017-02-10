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

## -examples

## -see-also
