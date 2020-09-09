---
-api-id: M:Windows.ApplicationModel.Store.CurrentApp.GetProductReceiptAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<string> GetProductReceiptAsync(System.String productId)
-->

# Windows.ApplicationModel.Store.CurrentApp.GetProductReceiptAsync

## -description
Requests the receipt for the specified product ID. For examples of how receipt information can be used, see [Using receipts to verify product purchases](/windows/uwp/monetize/use-receipts-to-verify-product-purchases).

## -parameters
### -param productId
The unique identifier for the product that you specified this identifier when you submitted the app to the Microsoft Store

## -returns
An XML-formatted string that contains the receipt for the specified *productId.*

## -remarks
For more information about the contents of the receipt, see [Using receipts to verify product purchases](/windows/uwp/monetize/use-receipts-to-verify-product-purchases).

## -examples

## -see-also
