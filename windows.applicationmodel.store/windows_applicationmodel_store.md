---
-api-id: N:Windows.ApplicationModel.Store
-api-type: winrt namespace
---

# Windows.ApplicationModel.Store

## -description
Provides types and members for interacting with the Windows Store to add in-app purchases and trial functionality to your Universal Windows Platform (UWP) app.  

> [!NOTE]
> The **Windows.ApplicationModel.Store** namespace is no longer being updated with new features. If your project targets **Windows 10 Anniversary Edition (10.0; Build 14393)** or a later release in Visual Studio (that is, you are targeting Windows 10, version 1607, or later), we recommend that you use the [Windows.Services.Store](../windows.services.store/windows_services_store.md) namespace instead. For more information, see [In-app purchases and trials](/windows/uwp/monetize/in-app-purchases-and-trials). The **Windows.ApplicationModel.Store** namespace is not supported in Windows desktop applications that use the [Desktop Bridge](https://developer.microsoft.com/windows/bridges/desktop) or in apps or games that use a development sandbox in [Partner Center](https://partner.microsoft.com/dashboard) (for example, this is the case for any game that integrates with Xbox Live). These products must use the [Windows.Services.Store](../windows.services.store/windows_services_store.md) namespace to implement in-app purchases and trials.

## -remarks

You can use members in this namespace to add in-app purchases and trial functionality to your Universal Windows Platform (UWP) app to help monetize your app. You can use members in this namespace to check the license state of your app and determine if it's a trial version or an active license. This namespace can be used by UWP apps that target any version of Windows 10.

You need a valid Windows Store developer account to interact with the Windows Store by using the [CurrentApp](currentapp.md) class. If you don't have a Windows Store developer account, you can use only the simulated functions in the [CurrentAppSimulator](currentappsimulator.md) class.

## -examples

## -see-also
[Store sample ()](https://github.com/Microsoft/Windows-universal-samples/tree/win10-1507/Samples/Store), [Trial app and in-app purchase sample ()](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Trial%20app%20and%20in-app%20purchase%20sample)
