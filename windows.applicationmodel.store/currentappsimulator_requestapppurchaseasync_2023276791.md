---
-api-id: M:Windows.ApplicationModel.Store.CurrentAppSimulator.RequestAppPurchaseAsync(System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<string> RequestAppPurchaseAsync(System.Boolean includeReceipt)
-->

# Windows.ApplicationModel.Store.CurrentAppSimulator.RequestAppPurchaseAsync

## -description
Creates the async operation that simulates a user request to buy a full license for the current app.

## -parameters
### -param includeReceipt
Determines if the method should return the receipts for this app.

## -returns
If the *includeReceipt* parameter is set to true, this string contains XML that represents all receipts for the app and any in-app product purchases. If *includeReceipt* is set to false, this string is empty.

## -remarks
This method returns a success value even if:
+ No network connection is available.
+ The user cancels out of the dialog.
+ The user's authentication fails.
 You should treat a success result as indicating the async process completed without errors. To ensure that the transaction itself was successful, check the **LicenseInformation** element in the returned receipt.

For more information about the contents of the receipt, see [Using receipts to verify product purchases](/windows/uwp/monetize/use-receipts-to-verify-product-purchases).

## -examples

## -see-also
