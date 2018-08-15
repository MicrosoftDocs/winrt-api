---
-api-id: T:Windows.Services.Store.StoreContext
-api-type: winrt class
---

<!-- Class syntax.
public class StoreContext : Windows.Services.Store.IStoreContext, Windows.Services.Store.IStoreContext2
-->

# Windows.Services.Store.StoreContext

## -description
Provides members you can use to access and manage Microsoft Store-related data for the current app. For example, you can use members of this class to get Microsoft Store listing and license info for the current app, purchase the current app or products that are offered by the app, or download and install package updates for the app.

## -remarks

> [!NOTE]
> This class and the rest of the [Windows.Services.Store](windows_services_store.md) namespace was introduced in Windows 10, version 1607. This class can only be used in projects that target **Windows 10 Anniversary Edition (10.0; Build 14393)** or a later release in Visual Studio. If your project targets an earlier version of Windows 10, you must use the [Windows.ApplicationModel.Store](../windows.applicationmodel.store/windows_applicationmodel_store.md) namespace instead of the [Windows.Services.Store](windows_services_store.md) namespace. For more information, see [In-app purchases and trials](https://msdn.microsoft.com/windows/uwp/monetize/in-app-purchases-and-trials).

The [StoreContext](storecontext.md) class is the main entry point to the [Windows.Services.Store](windows_services_store.md) namespace. Use members of this class to perform tasks such as getting Microsoft Store listing and license info for the current app, purchasing the current app or add-ons that are offered by the app, or downloading and installing package updates for the app. Other classes and types in this namespace represent items such as add-ons for the app, licenses for the app and its add-ons, and Microsoft Store listing info for the app.

To get a [StoreContext](storecontext.md) object, use one of these static methods:

+ [GetDefault](storecontext_getdefault_846721868.md): Use this method in single-user apps (that is, apps that run only in the context of the user that launched the app). This method gets a [StoreContext](storecontext.md) object that you can use to access and manage Microsoft Store-related data for the user. Most Universal Windows Platform (UWP) apps are single-user apps.

  ```csharp
  Windows.Services.Store.StoreContext context = StoreContext.GetDefault();
  ```

+ [GetForUser](storecontext_getforuser_2058550280.md): Use this method in multi-user apps. This method gets a [StoreContext](storecontext.md) object that you can use to access and manage Microsoft Store-related data for a specific user. For more information about multi-user apps, see [Introduction to multi-user applications](https://msdn.microsoft.com/windows/uwp/xbox-apps/multi-user-applications).

  ```csharp
  var users = await Windows.System.User.FindAllAsync();
  Windows.Services.Store.StoreContext context = StoreContext.GetForUser(users[0]);
  ```

> [!NOTE]
> In a Windows desktop application that uses the [Desktop Bridge](https://developer.microsoft.com/windows/bridges/desktop), you must add some additional code to configure the [StoreContext](storecontext.md) object before your app can use this object. For more information, see [Using the StoreContext class in a desktop application that uses the Desktop Bridge](https://msdn.microsoft.com/windows/uwp/monetize/in-app-purchases-and-trials#desktop).

After you have a [StoreContext](storecontext.md) object, you can start calling methods to purchase an app or add-on for the current user and other tasks. For more information, see the following articles:
+ [In-app purchases and trials](https://msdn.microsoft.com/windows/uwp/monetize/in-app-purchases-and-trials)
+ [Get product info for apps and add-ons](https://msdn.microsoft.com/windows/uwp/monetize/get-product-info-for-apps-and-add-ons)
+ [Get license info for apps and add-ons](https://msdn.microsoft.com/windows/uwp/monetize/get-license-info-for-apps-and-add-ons)
+ [Enable in-app purchases of apps and add-ons](https://msdn.microsoft.com/windows/uwp/monetize/enable-in-app-purchases-of-apps-and-add-ons)
+ [Enable consumable add-on purchases](https://msdn.microsoft.com/windows/uwp/monetize/enable-consumable-add-on-purchases)
+ [Implement a trial version of your app](https://msdn.microsoft.com/windows/uwp/monetize/implement-a-trial-version-of-your-app)


You can also use a [StoreContext](storecontext.md) object to download and install package updates for the app. For more information, see [Download and install package updates for your app](https://msdn.microsoft.com/windows/uwp/packaging/self-install-package-updates).

## -examples

## -see-also
[In-app purchases and trials](https://msdn.microsoft.com/windows/uwp/monetize/in-app-purchases-and-trials), [Download and install package updates for your app](https://msdn.microsoft.com/windows/uwp/packaging/self-install-package-updates), [Store sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Store)
