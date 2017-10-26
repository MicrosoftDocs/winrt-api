---
-api-id: M:Windows.ApplicationModel.Store.CurrentApp.RequestProductPurchaseAsync(System.String,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<string> RequestProductPurchaseAsync(System.String productId, System.Boolean includeReceipt)
-->

# Windows.ApplicationModel.Store.CurrentApp.RequestProductPurchaseAsync

## -description
> [!NOTE]
> [RequestProductPurchaseAsync(String, Boolean)](currentapp_requestproductpurchaseasync_1631257175.md) may be altered or unavailable for releases after Windows 8.1. Instead, use [RequestProductPurchaseAsync(String)](currentapp_requestproductpurchaseasync_2091240017.md).

Requests the purchase of an add-on (also called an in-app product or IAP). Additionally, calling this method displays the UI that is used to complete the transaction via the Microsoft Store.

## -parameters
### -param productId
The product ID of the add-on to purchase.

### -param includeReceipt
Determines if the method should return the receipts for the specified *productId.*

## -returns
A string providing in-app transaction details for the provided *productId*. If *includeReceipt* is set **true**, the returned string will include a full receipt xml.

## -remarks
The remarks for [RequestProductPurchaseAsync(String)](currentapp_requestproductpurchaseasync_2091240017.md) also apply to this overload.

To confirm whether the product license is active after a successful call to this overload, use the [LicenseInformation.IsActive](licenseinformation_isactive.md) property.

## -examples

## -see-also
[RequestProductPurchaseAsync(String)](currentapp_requestproductpurchaseasync_2091240017.md)