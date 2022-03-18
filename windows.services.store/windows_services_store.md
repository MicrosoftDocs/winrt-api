---
-api-id: N:Windows.Services.Store
-api-type: winrt namespace
---

# Windows.Services.Store

## -description
Provides types and members you can use to access and manage Microsoft Store-related data for the current app. For example, you can use this namespace to get Microsoft Store listing and license info for the current app, purchase the current app or products that are offered by the app, or download and install package updates for the app.

> [!NOTE]
> This namespace was introduced in Windows 10, version 1607, and it can only be used in projects that target **Windows 10 Anniversary Edition (10.0; Build 14393)** or a later release in Visual Studio. If your project targets an earlier version of Windows 10, you must use the [Windows.ApplicationModel.Store](../windows.applicationmodel.store/windows_applicationmodel_store.md) namespace instead of the Windows.Services.Store namespace. For more information, see [In-app purchases and trials](/windows/uwp/monetize/in-app-purchases-and-trials).

## -remarks
The [StoreContext](storecontext.md) class is the main entry point to the Windows.Services.Store namespace. Use members of this class to perform tasks such as getting Microsoft Store listing and license info for the current app, purchasing the current app or add-ons that are offered by the app, or downloading and installing package updates for the app. Other classes and types in this namespace represent items such as add-ons for the app, licenses for the app and its add-ons, and Microsoft Store listing info for the app.

## -examples

## -see-also
[In-app purchases and trials](/windows/uwp/monetize/in-app-purchases-and-trials), [Download and install package updates for your app](/windows/uwp/packaging/self-install-package-updates), [Store sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Store)
