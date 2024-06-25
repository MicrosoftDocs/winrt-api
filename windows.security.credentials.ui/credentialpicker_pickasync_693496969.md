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

This method is only supported in a UWP app.
In a non-UWP app use the 3 parameter overload and set the `caption` parameter.

## -examples

## -see-also
[PickAsync(CredentialPickerOptions)](credentialpicker_pickasync_1621420115.md), [PickAsync(String, String, String)](credentialpicker_pickasync_1330776073.md)