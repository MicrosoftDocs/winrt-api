---
-api-id: M:Windows.Management.Deployment.PackageManager.FindUsers(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IIterable<Windows.Management.Deployment.PackageUserInformation> FindUsers(System.String packageFullName)
-->

# Windows.Management.Deployment.PackageManager.FindUsers

## -description
Finds the users who have installed the specified [Package](/uwp/api/windows.applicationmodel.package).

## -parameters
### -param packageFullName
The full name of the package. This parameter cannot be **null**.

## -returns
If the method succeeds, an enumerable collection of package user information objects is returned. Each [PackageUserInformation](packageuserinformation.md) object in this collection contains the user security identifier (user SID) of a user for whom the specified package is installed. If no packages with the specified package full name are found, this method returns an empty list.

## -remarks
This method requires administrative privileges.

## -examples
Call the PackageManager.FindUsers method to enumerate the users who have installed a package. This example displays the information in the [PackageUserInformation.UserSecurityId](packageuserinformation_usersecurityid.md) property.

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

Also see [Visual Studio support for C++/WinRT](/windows/uwp/cpp-and-winrt-apis/intro-to-using-cpp-with-winrt#visual-studio-support-for-cwinrt-xaml-the-vsix-extension-and-the-nuget-package).

```cppwinrt
// main.cpp : In Visual Studio, create a new Windows Console Application (C++/WinRT), and run it (or run Visual Studio) as administrator.
#include "pch.h"

#include <winrt/Windows.ApplicationModel.h>
#include <winrt/Windows.Management.Deployment.h>
#include <winrt/Windows.Storage.h>
#include <iostream>
#include <Sddl.h>

using namespace winrt;
using namespace Windows::ApplicationModel;
using namespace Windows::Management::Deployment;
using namespace Windows::Storage;

std::wstring SidToAccountName(std::wstring const& sidString)
{
    PSID sid{ nullptr };

    std::wstring accountName{ sidString };

    if (::ConvertStringSidToSid(sidString.c_str(), &sid))
    {
        DWORD nameCharCount{ 0 };
        DWORD domainNameCharCount{ 0 };
        SID_NAME_USE sidType;

        // determine how much space is required to store the name and domainName.
        ::LookupAccountSid(nullptr, sid, nullptr, &nameCharCount, nullptr, &domainNameCharCount, &sidType);

        std::wstring name; name.resize(nameCharCount + 1);
        std::wstring domainName; domainName.resize(domainNameCharCount + 1);

        try
        {
            if (::LookupAccountSid(nullptr, sid, name.data(), &nameCharCount, domainName.data(), &domainNameCharCount, &sidType))
            {
                accountName = domainName + L"\\" + name;
            }
        }
        catch (...)
        {
            // do nothing, original SID will be used.
        }
    }

    if (sid != nullptr)
        ::LocalFree(sid);

    return accountName;
}

void DisplayPackageUsers(PackageManager const& packageManager, Windows::ApplicationModel::Package const& package)
{
    std::wcout << L"Users: ";

    for (auto const& packageUser : packageManager.FindUsers(package.Id().FullName()))
    {
        std::wstring stringSid = SidToAccountName(packageUser.UserSecurityId().c_str());

        std::wcout << stringSid << L" ";
    }
    std::wcout << std::endl;
}

int wmain()
{
    winrt::init_apartment();

    PackageManager packageManager;

    int count{ 10 };
    for (auto const& package : packageManager.FindPackages())
    {
        DisplayPackageUsers(packageManager, package);
        count--;
        if (count == 0) break;
    }

    return 0;
}
```

```cppcx
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

[Package](/uwp/api/windows.applicationmodel.package), [Enumerate app packages sample](https://github.com/microsoft/Windows-classic-samples/tree/master/Samples/PackageManagerFindProvisionedPackages), [Enumerate app packages by name and publisher sample](https://github.com/microsoft/Windows-classic-samples/tree/master/Samples/PackageManagerFindPackagesByNameAndPublisher)

## -capabilities
packageManagement
