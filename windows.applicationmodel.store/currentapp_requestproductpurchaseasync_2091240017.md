---
-api-id: M:Windows.ApplicationModel.Store.CurrentApp.RequestProductPurchaseAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Store.PurchaseResults> RequestProductPurchaseAsync(System.String productId)
-->

# Windows.ApplicationModel.Store.CurrentApp.RequestProductPurchaseAsync

## -description
Requests the purchase of an add-on (also called an in-app product or IAP). Additionally, calling this method displays the UI that is used to complete the transaction via the Microsoft Store.

## -parameters
### -param productId
The product ID of the add-on to purchase.

## -returns
A [PurchaseResults](purchaseresults.md) that contains the results of the in-app product purchase request.

## -remarks
The product ID is the string that the app uses to identify the add-on. You enter the product ID when [submitting your add-on](/windows/uwp/publish/set-your-add-on-product-id) in [Partner Center](https://partner.microsoft.com/dashboard), where it is associated with the description, price tier and lifetime. For more information, see [How to use product IDs for add-ons in your code](/windows/uwp/monetize/in-app-purchases-and-trials#how-to-use-product-ids-for-add-ons-in-your-code).

You can see an example of how to use this method in our [code sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Trial%20app%20and%20in-app%20purchase%20sample).

## -examples

## -see-also
[RequestProductPurchaseAsync(String, Boolean)](currentapp_requestproductpurchaseasync_1631257175.md)
