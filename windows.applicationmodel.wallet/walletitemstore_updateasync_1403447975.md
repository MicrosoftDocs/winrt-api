---
-api-id: M:Windows.ApplicationModel.Wallet.WalletItemStore.UpdateAsync(Windows.ApplicationModel.Wallet.WalletItem)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction UpdateAsync(Windows.ApplicationModel.Wallet.WalletItem item)
-->

# Windows.ApplicationModel.Wallet.WalletItemStore.UpdateAsync

## -description
> [!CAUTION]
> The ApplicationModel.Wallet namespace is no longer supported, and will soon be deprecated. Developers are encouraged to avoid using this namespace.

Updates a wallet item in the shared store, based on the changed values in the [WalletItem](walletitem.md) object provided.

## -parameters
### -param item
The updated data for the wallet item.

## -returns
An asynchronous action. If you use [Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), the result type is **void**.

## -remarks
An exception is thrown if the item doesn't already exist in the wallet. How to handle errors/exceptions varies by programming language, particularly so when calling asynchronous methods. See [Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps).

Most of the APIs for this class can be seen in example usages in the [Quickstart: Using the   APIs](/previous-versions/windows/apps/dn631257(v=win.10)) topic.

## -examples

## -see-also
[Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps)
