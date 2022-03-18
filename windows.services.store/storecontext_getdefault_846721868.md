---
-api-id: M:Windows.Services.Store.StoreContext.GetDefault
-api-type: winrt method
---

<!-- Method syntax
public Windows.Services.Store.StoreContext GetDefault()
-->

# Windows.Services.Store.StoreContext.GetDefault

## -description
Gets a [StoreContext](storecontext.md) object that can be used to access and manage Microsoft Store-related data for the current user in the context of the current app.

## -returns
An object that you can use to access and manage Microsoft Store-related data for the current user.

## -remarks
If your app is a single-user app (that is, it runs only in the context of the user that launched the app), use the GetDefault method to get a [StoreContext](storecontext.md) object that you can use to access and manage Microsoft Store-related data for the user. Most Universal Windows Platform (UWP) apps are single-user apps. For more information about this method, see [In-app purchases and trials](/windows/uwp/monetize/in-app-purchases-and-trials).

If your app is a multi-user app, use the [GetForUser](storecontext_getforuser_2058550280.md) method to get a [StoreContext](storecontext.md) object for a specific user.

## -examples

## -see-also
[In-app purchases and trials](/windows/uwp/monetize/in-app-purchases-and-trials), [Store sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Store)
