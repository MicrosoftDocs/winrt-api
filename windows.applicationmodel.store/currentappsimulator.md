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

## -remarks
Until the app has been listed in the Windows Store, the [CurrentApp](currentapp.md) object won't work in the app. Use the [CurrentAppSimulator](currentappsimulator.md) to test your app's licensing and in-app products while you develop your app. After you test your app, and before you submit it to the Windows Store, you must replace the instances of [CurrentAppSimulator](currentappsimulator.md) with [CurrentApp](currentapp.md). Your app will fail certification if it uses [CurrentAppSimulator](currentappsimulator.md).

When the [CurrentAppSimulator](currentappsimulator.md) is used, the initial licensing state of the app is described in a file named WindowsStoreProxy.xml. [CurrentAppSimulator](currentappsimulator.md) methods that alter the license state, for example by buying a license or handling an in-app purchase, only update the license state of the object in memory. The contents of WindowsStoreProxy.xml are not changed. When the app starts again, the license state reverts to what is described in WindowsStoreProxy.xml.

For more information about the WindowsStoreProxy.xml file, see [Using the WindowsStoreProxy.xml file with CurrentAppSimulator](https://msdn.microsoft.com/windows/uwp/monetize/in-app-purchases-and-trials-using-the-windows-applicationmodel-store-namespace#proxy).

> [!NOTE]
> If your app targets Windows 10, version 1607 or later, we recommend that you use members of the [Windows.Services.Store](../windows.services.store/windows_services_store.md) namespace instead of the [Windows.ApplicationModel.Store](windows_applicationmodel_store.md) namespace. The [Windows.Services.Store](../windows.services.store/windows_services_store.md) namespace supports the latest add-on types, such as Store-managed consumable add-ons, and is designed to be compatible with future types of products and features supported by Windows Dev Center and the Store. The [Windows.Services.Store](../windows.services.store/windows_services_store.md) namespace is also designed to have better performance. For more information, see [In-app purchases and trials](https://msdn.microsoft.com/windows/uwp/monetize/in-app-purchases-and-trials).

## -examples

## -see-also
[Store sample ()](https://github.com/Microsoft/Windows-universal-samples/tree/win10-1507/Samples/Store), [Trial app and in-app purchase sample ()](http://go.microsoft.com/fwlink/p/?LinkID=144754)
