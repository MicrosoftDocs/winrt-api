---
-api-id: M:Windows.System.UserAuthenticationStatusChangingEventArgs.GetDeferral
-api-type: winrt method
---

<!-- Method syntax
public Windows.System.UserAuthenticationStatusChangeDeferral GetDeferral()
-->

# Windows.System.UserAuthenticationStatusChangingEventArgs.GetDeferral

## -description
Requests a delay before the user's authentication status changes.

## -returns
The user authentication status change deferral.

## -remarks
The change in user authentication status is delayed until the app calls the [UserAuthenticationStatusChangeDeferral.Complete](userauthenticationstatuschangedeferral_complete.md) method or the deadline for the change has passed.

Use the deferral to complete asynchronous operations, such as saving data to a file, before the system changes the user’s authentication status.

## -examples

## -see-also
