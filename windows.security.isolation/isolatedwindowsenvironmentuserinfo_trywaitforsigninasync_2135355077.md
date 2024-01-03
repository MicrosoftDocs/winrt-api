---
-api-id: M:Windows.Security.Isolation.IsolatedWindowsEnvironmentUserInfo.TryWaitForSignInAsync
-api-type: winrt method
---

# Windows.Security.Isolation.IsolatedWindowsEnvironmentUserInfo.TryWaitForSignInAsync

<!--
public Windows.Foundation.IAsyncOperation<bool> TryWaitForSignInAsync ();
-->

## -description

**Deprecated.** This asynchronous wait function returns once the Isolated Windows Environment sign-in process is complete. It returns `true` if sign-in succeeded, `false` otherwise.

## -returns

An `IAsyncOperation<bool>` indicating the success of the sign-in operation.

## -remarks

> [!WARNING]
> This is a deprecated API.

If sign-in is complete when `TryWaitForSignInAsync` is called, the API returns `true` immediately.

## -see-also

## -examples
