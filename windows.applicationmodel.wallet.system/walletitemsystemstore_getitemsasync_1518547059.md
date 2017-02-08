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
An asynchronous operation that, on successful completion, returns the collection of wallet items accessible by this app. If you use [Asynchronous programming](http://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e), the result type is a read-only list/vector of [WalletItem](../windows.applicationmodel.wallet/walletitem.md) items. (You can use APIs of [IVectorView&lt;WalletItem&gt;](../windows.foundation.collections/ivectorview_1.md) for C++ or JavaScript, APIs of [IReadOnlyList&lt;WalletItem&gt;](XREF:TODO:T:System.Collections.Generic.IReadOnlyList`1) for .NET.)

## -remarks

## -examples

## -see-also


## -capabilities
walletSystem