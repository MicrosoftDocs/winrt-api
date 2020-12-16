---
-api-id: M:Windows.ApplicationModel.Wallet.System.WalletItemSystemStore.GetItemsAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.ApplicationModel.Wallet.WalletItem>> GetItemsAsync()
-->

# Windows.ApplicationModel.Wallet.System.WalletItemSystemStore.GetItemsAsync

## -description
Returns the collection of all system wallet items owned by this app.

> [!NOTE]
> This API is not available to all Windows apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -returns
An asynchronous operation that, on successful completion, returns the collection of wallet items accessible by this app. If you use [Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), the result type is a read-only list/vector of [WalletItem](../windows.applicationmodel.wallet/walletitem.md) items. (You can use APIs of [IVectorView<WalletItem>](../windows.foundation.collections/ivectorview_1.md) for C++ or JavaScript, APIs of [IReadOnlyList<WalletItem>](/dotnet/api/system.collections.generic.ireadonlylist-1?view=dotnet-uwp-10.0&preserve-view=true) for .NET.)

## -remarks

## -examples

## -see-also


## -capabilities
walletSystem
