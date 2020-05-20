---
-api-id: M:Windows.ApplicationModel.AppInfo.GetFromAppUserModelIdForUser(Windows.System.User,System.String)
-api-type: winrt method
---

<!-- Method syntax.
public AppInfo AppInfo.GetFromAppUserModelIdForUser(User user, String appUserModelId)
-->

# Windows.ApplicationModel.AppInfo.GetFromAppUserModelIdForUser

## -description
Retrieves the AppInfo object associated with a specified User and AppUserModelId (AUMID).

## -parameters
### -param user
The User whose AppInfos you wish to access.

### -param appUserModelId
The AUMID of the app from which to retrieve the AppInfo.

## -returns
The AppInfo corresponding to the given AUMID and user.

## -remarks
Finding AppInfo for another user requires administration privileges.

Requesting the AppInfo for another package requires the **packageQuery** capability. This capability is not required if the AUMID resolves to the current package. Note that full trust applications have this capability by default.

## -see-also

[AppInfo.GetFromAppUserModelId](appinfo_getfromappusermodelid_491110690.md)

## -examples
