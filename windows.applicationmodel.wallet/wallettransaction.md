---
-api-id: T:Windows.ApplicationModel.Wallet.WalletTransaction
-api-type: winrt class
---

<!-- Class syntax.
public class WalletTransaction : Windows.ApplicationModel.Wallet.IWalletTransaction
-->

# Windows.ApplicationModel.Wallet.WalletTransaction

## -description
Represents a single wallet transaction in the transaction history.

## -remarks
A [WalletTransaction](wallettransaction.md) object represents the individual items for the [WalletItem.TransactionHistory](walletitem_transactionhistory.md) property.

Most of the APIs for this class can be seen in example usages in the [Quickstart: Using the   APIs](http://msdn.microsoft.com/library/4312628c-37a3-48a7-b41f-14605d478cf7) topic.

If you update the values in any [WalletTransaction](wallettransaction.md) object, which is contributing to the data of a [WalletItem](walletitem.md) object, make sure to call [WalletItemStore.UpdateAsync](walletitemstore_updateasync_1403447975.md) (passing that [WalletItem](walletitem.md) object) to commit the changes to the backing wallet store.

## -examples

## -see-also
[WalletItemTransactionHistory](walletitem_transactionhistory.md), [WalletItem](walletitem.md), [Quickstart: Using the   APIs](http://msdn.microsoft.com/library/4312628c-37a3-48a7-b41f-14605d478cf7)