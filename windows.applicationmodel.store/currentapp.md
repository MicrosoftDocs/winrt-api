---
-api-id: T:Windows.ApplicationModel.Store.CurrentApp
-api-type: winrt class
---

<!-- Class syntax.
public class CurrentApp
-->

# Windows.ApplicationModel.Store.CurrentApp

## -description
Defines methods and properties you can use to get license and listing info about the current app and perform in-app product purchases.

## -remarks
This object obtains its data from the Windows Store, so you must have a developer account and the app must be published in the Windows Store. Before submitting to the Windows Store, you can test your code with a simulated version of this class (whose state is initialized from an XML file). See [CurrentAppSimulator](currentappsimulator.md).

> [!NOTE]
> If your app targets Windows 10, version 1607 or later, we recommend that you use members of the [Windows.Services.Store](../windows.services.store/windows_services_store.md) namespace instead of the [Windows.ApplicationModel.Store](windows_applicationmodel_store.md) namespace. The [Windows.Services.Store](../windows.services.store/windows_services_store.md) namespace supports the latest add-on types, such as Store-managed consumable add-ons, and is designed to be compatible with future types of products and features supported by Windows Dev Center and the Store. The [Windows.Services.Store](../windows.services.store/windows_services_store.md) namespace is also designed to have better performance. For more information, see [In-app purchases and trials](https://msdn.microsoft.com/windows/uwp/monetize/in-app-purchases-and-trials).
>
> The [CurrentApp](currentapp.md) class is not supported in Windows desktop applications that use the [Desktop Bridge](https://developer.microsoft.com/windows/bridges/desktop). These applications must use the [Windows.Services.Store](../windows.services.store/windows_services_store.md) namespace to implement in-app purchases and trials. For more information, see [In-app purchases and trials](https://msdn.microsoft.com/windows/uwp/monetize/in-app-purchases-and-trials).

## -examples

## -see-also
[Store sample ()](https://github.com/Microsoft/Windows-universal-samples/tree/win10-1507/Samples/Store), [Trial app and in-app purchase sample ()](http://go.microsoft.com/fwlink/p/?LinkID=144754)
