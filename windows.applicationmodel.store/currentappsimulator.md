---
-api-id: T:Windows.ApplicationModel.Store.CurrentAppSimulator
-api-type: winrt class
---

<!-- Class syntax.
public class CurrentAppSimulator
-->

# Windows.ApplicationModel.Store.CurrentAppSimulator

## -description
Defines methods and properties used to instantiate an object that you can use to get simulated license info during testing.

> [!NOTE]
> The **CurrentAppSimulator** class and the other types in the [Windows.ApplicationModel.Store](windows_applicationmodel_store.md) namespace are no longer being updated with new features. If your project targets **Windows 10 Anniversary Edition (10.0; Build 14393)** or a later release in Visual Studio (that is, you are targeting Windows 10, version 1607, or later), we recommend that you use the [Windows.Services.Store](../windows.services.store/windows_services_store.md) namespace instead. For more information, see [In-app purchases and trials](/windows/uwp/monetize/in-app-purchases-and-trials). The **CurrentAppSimulator** class is not supported in Windows desktop applications that use the [Desktop Bridge](https://developer.microsoft.com/windows/bridges/desktop) or in apps or games that use a development sandbox in [Partner Center](https://partner.microsoft.com/dashboard) (for example, this is the case for any game that integrates with Xbox Live). These products must use the [Windows.Services.Store](../windows.services.store/windows_services_store.md) namespace to implement in-app purchases and trials.

## -remarks
Until the app has been listed in the Microsoft Store, the [CurrentApp](currentapp.md) object won't work in the app. Use the CurrentAppSimulator to test your app's licensing and in-app products while you develop your app. After you test your app, and before you submit it to the Microsoft Store, you must replace the instances of CurrentAppSimulator with [CurrentApp](currentapp.md). Your app will fail certification if it uses CurrentAppSimulator.

When the CurrentAppSimulator is used, the initial licensing state of the app is described in a file named WindowsStoreProxy.xml. CurrentAppSimulator methods that alter the license state, for example by buying a license or handling an in-app purchase, only update the license state of the object in memory. The contents of WindowsStoreProxy.xml are not changed. When the app starts again, the license state reverts to what is described in WindowsStoreProxy.xml.

For more information about the WindowsStoreProxy.xml file, see [Using the WindowsStoreProxy.xml file with CurrentAppSimulator](/windows/uwp/monetize/in-app-purchases-and-trials-using-the-windows-applicationmodel-store-namespace).

## -examples

## -see-also
[Store sample ()](https://github.com/Microsoft/Windows-universal-samples/tree/win10-1507/Samples/Store), [Trial app and in-app purchase sample ()](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Trial%20app%20and%20in-app%20purchase%20sample)
