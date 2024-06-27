---
-api-id: M:Windows.Security.Credentials.UI.CredentialPicker.PickAsync(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Security.Credentials.UI.CredentialPickerResults> PickAsync(System.String targetName, System.String message)
-->

# Windows.Security.Credentials.UI.CredentialPicker.PickAsync

## -description
Constructor used to initiate asynchronous prompting operations using two inputs.

## -parameters
### -param targetName
The target name to display.

### -param message
The message to display in the dialog box.

## -returns
The credential and options from the user.

## -remarks

This method is supported only in UWP apps. In a non-UWP (that is, desktop) app, use the three-parameter overload, and set the *caption* parameter.

## -examples

## -see-also
[PickAsync(CredentialPickerOptions)](credentialpicker_pickasync_1621420115.md), [PickAsync(String, String, String)](credentialpicker_pickasync_1330776073.md)
