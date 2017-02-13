---
-api-id: M:Windows.System.UserPicker.PickSingleUserAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.System.User> PickSingleUserAsync()
-->

# Windows.System.UserPicker.PickSingleUserAsync

## -description
Displays a dialog for the user to pick a user account. The selected account is signed in, paired with the [IGameController](../windows.gaming.input/igamecontroller.md) that selected it, and becomes obtainable using the [User](user.md) class. This method is only supported for multi-user devices and apps, and will throw an exception if called from a single user device or app.

## -returns
When this method completes, it returns the selected user. If no user was selected, it returns null instead.

## -remarks

## -examples

## -see-also
