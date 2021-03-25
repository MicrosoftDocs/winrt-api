---
-api-id: M:Windows.ApplicationModel.Wallet.WalletItemStore.AddAsync(System.String,Windows.ApplicationModel.Wallet.WalletItem)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction AddAsync(System.String id, Windows.ApplicationModel.Wallet.WalletItem item)
-->

# Windows.ApplicationModel.Wallet.WalletItemStore.AddAsync

## -description
> [!CAUTION]
> The ApplicationModel.Wallet namespace is no longer supported, and will soon be deprecated. Developers are encouraged to avoid using this namespace.

Adds a new wallet item to the wallet.

## -parameters
### -param id
The identifier of the wallet item. This value must be unique. This sets the initial [WalletItem.Id](walletitem_id.md) value (the identifier is for the [WalletItemStore](walletitemstore.md) store, and isn't part of the initialization of a [WalletItem](walletitem.md) object.

### -param item
The wallet item to add to the wallet.

## -returns
An asynchronous action. If you use [Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), the return type is **void**.

## -remarks
If the *id* value passed in to this method is not unique, or if the item has already been added to the wallet, an exception is thrown. How to handle errors/exceptions varies by programming language, particularly so when calling asynchronous methods. See [Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps).

Remember that when you call this method, the item is added to the wallet item store, which is owned by the device not the app. While you're still developing, the store persists across app sessions, and so attempting to add the same item again when running another debug session can throw an exception because the item's already there. Consider adding a call to [ClearAsync](walletitemstore_clearasync_1031039026.md) before you attempt to add any items and you've run your code more than once, at least while you're still developing and testing your code.

## -examples

## -see-also
[Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), [Quickstart: Using the   APIs](/previous-versions/windows/apps/dn631257(v=win.10))
