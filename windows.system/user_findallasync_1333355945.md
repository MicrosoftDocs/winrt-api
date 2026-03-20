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

This method returns users who are currently signed in to the same session as the calling application. It does not enumerate all accounts stored on the device.

To get the user running the current process directly, use [GetDefault](user_getdefault_846721868.md) (available from Windows 10, version 2104).

## -examples

## -see-also
[FindAllAsync](user_findallasync_326280522.md), [FindAllAsync(UserType)](user_findallasync_711678667.md)
