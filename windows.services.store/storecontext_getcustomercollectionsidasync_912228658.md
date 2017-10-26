---
-api-id: M:Windows.Services.Store.StoreContext.GetCustomerCollectionsIdAsync(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<string> GetCustomerCollectionsIdAsync(System.String serviceTicket, System.String publisherUserId)
-->

# Windows.Services.Store.StoreContext.GetCustomerCollectionsIdAsync

## -description
Retrieves a Microsoft Store collections ID key that can be used to query for product entitlements or to consume product entitlements that are owned by the current user.

## -parameters
### -param serviceTicket
An Azure Active Directory access token that identifies the publisher of the current app. For more information about generating this token, see [Manage product entitlements from a service](https://msdn.microsoft.com/windows/uwp/monetize/view-and-grant-products-from-a-service).

### -param publisherUserId
An anonymous ID that identifies the current user in the context of services that are managed by the publisher of the current app. If the publisher maintains anonymous user IDs for use in their services, they can use this parameter to correlate these user IDs with the calls they make to Microsoft Store services. This parameter is optional.

## -returns
An asynchronous operation that, on successful completion, returns the collections ID key for the current user. This key is valid for 90 days.

## -remarks
Publishers with catalogs of in-app purchases can use the collections ID key in service-to-service calls to the Microsoft Store collections API to query for product entitlements or to consume product entitlements that are owned by the current user. An *entitlement* represents the customer's right to use an app or add-on that is published through the Microsoft Store. For more information, see [Manage product entitlements from a service](https://msdn.microsoft.com/windows/uwp/monetize/view-and-grant-products-from-a-service).

## -examples

## -see-also
[Manage product entitlements from a service](https://msdn.microsoft.com/windows/uwp/monetize/view-and-grant-products-from-a-service)
