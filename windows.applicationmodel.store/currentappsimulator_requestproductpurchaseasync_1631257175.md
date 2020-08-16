---
-api-id: M:Windows.ApplicationModel.Store.CurrentAppSimulator.RequestProductPurchaseAsync(System.String,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<string> RequestProductPurchaseAsync(System.String productId, System.Boolean includeReceipt)
-->

# Windows.ApplicationModel.Store.CurrentAppSimulator.RequestProductPurchaseAsync

## -description
> [!NOTE]
> [RequestProductPurchaseAsync(String, Boolean) may be altered or unavailable for releases after Windows 8.1. Instead, use [RequestProductPurchaseAsync(String)](currentappsimulator_requestproductpurchaseasync_2091240017.md).

Creates the async operation that displays the UI that is used to simulate the purchase of an add-on (also called an in-app product or IAP) from the Microsoft Store.

## -parameters
### -param productId
The product ID (as defined by the simulation) of the add-on to purchase.

### -param includeReceipt
Determines if the method should return the receipts for the specified *productId.*

## -returns
A string providing in-app product purchase details for the provided *productId*. If *includeReceipt* is set **true**, the returned string will include a full receipt xml.

## -remarks
The remarks for [RequestProductPurchaseAsync(String)](currentappsimulator_requestproductpurchaseasync_2091240017.md) also apply to this overload.

To confirm whether the product license is active after a successful call to this overload, use the [LicenseInformation.IsActive](licenseinformation_isactive.md) property.

You can see an example of how to use this method in our [code sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Trial%20app%20and%20in-app%20purchase%20sample).

## -examples

## -see-also
[RequestProductPurchaseAsync(String)](currentappsimulator_requestproductpurchaseasync_2091240017.md)
