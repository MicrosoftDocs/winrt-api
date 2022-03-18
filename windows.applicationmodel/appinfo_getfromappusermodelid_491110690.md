---
-api-id: M:Windows.ApplicationModel.AppInfo.GetFromAppUserModelId(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public AppInfo AppInfo.GetFromAppUserModelId(String appUserModelId)
-->

# Windows.ApplicationModel.AppInfo.GetFromAppUserModelId

## -description
Retrieves the AppInfo object associated with an AppUserModelId (AUMID).

## -parameters
### -param appUserModelId
The AUMID of the app from which to retrieve the AppInfo.

## -returns
The AppInfo corresponding to the given AUMID.

## -remarks
Requesting the AppInfo for another package requires the **packageQuery** capability. This capability is not required if the AUMID resolves to the current package. Note that full trust applications have this capability by default.

## -see-also

[AppInfo.GetFromAppUserModelIdForUser](appinfo_getfromappusermodelidforuser_807432373.md)

## -examples
