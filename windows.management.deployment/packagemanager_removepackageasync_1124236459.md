---
-api-id: M:Windows.Management.Deployment.PackageManager.RemovePackageAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Management.Deployment.DeploymentResult, Windows.Management.Deployment.DeploymentProgress> RemovePackageAsync(System.String packageFullName)
-->

# Windows.Management.Deployment.PackageManager.RemovePackageAsync

## -description
Removes a [Package](/uwp/api/windows.applicationmodel.package) for the current user asynchronously and receives progress and status messages on the removal operation. Dependency packages are also removed for the user if no other packages installed for the user depend on them.

## -parameters
### -param packageFullName
A string representation of the package identity to identify the package to be removed.

## -returns
The status of the deployment request. The [DeploymentResult](deploymentresult.md) contains the final returned value of the deployment operation, once it is completed. The [DeploymentProgress](deploymentprogress.md) can be used to obtain the percentage of completion over the entire course of the deployment operation.

## -remarks

For a call to this method to be successful, the caller needs to fulfil one of these conditions:

* The caller is running in an AppContainer (Low IL) *and* it has the **packageManagement** restricted capability.
* The caller is running with Medium IL, or higher.
* The caller’s publisher matches the publisher of the package (or volume) being removed.

For descriptions of the terms above, and links to more info, see [Packaging, deployment, and process](/windows/apps/get-started/intro-pack-dep-proc).

This request can't be canceled. The package full name is an alternate form of the package identity that is shorter and is suitable for naming objects such as files and directories. A package identity is represented by the [Identity](/uwp/schemas/appxpackage/appxmanifestschema/element-identity) element of the package manifest. When a package is removed it is removed for the current user, which means that the package payload continues to exist if other users have installed the package, but it will not be accessible to the current user. If no other users have the specified package installed, its payload will be removed from the %ProgramFiles%\WindowsApps directory. Any app associated with the package that is being removed will be shutdown automatically as part of the package removal.

## -examples
Call the RemovePackageAsync(String) method to uninstall the app package. Notice that the package full name in *packageFullName* comes from a command-line argument.

RemovePackageAsync(String) returns an object that can be used to manage the asynchronous operation. Use the [Completed](../windows.foundation/iasyncoperationwithprogress_2_completed.md) property to set the [delegate](../windows.foundation/asyncoperationwithprogresscompletedhandler_2.md). Check the [Status](../windows.foundation/iasyncinfo_status.md) property to determine the status of the deployment operation. If the status is **Error**, the example calls the [GetResults](../windows.foundation/iasyncoperationwithprogress_2_getresults_732303200.md) method to get additional error information.

```csharp
using Windows.Foundation;
using Windows.Management.Deployment;

[STAThread]
public static int Main(string[] args)
{
    string inputPackageFullName = args[0];
    int returnValue = 0;

    PackageManager packageManager = new Windows.Management.Deployment.PackageManager();

    IAsyncOperationWithProgress<DeploymentResult, DeploymentProgress> deploymentOperation = 
        packageManager.RemovePackageAsync(inputPackageFullName);
    // This event is signaled when the operation completes
    ManualResetEvent opCompletedEvent = new ManualResetEvent(false); 

    // Define the delegate using a statement lambda
    deploymentOperation.Completed = (depProgress, status) => { opCompletedEvent.Set(); };

    // Wait until the operation completes
    opCompletedEvent.WaitOne();

    // Check the status of the operation
    if (deploymentOperation.Status == AsyncStatus.Error)
    {
        DeploymentResult deploymentResult = deploymentOperation.GetResults();
        Console.WriteLine("Error code: {0}", deploymentOperation.ErrorCode);
        Console.WriteLine("Error text: {0}", deploymentResult.ErrorText);
        returnValue = 1;
    }
    else if (deploymentOperation.Status == AsyncStatus.Canceled)
    {
        Console.WriteLine("Removal canceled");
    }
    else if (deploymentOperation.Status == AsyncStatus.Completed)
    {
        Console.WriteLine("Removal succeeded");
    }
    else
    {
        returnValue = 1;
        Console.WriteLine("Removal status unknown");
    }

    return returnValue;
}
```

