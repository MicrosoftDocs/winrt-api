---
-api-id: N:Windows.Services.Store
-api-type: winrt namespace
---

# Windows.Services.Store

## -description
Provides types and members you can use to access and manage Windows Store-related data for the current app. For example, you can use this namespace to get Windows Store listing and license info for the current app, purchase the current app or products that are offered by the app, or download and install package updates for the app.

> [!NOTE]
> The [Windows.Services.Store](windows_services_store.md) namespace was introduced in Windows 10, version 1607, and the members of this namespace can only be used in apps that target this release or a later release. If your app targets an earlier version of Windows 10, you must use the [Windows.ApplicationModel.Store](../windows.applicationmodel.store/windows_applicationmodel_store.md) namespace instead of the [Windows.Services.Store](windows_services_store.md) namespace. For more information, see [In-app purchases and trials](https://msdn.microsoft.com/windows/uwp/monetize/in-app-purchases-and-trials).

## -remarks
The [StoreContext](storecontext.md) class is the main entry point to the [Windows.Services.Store](windows_services_store.md) namespace. Use members of this class to perform tasks such as getting Windows Store listing and license info for the current app, purchasing the current app or add-ons that are offered by the app, or downloading and installing package updates for the app. Other classes and types in this namespace represent items such as add-ons for the app, licenses for the app and its add-ons, and Windows Store listing info for the app.

## -examples

## -see-also
[In-app purchases and trials](https://msdn.microsoft.com/windows/uwp/monetize/in-app-purchases-and-trials), [Download and install package updates for your app](https://msdn.microsoft.com/windows/uwp/packaging/self-install-package-updates), [Store sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Store)
