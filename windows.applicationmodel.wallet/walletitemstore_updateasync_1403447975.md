---
-api-id: M:Windows.ApplicationModel.Wallet.WalletItemStore.UpdateAsync(Windows.ApplicationModel.Wallet.WalletItem)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction UpdateAsync(Windows.ApplicationModel.Wallet.WalletItem item)
-->

# Windows.ApplicationModel.Wallet.WalletItemStore.UpdateAsync

## -description
Updates a wallet item in the shared store, based on the changed values in the [WalletItem](walletitem.md) object provided.

## -parameters
### -param item
The updated data for the wallet item.

## -returns
An asynchronous action. If you use [Asynchronous programming](http://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e), the result type is **void**.

## -remarks
An exception is thrown if the item doesn't already exist in the wallet. How to handle errors/exceptions varies by programming language, particularly so when calling asynchronous methods. See [Asynchronous programming](http://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e).

Most of the APIs for this class can be seen in example usages in the [Quickstart: Using the   APIs](http://msdn.microsoft.com/library/4312628c-37a3-48a7-b41f-14605d478cf7) topic.

## -examples

## -see-also
[Asynchronous programming](http://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e)