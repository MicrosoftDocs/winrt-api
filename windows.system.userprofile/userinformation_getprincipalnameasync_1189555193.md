---
-api-id: M:Windows.System.UserProfile.UserInformation.GetPrincipalNameAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<string> GetPrincipalNameAsync()
-->

# Windows.System.UserProfile.UserInformation.GetPrincipalNameAsync

## -description
Gets the principal name for the user. This name is the User Principal Name (typically the user's address, although this is not always true.)

> [!IMPORTANT]
> The [UserInformation](userinformation.md) class is not supported on Windows 10 or later. Use the [User](../windows.system/user.md) class instead. See Remarks in the [UserInformation](userinformation.md) class documentation.

## -returns
The user's principal name.

## -remarks
> [!IMPORTANT]
> The [UserInformation](userinformation.md) class is not supported on Windows 10 or later. Use the [User](../windows.system/user.md) class instead. See Remarks in the [UserInformation](userinformation.md) class documentation.

Only domain users have a principal name. Access to the principal name can be blocked by privacy settings (for example, if the [UserInformation.NameAccessAllowed](userinformation_nameaccessallowed.md) property is false). If access is blocked, this method returns an empty string.

This method requires the [enterpriseAuthentication](/windows/uwp/packaging/app-capability-declarations) capability.

This method does not throw an exception.

## -examples

## -see-also
[User](../windows.system/user.md)
