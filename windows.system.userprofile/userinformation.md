---
-api-id: T:Windows.System.UserProfile.UserInformation
-api-type: winrt class
---

<!-- Class syntax.
public class UserInformation 
-->

# Windows.System.UserProfile.UserInformation

## -description
Represents information about the user, such as name and account picture.

> [!IMPORTANT]
> The UserInformation class is not supported on Windows 10 or later. Use the [User](../windows.system/user.md) class instead. See Remarks.

## -remarks
> [!IMPORTANT]
> The UserInformation class is not supported on Windows 10 or later. Use the [User](../windows.system/user.md) class instead.



> **Windows 10**
> Apps compiled for Windows 8 that use the UserInformation class no longer return user information when running on Windows 10. This is because in Windows 10, apps do not have access to user information without explicit user consent, unlike in Windows 8 where this permission is granted by default.

If you have a Windows 8 app that uses the UserInformation class, you should migrate your app to the Universal Windows Platform (UWP) and access the [User](../windows.system/user.md) class instead. Universal Windows Platform (UWP) app that access user information are now expected to declare a new capability, uap:userAccountInformation, and call new APIs, [Windows.System.User.FindAllAsync](../windows.system/user_findallasync_1333355945.md) and [User.GetPropertiesAsync](../windows.system/user_getpropertiesasync_1952817514.md), to get the data.

When users install the app, they are prompted to allow access to their user information. If the user allows the app to access the information, the app appears listed in the **Privacy** page of the Windows 10  **Settings**  UI (**Settings** &gt; **Privacy** &gt; **Account info**). This allows Windows 10 users to enable access to user information on a per-app basis.

You can also enable access to user information without additional code modification by deploying a group policy change, which is particularly useful for business and enterprise customers. To allow access to user information on Windows 10, enable the following group policy setting and set it to "Always On": Computer Configuration > Administrative Templates > System > User Profiles > User management of sharing user name, account picture, and domain information with apps (not desktop apps). For more info, download [Group Policy Settings Reference for Windows and Windows Server](https://www.microsoft.com/download/details.aspx?id=25250).

> **Windows 8**
> To be launched in account picture mode and to set the user's picture without additional prompting, an app must register as an account picture provider by including the following in the [Extensions](/uwp/schemas/appxpackage/appxmanifestschema/element-1-extensions) section of the app manifest.



## -examples


```javascript
function getUserInfo() {
    image = Windows.System.UserProfile.UserInformation.getAccountPicture(Windows.System.UserProfile.AccountPictureKind.smallImage);
    imageURL = URL.createObjectURL(image, false);
}    
```



## -see-also
[User](../windows.system/user.md)
