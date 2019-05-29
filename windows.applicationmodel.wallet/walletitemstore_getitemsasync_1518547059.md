---
-api-id: M:Windows.ApplicationModel.Wallet.WalletItemStore.GetItemsAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.ApplicationModel.Wallet.WalletItem>> GetItemsAsync()
-->

# Windows.ApplicationModel.Wallet.WalletItemStore.GetItemsAsync

## -description
Returns the collection of all wallet items owned by this app.

## -returns
An asynchronous operation that, on successful completion, returns the collection of wallet items accessible by this app. If you use [Asynchronous programming](https://docs.microsoft.com/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), the result type is a read-only list/vector of [WalletItem](walletitem.md) items. (You can use APIs of [IVectorView&lt;WalletItem&gt;](../windows.foundation.collections/ivectorview_1.md) for C++ or JavaScript, APIs of [IReadOnlyList<WalletItem>](https://docs.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist-1) for .NET.)

## -remarks

## -examples

## -see-also
[WalletItem](walletitem.md), [GetItemsAsync(WalletItemKind)](walletitemstore_getitemsasync_476546386.md), [IVectorView&lt;T&gt;](../windows.foundation.collections/ivectorview_1.md), [IReadOnlyList<T>](https://docs.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist-1), [Asynchronous programming](https://docs.microsoft.com/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps)
