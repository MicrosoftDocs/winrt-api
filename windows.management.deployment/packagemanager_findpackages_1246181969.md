---
-api-id: M:Windows.Management.Deployment.PackageManager.FindPackages
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IIterable<Windows.ApplicationModel.Package> FindPackages()
-->

# Windows.Management.Deployment.PackageManager.FindPackages

## -description
Retrieves information about a specified family of [Packages](/uwp/api/windows.applicationmodel.package) installed across all users.

## -returns
If the method succeeds, an enumerable collection of package objects is returned. Each Package object in this collection contains information about the package, including but not limited to its name, publisher, version, and install location.

## -remarks
This method requires administrative privileges. Otherwise, an **AccessDeniedException** is thrown.

## -examples
This example uses FindPackages() to enumerate the installed packages for all users.

```csharp
using Windows.Management.Deployment;

public static int Main(string[] args)
{
    PackageManager packageManager = new PackageManager();

    IEnumerable<Windows.ApplicationModel.Package> packages = 
        (IEnumerable<Windows.ApplicationModel.Package>) packageManager.FindPackages();

    int packageCount = 0;
    foreach (var package in packages)
    {
        DisplayPackageInfo(package);

        packageCount += 1;
    }

    if (packageCount < 1)
    {
        Console.WriteLine("No packages were found.");
    }
}

private static void DisplayPackageInfo(Windows.ApplicationModel.Package package)
{
    Console.WriteLine("Name: {0}", package.Id.Name);

    Console.WriteLine("FullName: {0}", package.Id.FullName);

    Console.WriteLine("Version: {0}.{1}.{2}.{3}", package.Id.Version.Major, package.Id.Version.Minor,
        package.Id.Version.Build, package.Id.Version.Revision);

    Console.WriteLine("Publisher: {0}", package.Id.Publisher);

    Console.WriteLine("PublisherId: {0}", package.Id.PublisherId);

    Console.WriteLine("Installed Location: {0}", package.InstalledLocation.Path);

    Console.WriteLine("IsFramework: {0}", package.IsFramework);
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

using namespace winrt;
using namespace Windows::ApplicationModel;
using namespace Windows::Management::Deployment;
using namespace Windows::Storage;

void DisplayPackageInfo(Windows::ApplicationModel::Package const& package)
{
    try
    {
        std::wcout << L"Name: " << package.Id().Name().c_str() << std::endl;
        std::wcout << L"FullName: " << package.Id().FullName().c_str() << std::endl;
        std::wcout << L"Version: " << package.Id().Version().Major << "." << package.Id().Version().Minor << "." << package.Id().Version().Build << "." << package.Id().Version().Revision << std::endl;
        std::wcout << L"Publisher: " << package.Id().Publisher().c_str() << std::endl;
        std::wcout << L"PublisherId: " << package.Id().PublisherId().c_str() << std::endl;
        std::wcout << L"Installed Location: " << package.InstalledLocation().Path().c_str() << std::endl;
        std::wcout << L"IsFramework: " << (package.IsFramework() ? L"True" : L"False") << std::endl;
    }
    catch (winrt::hresult_error const& ex)
    {
        std::wcout << ex.message().c_str() << std::endl;
    }
}

int wmain()
{
    winrt::init_apartment();

    bool noPackagesFound{ true };
    for (auto const& package : PackageManager{}.FindPackages())
    {
        DisplayPackageInfo(package);
        noPackagesFound = false;
    }

    if (noPackagesFound)
    {
        std::wcout << L"No packages were found." << std::endl;
    }

    return 0;
}
```

```cppcx
using namespace Windows::Management::Deployment;

[STAThread]
int __cdecl main(Platform::Array<String^>^ args)
{
    PackageManager^ packageManager = ref new PackageManager();

    IIterable<Windows::ApplicationModel::Package^>^ packages = packageManager->FindPackages(); 

    int packageCount = 0;
    std::for_each(Windows::Foundation::Collections::begin(packages), Windows::Foundation::Collections::end(packages), 
    [&](Windows::ApplicationModel::Package^ package) 
    {
        DisplayPackageInfo(package);

        packageCount += 1; 
    });

    if ( packageCount < 1 )
    {
        wcout << L"No packages were found." << endl;
    }

    return 0;
}

void DisplayPackageInfo(Windows::ApplicationModel::Package^ package)
{
    wcout << L"Name: " << package->Id->Name->Data() << endl;
    wcout << L"FullName: " << package->Id->FullName->Data() << endl;
    wcout << L"Version: " << package->Id->Version.Major << "." << 
        package->Id->Version.Minor << "." << package->Id->Version.Build << 
        "." << package->Id->Version.Revision << endl;
    wcout << L"Publisher: " << package->Id->Publisher->Data() << endl;
    wcout << L"PublisherId: " << package->Id->PublisherId->Data() << endl;
    wcout << L"Installed Location: " << package->InstalledLocation->Path->Data() << endl;
    wcout << L"IsFramework: " << (package->IsFramework ? L"True" : L"False") << endl;
}
```



## -see-also

[Package](/uwp/api/windows.applicationmodel.package), [Enumerate app packages sample](https://github.com/microsoft/Windows-classic-samples/tree/master/Samples/PackageManagerFindProvisionedPackages), [FindPackages(String)](packagemanager_findpackages_331793265.md), [FindPackages(String, String)](packagemanager_findpackages_1597689551.md)

## -capabilities
packageQuery