Also see [Visual Studio support for C++/WinRT](/windows/uwp/cpp-and-winrt-apis/intro-to-using-cpp-with-winrt#visual-studio-support-for-cwinrt-xaml-the-vsix-extension-and-the-nuget-package).

```cppwinrt
// main.cpp : In Visual Studio, create a new Windows Console Application (C++/WinRT).
#include "pch.h"

#include <winrt/Windows.Foundation.h>
#include <winrt/Windows.Management.Deployment.h>
#include <iostream>

using namespace winrt;
using namespace Windows::Foundation;
using namespace Windows::Management::Deployment;

int wmain(int /* argc */, wchar_t *argv[], wchar_t * /* envp[] */)
{
    winrt::init_apartment();

    int returnValue{ 0 };

    std::wstring inputPackageFullName{ argv[1] };
    PackageManager packageManager;

    auto deploymentOperation{ packageManager.RemovePackageAsync(inputPackageFullName) };
    deploymentOperation.get();

    // Check the status of the operation
    if (deploymentOperation.Status() == AsyncStatus::Error)
    {
        auto deploymentResult{ deploymentOperation.GetResults() };
        std::wcout << L"Error code: " << deploymentOperation.ErrorCode() << std::endl;
        std::wcout << L"Error text: " << deploymentResult.ErrorText().c_str() << std::endl;
        returnValue = 1;
    }
    else if (deploymentOperation.Status() == AsyncStatus::Canceled)
    {
        std::wcout << L"Removal canceled" << std::endl;
    }
    else if (deploymentOperation.Status() == AsyncStatus::Completed)
    {
        std::wcout << L"Removal succeeded" << std::endl;
    }
    else
    {
        std::wcout << L"Removal status unknown" << std::endl;
        returnValue = 1;
    }
    return returnValue;
}
```

```cppcx
using namespace Platform;
using namespace Windows::Foundation;
using namespace Windows::Management::Deployment;

int __cdecl main(Platform::Array<String^>^ args)
{
    String^ inputPackageFullName = args[1];
    int returnValue = 0;

    PackageManager^ packageManager = ref new PackageManager();

    auto deploymentOperation = packageManager->RemovePackageAsync(inputPackageFullName);

    DeploymentResult^ deploymentOperationResult;

    // This event is signaled when the operation completes
    opCompletedEvent = CreateEvent(NULL, TRUE, FALSE, NULL);

    // Define the delegate
    deploymentOperation->Completed = 
        ref new AsyncOperationWithProgressCompletedHandler<DeploymentResult^, DeploymentProgress>(
        [&](IAsyncOperationWithProgress<DeploymentResult^, DeploymentProgress>^ operation, AsyncStatus)
    {
        SetEvent(opCompletedEvent);
    });

    // Wait until the operation completes
    WaitForSingleObject(opCompletedEvent, INFINITE);

    // Check the status of the operation
    if ( deploymentOperation->Status == AsyncStatus::Error )
    {
        auto deploymentResult = deploymentOperation->GetResults();
        wcout << L"Removal Error: " << deploymentOperation->ErrorCode.Value << endl;
        wcout << L"Detailed Error Text: " << deploymentResult->ErrorText->Data() << endl;
        returnValue = 1;
    }
    else if ( deploymentOperation->Status == AsyncStatus::Canceled )
    {
        wcout << L"Removal Canceled" << endl;
    }
    else if ( deploymentOperation->Status == AsyncStatus::Completed )
    {
        wcout << L"Removal succeeded!" << endl;
    }
    else
    {
        wcout << L"Removal status unknown" << endl;
        returnValue = 1;
    }

    return returnValue;
}
```

## -see-also

[Package](/uwp/api/windows.applicationmodel.package), [RemovePackageAsync(String, RemovalOptions)](packagemanager_removepackageasync_1331217245.md)
