---
-api-id: P:Windows.Services.Store.StoreContext.User
-api-type: winrt property
---

<!-- Property syntax
public Windows.System.User User { get; }
-->

# Windows.Services.Store.StoreContext.User

## -description
Gets info about the user that is associated with the current [StoreContext](storecontext.md) object in a multi-user app.

## -property-value
An object that provides info about the user that is associated with the current [StoreContext](storecontext.md) object in a multi-user app.

## -remarks
This property is only intended to be used in the context of a [multi-user app](/windows/uwp/xbox-apps/multi-user-applications). In this scenario, the **User** property returns the same [User](../windows.system/user.md) object that you passed to the [GetForUser](storecontext_getforuser_2058550280.md) method when you created the [StoreContext](storecontext.md) object for a specific user.

If your app is a single-user app, (that is, it runs only in the context of the user that launched the app), this property returns **null**. 

## -examples

## -see-also
