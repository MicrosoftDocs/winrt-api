---
-api-id: M:Windows.Management.Deployment.PackageManager.FindUsers(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IIterable<Windows.Management.Deployment.PackageUserInformation> FindUsers(System.String packageFullName)
-->

# Windows.Management.Deployment.PackageManager.FindUsers

## -description
Finds the users who have installed the specified package.

## -parameters
### -param packageFullName
The full name of the package. This parameter cannot be **null**.

## -returns
If the method succeeds, an enumerable collection of package user information objects is returned. Each [PackageUserInformation](packageuserinformation.md) object in this collection contains the user security identifier (user SID) of a user for whom the specified package is installed. If no packages with the specified package full name are found, this method returns an empty list.

## -remarks
This method requires administrative privileges.

## -examples
Call the [PackageManager.FindUsers](packagemanager_findusers.md) method to enumerate the users who have installed a package. This example displays the information in the [PackageUserInformation.UserSecurityId](packageuserinformation_usersecurityid.md) property.

```csharp

using System.Security.Principal;
using Windows.Deployment.PackageManager;

private static void DisplayPackageUsers(
    PackageManager packageManager, 
    Windows.ApplicationModel.Package package)
{
    IEnumerable<PackageUserInformation> packageUsers = packageManager.FindUsers(
        package.Id.FullName);

    Console.Write("Users: ");

    foreach (var packageUser in packageUsers)
    {
        Console.Write("{0} ", SidToAccountName(packageUser.UserSecurityId));
    }

    Console.WriteLine();
}

private static string SidToAccountName(string sidString)
{
    SecurityIdentifier sid = new SecurityIdentifier(sidString);
    try
    {
        NTAccount account = (NTAccount)sid.Translate(typeof(NTAccount));
        return account.ToString();
    }
    catch (IdentityNotMappedException)
    {
        return sidString;
    }
}
```

```cpp
using Windows::Management::Deployment;

void DisplayPackageUsers(
    PackageManager^ packageManager, 
    Windows::ApplicationModel::Package^ package)
{
    IIterable<PackageUserInformation^>^ packageUsers = packageManager->FindUsers(
        package->Id->FullName);

    wcout << L"Users: ";

    std::for_each(begin(packageUsers), end(packageUsers), 
        [&](PackageUserInformation^ packageUser)
    {
        wstring stringSid;

        SidToAccountName(packageUser->UserSecurityId->Data(), stringSid);

        wcout << stringSid << L" ";
    });
    wcout << endl;
}

void SidToAccountName(wstring sidString, wstring& stringSid)
{
    PSID sid = NULL;

    if ( ConvertStringSidToSid(sidString.c_str(), &sid) )
    {
        DWORD nameCharCount = 0;
        DWORD domainNameCharCount = 0;
        SID_NAME_USE sidType;

        // determine how much space is required to store the name and domainName
        LookupAccountSid(NULL, sid, NULL, &nameCharCount, NULL, &domainNameCharCount, &sidType);

        wchar_t *name = new wchar_t[nameCharCount + 1]; // leave space for terminating null
        wchar_t *domainName = new wchar_t[domainNameCharCount + 1];

        ZeroMemory(name, (nameCharCount + 1) * sizeof(wchar_t));
        ZeroMemory(domainName, (domainNameCharCount + 1) * sizeof(wchar_t));

        try
        {
            if ( LookupAccountSid(NULL, sid, name, &nameCharCount, domainName, &domainNameCharCount, &sidType) )
            {
                stringSid = domainName;
                stringSid = stringSid + L"\\" + name;
            }
        }
        catch ( ... )
        {
            // do nothing, original SID will be used.
        }

        delete [] domainName;
        delete [] name;
    }

    if ( stringSid.length() == 0 )
        stringSid = sidString;

    if ( sid != NULL )
        LocalFree(sid);
}
```



## -see-also
[Enumerate app packages sample](http://code.msdn.microsoft.com/windowsdesktop/Package-Manager-Inventory-ee821079), [Enumerate app packages by name and publisher sample](http://code.msdn.microsoft.com/windowsdesktop/Package-Manager-Inventory-fe747b8a)

## -capabilities
packageManagement