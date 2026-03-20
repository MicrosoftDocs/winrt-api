---
-api-id: M:Windows.System.User.FindAllAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.System.User>> FindAllAsync()
-->

# Windows.System.User.FindAllAsync

## -description
Finds all users asynchronously.

## -returns
When this method completes successfully, it returns a list (type [IVectorView](../windows.foundation.collections/ivectorview_1.md)) of [Users](user.md).

## -remarks
On desktop platforms, this method returns at most one user—the interactive user associated with the caller's current session. On Xbox, the list may contain multiple users when more than one user is signed in simultaneously. The method does not enumerate all accounts stored on the device.

To get the user running the current process directly, use [GetDefault](user_getdefault_846721868.md) (available from Windows 10, version 2104).

## -examples

## -see-also
[FindAllAsync(UserType)](user_findallasync_711678667.md), [FindAllAsync(UserType, UserAuthenticationStatus)](user_findallasync_1333355945.md)
