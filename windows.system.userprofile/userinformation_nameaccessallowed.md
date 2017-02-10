---
-api-id: P:Windows.System.UserProfile.UserInformation.NameAccessAllowed
-api-type: winrt property
---

<!-- Property syntax
public bool NameAccessAllowed { get; }
-->

# Windows.System.UserProfile.UserInformation.NameAccessAllowed

## -description
Allows you to see if your app is allowed to access the user's information.

> [!IMPORTANT]
> The [UserInformation](userinformation.md) class is not supported on Windows 10 or later. Use the [User](../windows.system/user.md) class instead. See Remarks in the [UserInformation](userinformation.md) class documentation.

## -property-value
True if your app is allowed access to the [AccountPictureChanged](userinformation_accountpicturechanged.md) event, and is allowed to retrieve user information by using the [GetAccountPicture](userinformation_getaccountpicture.md), [GetDisplayNameAsync](userinformation_getdisplaynameasync.md), [GetDomainNameAsync](userinformation_getdomainnameasync.md), [GetFirstNameAsync](userinformation_getfirstnameasync.md), [GetLastNameAsync](userinformation_getlastnameasync.md), and [GetSessionInitiationProtocolUriAsync](userinformation_getsessioninitiationprotocoluriasync.md) methods. Otherwise, this property is false.

## -remarks
> [!IMPORTANT]
> The [UserInformation](userinformation.md) class is not supported on Windows 10 or later. Use the [User](../windows.system/user.md) class instead. See Remarks in the [UserInformation](userinformation.md) class documentation.

If this property is **false**, the [GetDisplayNameAsync](userinformation_getdisplaynameasync.md), [GetDomainNameAsync](userinformation_getdomainnameasync.md), [GetFirstNameAsync](userinformation_getfirstnameasync.md), and [GetLastNameAsync](userinformation_getlastnameasync.md) methods return an empty string, while the [GetAccountPicture](userinformation_getaccountpicture.md) and [GetSessionInitiationProtocolUriAsync](userinformation_getsessioninitiationprotocoluriasync.md) methods return a null value.

## -examples

## -see-also
[User](../windows.system/user.md)