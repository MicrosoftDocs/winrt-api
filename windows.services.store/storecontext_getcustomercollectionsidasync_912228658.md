---
-api-id: M:Windows.Services.Store.StoreContext.GetCustomerCollectionsIdAsync(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<string> GetCustomerCollectionsIdAsync(System.String serviceTicket, System.String publisherUserId)
-->

# Windows.Services.Store.StoreContext.GetCustomerCollectionsIdAsync

## -description
Retrieves a Microsoft Store ID key that can be used to query for product entitlements or to consume product entitlements that are owned by the current user.

## -parameters
### -param serviceTicket
An Azure Active Directory access token that identifies the publisher of the current app. For more information about generating this token, see [Manage product entitlements from a service](/windows/uwp/monetize/view-and-grant-products-from-a-service).

### -param publisherUserId
An anonymous ID that identifies the current user in the context of services that you manage as the publisher of the current app. If you maintain user IDs in the context of your services, you can use this parameter to associate your ID for the current user with the new Microsoft Store ID key (the user ID will be embedded in the key). Otherwise, if you don't need to associate a user ID with the Microsoft Store ID key, you can pass any string value.

## -returns
An asynchronous operation that, on successful completion, returns the collections ID key for the current user. This key is valid for 30 days.

## -remarks
Publishers with catalogs of in-app purchases can use the Microsoft Store ID key in service-to-service calls to the Microsoft Store collections API to query for product entitlements or to consume product entitlements that are owned by the current user. An *entitlement* represents the customer's right to use an app or add-on that is published through the Microsoft Store. For more information, see [Manage product entitlements from a service](/windows/uwp/monetize/view-and-grant-products-from-a-service).

## -examples

## -see-also
[Manage product entitlements from a service](/windows/uwp/monetize/view-and-grant-products-from-a-service),[Store sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Store)
