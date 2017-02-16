---
-api-id: N:Windows.ApplicationModel.Store
-api-type: winrt namespace
---

# Windows.ApplicationModel.Store

## -description
Provides types and members for interacting with the Windows Store. You can use the members of this class to check the license state of the app and determine if it's a trial version or an active license. You can also check in-app features and enable in-app product purchases. This class also allows you to simulate these functions before you submit the app to the Windows Store.

You need a valid Windows Store developer account to interact with the Windows Store. If you don't have a Windows Store developer account, you can use only the simulated functions.

> [!NOTE]
> If your app targets Windows 10, version 1607 or later, we recommend that you use members of the [Windows.Services.Store](../windows.services.store/windows_services_store.md) namespace instead of the [Windows.ApplicationModel.Store](windows_applicationmodel_store.md) namespace. The [Windows.Services.Store](../windows.services.store/windows_services_store.md) namespace supports the latest add-on types, such as Store-managed consumable add-ons, and is designed to be compatible with future types of products and features supported by Windows Dev Center and the Store. The [Windows.Services.Store](../windows.services.store/windows_services_store.md) namespace is also designed to have better performance. For more information, see [In-app purchases and trials](https://msdn.microsoft.com/windows/uwp/monetize/in-app-purchases-and-trials).

## -remarks
> [!NOTE]
> The [Windows.ApplicationModel.Store](windows_applicationmodel_store.md) namespace is not supported in Windows desktop applications that use the [Desktop Bridge](https://developer.microsoft.com/windows/bridges/desktop). These applications must use the [Windows.Services.Store](../windows.services.store/windows_services_store.md) namespace to implement in-app purchases and trials. For more information, see [In-app purchases and trials](https://msdn.microsoft.com/windows/uwp/monetize/in-app-purchases-and-trials).

## -examples

## -see-also
[Store sample ()](https://github.com/Microsoft/Windows-universal-samples/tree/win10-1507/Samples/Store), [Trial app and in-app purchase sample ()](http://go.microsoft.com/fwlink/p/?LinkID=144754)