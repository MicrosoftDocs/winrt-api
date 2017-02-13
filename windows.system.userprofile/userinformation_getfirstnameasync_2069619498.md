---
-api-id: M:Windows.System.UserProfile.UserInformation.GetFirstNameAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<string> GetFirstNameAsync()
-->

# Windows.System.UserProfile.UserInformation.GetFirstNameAsync

## -description
Gets the user's first name.

> [!IMPORTANT]
> The [UserInformation](userinformation.md) class is not supported on Windows 10 or later. Use the [User](../windows.system/user.md) class instead. See Remarks in the [UserInformation](userinformation.md) class documentation.

## -returns
The user's first name.

## -remarks
> [!IMPORTANT]
> The [UserInformation](userinformation.md) class is not supported on Windows 10 or later. Use the [User](../windows.system/user.md) class instead. See Remarks in the [UserInformation](userinformation.md) class documentation.

Access to the user's first name can be blocked by privacy settings (for example, if the [UserInformation::NameAccessAllowed](userinformation_nameaccessallowed.md) property is false). If access is blocked, this method returns an empty string.

This method does not throw an exception.

## -examples

## -see-also
[User](../windows.system/user.md)