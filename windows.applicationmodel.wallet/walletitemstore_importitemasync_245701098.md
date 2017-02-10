---
-api-id: M:Windows.ApplicationModel.Wallet.WalletItemStore.ImportItemAsync(Windows.Storage.Streams.IRandomAccessStreamReference)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Wallet.WalletItem> ImportItemAsync(Windows.Storage.Streams.IRandomAccessStreamReference stream)
-->

# Windows.ApplicationModel.Wallet.WalletItemStore.ImportItemAsync

## -description
Imports data from a ".mswallet" XML file into the wallet store.".mswallet" is an XML serialization format for wallet item info. For a guide to the ".mswallet" format (and a link to schema in XSD), see [Quickstart: Creating and distributing .mswallet files](http://msdn.microsoft.com/library/44575995-b45d-4458-b0ac-36dc0df373aa).

## -parameters
### -param stream
The ".mswallet" file to import.

## -returns
An asynchronous operation that, on successful completion, returns the wallet item that was imported into the wallet. If you use [Asynchronous programming](http://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e), the result type on successful completion is a single [WalletItem](walletitem.md).

## -remarks

## -examples

## -see-also
[Asynchronous programming](http://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e), [Quickstart: Creating and distributing .mswallet files](http://msdn.microsoft.com/library/44575995-b45d-4458-b0ac-36dc0df373aa), [Quickstart: Using the   APIs](http://msdn.microsoft.com/library/4312628c-37a3-48a7-b41f-14605d478cf7)