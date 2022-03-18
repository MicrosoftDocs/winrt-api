---
-api-id: M:Windows.ApplicationModel.Wallet.WalletItemStore.GetWalletItemAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Wallet.WalletItem> GetWalletItemAsync(System.String id)
-->

# Windows.ApplicationModel.Wallet.WalletItemStore.GetWalletItemAsync

## -description
> [!CAUTION]
> The ApplicationModel.Wallet namespace is no longer supported, and will soon be deprecated. Developers are encouraged to avoid using this namespace.

Gets an individual wallet item with the given ID from the wallet database. The item requested must be owned by this app.

## -parameters
### -param id
The ID of the wallet item.

## -returns
An asynchronous operation that, on successful completion, returns the wallet item with the specified ID that is owned by this app. If you use [Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), the result type is a single [WalletItem](walletitem.md). If an item with the specified ID cannot be found for this app in the current [WalletItemStore](walletitemstore.md) or if the item isn't owned by this app, the result is **null**.

## -remarks

## -examples

## -see-also
[Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), [Quickstart: Using the   APIs](/previous-versions/windows/apps/dn631257(v=win.10))
