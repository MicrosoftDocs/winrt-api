---
-api-id: M:Windows.System.UserProfile.UserInformation.GetAccountPicture(Windows.System.UserProfile.AccountPictureKind)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.IStorageFile GetAccountPicture(Windows.System.UserProfile.AccountPictureKind kind)
-->

# Windows.System.UserProfile.UserInformation.GetAccountPicture

## -description
Gets the account picture for the user.

> [!IMPORTANT]
> The [UserInformation](userinformation.md) class is not supported on Windows 10 or later. Use the [User](../windows.system/user.md) class instead. See Remarks in the [UserInformation](userinformation.md) class documentation.

## -parameters
### -param kind
An enumeration that you can use to determine what type of image you want (small, large, and so on).

## -returns
An object that contains the image.

## -remarks
> [!IMPORTANT]
> The [UserInformation](userinformation.md) class is not supported on Windows 10 or later. Use the [User](../windows.system/user.md) class instead. See Remarks in the [UserInformation](userinformation.md) class documentation.

Access to the account picture can be blocked by privacy settings (for example, if the [UserInformation::NameAccessAllowed](userinformation_nameaccessallowed.md) property is false). If access is blocked, this method returns a null value.

This method does not throw an exception.

## -examples

## -see-also
[User](../windows.system/user.md)