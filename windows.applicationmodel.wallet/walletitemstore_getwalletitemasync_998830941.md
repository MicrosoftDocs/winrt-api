---
-api-id: M:Windows.ApplicationModel.Wallet.WalletItemStore.GetWalletItemAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Wallet.WalletItem> GetWalletItemAsync(System.String id)
-->

# Windows.ApplicationModel.Wallet.WalletItemStore.GetWalletItemAsync

## -description
Gets an individual wallet item with the given ID from the wallet database. The item requested must be owned by this app.

## -parameters
### -param id
The ID of the wallet item.

## -returns
An asynchronous operation that, on successful completion, returns the wallet item with the specified ID that is owned by this app. If you use [Asynchronous programming](http://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e), the result type is a single [WalletItem](walletitem.md). If an item with the specified ID cannot be found for this app in the current [WalletItemStore](walletitemstore.md) or if the item isn't owned by this app, the result is **null**.

## -remarks

## -examples

## -see-also
[Asynchronous programming](http://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e), [Quickstart: Using the   APIs](http://msdn.microsoft.com/library/4312628c-37a3-48a7-b41f-14605d478cf7)