---
-api-id: T:Windows.Management.Deployment.PackageUserInformation
-api-type: winrt class
---

<!-- Class syntax.
public class PackageUserInformation : Windows.Management.Deployment.IPackageUserInformation
-->

# Windows.Management.Deployment.PackageUserInformation

## -description
Provides information about the users of an installed package.

## -remarks
To enumerate the users who have installed a package, use the [PackageManager.FindUsers](packagemanager_findusers.md) method.

## -examples
Call the [PackageManager.FindUsers](packagemanager_findusers.md) method to enumerate the users who have installed a package. This example displays the information in the [PackageUserInformation.UserSecurityId](packageuserinformation_usersecurityid.md) property.

```csharp

using System.Security.Principal;

private static void DisplayPackageUsers(
    Windows.Management.Deployment.PackageManager packageManager, 
    Windows.ApplicationModel.Package package)
{
    IEnumerable<Windows.Management.Deployment.PackageUserInformation> packageUsers = 
        packageManager.FindUsers(package.Id.FullName);

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
void DisplayPackageUsers(
    Windows::Management::Deployment::PackageManager^ packageManager, 
    Windows::ApplicationModel::Package^ package)
{
    IIterable<Windows::Management::Deployment::PackageUserInformation^>^ packageUsers = 
        packageManager->FindUsers(package->Id->FullName);

    wcout << L"Users: ";

    std::for_each(begin(packageUsers), end(packageUsers), 
        [&](Windows::Management::Deployment::PackageUserInformation^ packageUser)
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
            if ( LookupAccountSid(NULL, sid, name, &nameCharCount, 
                    domainName, &domainNameCharCount, &sidType) )
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
[Enumerate app packages sample](http://code.msdn.microsoft.com/windowsdesktop/Package-Manager-Inventory-ee821079), [Enumerate app packages by name and publisher sample](http://code.msdn.microsoft.com/windowsdesktop/Package-Manager-Inventory-fe747b8a), [Packaging apps](http://msdn.microsoft.com/library/1abcbb13-80f0-4bf1-a812-649ee8bd1915), [PackageManager](packagemanager.md)