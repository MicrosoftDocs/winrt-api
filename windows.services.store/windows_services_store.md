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
The [StoreContext](storecontext.md) class is the primary class in the [Windows.Services.Store](windows_services_store.md) namespace. This class provides members that you use to access and manage Windows Store-related data for the current app. Other classes and types in this namespace represent Windows Store-related data objects such as products that are offered for sale by the app, licenses for the app and its products, and Windows Store listing info for the app.

To get a [StoreContext](storecontext.md) object, use one of these static methods of the [StoreContext](storecontext.md) class:

* [GetDefault](storecontext_getdefault.md): Use this method in single-user apps (that is, apps that run only in the context of the user that launched the app). This method gets a [StoreContext](storecontext.md) object that you can use to access and manage Windows Store-related data for the user. Most Universal Windows Platform (UWP) apps are single-user apps.

  ```csharp
  Windows.Services.Store.StoreContext context = StoreContext.GetDefault();
  ```

* [GetForUser](storecontext_getforuser.md). Use this method in multi-user apps. This method gets a [StoreContext](storecontext.md) object that you can use to access and manage Windows Store-related data for a specific user. For more information about multi-user apps, see [Introduction to multi-user applications](https://msdn.microsoft.com/windows/uwp/xbox-apps/multi-user-applications).

  ```csharp
  var users = await Windows.System.User.FindAllAsync();
  Windows.Services.Store.StoreContext context = StoreContext.GetForUser(users[0]);
  ```

After you have a [StoreContext](storecontext.md), you can start calling methods to purchase an app or add-on for the current user and other tasks. For more information, see the following articles:
+ [In-app purchases and trials](https://msdn.microsoft.com/windows/uwp/monetize/in-app-purchases-and-trials)
+ [Get product info for apps and add-ons](https://msdn.microsoft.com/windows/uwp/monetize/get-product-info-for-apps-and-add-ons)
+ [Get license info for apps and add-ons](https://msdn.microsoft.com/windows/uwp/monetize/get-license-info-for-apps-and-add-ons)
+ [Enable in-app purchases of apps and add-ons](https://msdn.microsoft.com/windows/uwp/monetize/enable-in-app-purchases-of-apps-and-add-ons)
+ [Enable consumable add-on purchases](https://msdn.microsoft.com/windows/uwp/monetize/enable-consumable-add-on-purchases)
+ [Implement a trial version of your app](https://msdn.microsoft.com/windows/uwp/monetize/implement-a-trial-version-of-your-app)


## -examples

## -see-also
[Store sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Store)
