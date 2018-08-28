---
-api-id: M:Windows.System.UserProfile.UserInformation.GetDisplayNameAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<string> GetDisplayNameAsync()
-->

# Windows.System.UserProfile.UserInformation.GetDisplayNameAsync

## -description
Gets the display name for the user account.

> [!IMPORTANT]
> The [UserInformation](userinformation.md) class is not supported on Windows 10 or later. Use the [User](../windows.system/user.md) class instead. See Remarks in the [UserInformation](userinformation.md) class documentation.

## -returns
The display name for the user account.

## -remarks
> [!IMPORTANT]
> The [UserInformation](userinformation.md) class is not supported on Windows 10 or later. Use the [User](../windows.system/user.md) class instead. See Remarks in the [UserInformation](userinformation.md) class documentation.

Access to the display name can be blocked by privacy settings (for example, if the [UserInformation.NameAccessAllowed](userinformation_nameaccessallowed.md) property is false). If access is blocked, this method returns an empty string.

This method does not throw an exception.

## -examples


## -see-also
[User](../windows.system/user.md)
