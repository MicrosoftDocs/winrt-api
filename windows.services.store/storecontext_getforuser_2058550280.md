---
-api-id: M:Windows.Services.Store.StoreContext.GetForUser(Windows.System.User)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Services.Store.StoreContext GetForUser(Windows.System.User user)
-->

# Windows.Services.Store.StoreContext.GetForUser

## -description
Gets a [StoreContext](storecontext.md) object that can be used to access and manage Microsoft Store-related data for the specified user in the context of the current app.

## -parameters
### -param user
An object that identifies the user whose Microsoft Store-related data you want to access and manage.

## -returns
An object that you can use to access and manage Microsoft Store-related data for the specified user.

## -remarks
If your app is a multi-user app, use the GetForUser method to get a [StoreContext](storecontext.md) object that you can use to access and manage Microsoft Store-related data for a specific user who is signed in with their Microsoft account while using the app. For more information about this method, see [In-app purchases and trials](/windows/uwp/monetize/in-app-purchases-and-trials). For more information about multi-user apps, see [Introduction to multi-user applications](/windows/uwp/xbox-apps/multi-user-applications).

If your app is a single-user app (that is, it runs only in the context of the user that launched the app), use the [GetDefault](storecontext_getdefault_846721868.md) method to get a [StoreContext](storecontext.md) object for the current user. Most Universal Windows Platform (UWP) apps are single-user apps.

## -examples

## -see-also
[In-app purchases and trials](/windows/uwp/monetize/in-app-purchases-and-trials)
