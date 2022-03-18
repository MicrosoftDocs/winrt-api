---
-api-id: M:Windows.ApplicationModel.Wallet.System.WalletItemSystemStore.ImportItemAsync(Windows.Storage.Streams.IRandomAccessStreamReference)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Wallet.WalletItem> ImportItemAsync(Windows.Storage.Streams.IRandomAccessStreamReference stream)
-->

# Windows.ApplicationModel.Wallet.System.WalletItemSystemStore.ImportItemAsync

## -description
Imports data from a ".mswallet" XML file into the system wallet store.

> [!NOTE]
> This API is not available to all Windows apps. Unless your developer account is specially provisioned by Microsoft, calls to these APIs will fail at runtime.

## -parameters
### -param stream
The ".mswallet" file to import.

## -returns
An asynchronous operation that, on successful completion, returns the wallet item that was imported into the wallet. If you use [Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), the result type on successful completion is a single [WalletItem](../windows.applicationmodel.wallet/walletitem.md).

## -remarks

## -examples

## -see-also


## -capabilities
walletSystem
