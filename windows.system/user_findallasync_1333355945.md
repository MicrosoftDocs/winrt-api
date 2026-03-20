---
-api-id: M:Windows.System.User.FindAllAsync(Windows.System.UserType,Windows.System.UserAuthenticationStatus)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.System.User>> FindAllAsync(Windows.System.UserType type, Windows.System.UserAuthenticationStatus status)
-->

# Windows.System.User.FindAllAsync

## -description
Finds all users of a given type and authentication status asynchronously.

## -parameters
### -param type
The type of users to find.

### -param status
The authentication status of users to find.

## -returns
When this method completes successfully, it returns a list (type [IVectorView](../windows.foundation.collections/ivectorview_1.md)) of [Users](user.md).

## -remarks
> [!WARNING]
> This overload is deprecated. Use [FindAllAsync](user_findallasync_326280522.md) or [GetDefault](user_getdefault_846721868.md) instead.

On desktop platforms, this method returns at most one user—the interactive user associated with the caller's current session. On Xbox, the list may contain multiple users when more than one user is signed in simultaneously. The method does not enumerate all accounts stored on the device.

## -examples

## -see-also
[FindAllAsync](user_findallasync_326280522.md), [FindAllAsync(UserType)](user_findallasync_711678667.md)
