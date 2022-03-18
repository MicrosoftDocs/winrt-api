---
-api-id: M:Windows.ApplicationModel.Store.CurrentAppSimulator.GetProductReceiptAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<string> GetProductReceiptAsync(System.String productId)
-->

# Windows.ApplicationModel.Store.CurrentAppSimulator.GetProductReceiptAsync

## -description
Creates the async operation that the user can use to simulate requesting the receipt for the specified product ID. For examples of how receipt information can be used, see [Using receipts to verify product purchases](/windows/uwp/monetize/use-receipts-to-verify-product-purchases).

## -parameters
### -param productId
The unique identifier for the product. This ID is that was specified when the product was submitted for the app to the Store.

## -returns
An XML-formatted string that contains the receipt for the specified product ID.

## -remarks
For more information about the contents of the receipt, see [Using receipts to verify product purchases](/windows/uwp/monetize/use-receipts-to-verify-product-purchases).

## -examples

## -see-also
