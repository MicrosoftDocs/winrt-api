---
-api-id: T:Windows.ApplicationModel.Wallet.WalletTransaction
-api-type: winrt class
---

<!-- Class syntax.
public class WalletTransaction : Windows.ApplicationModel.Wallet.IWalletTransaction
-->

# Windows.ApplicationModel.Wallet.WalletTransaction

## -description
> [!CAUTION]
> The ApplicationModel.Wallet namespace is no longer supported, and will soon be deprecated. Developers are encouraged to avoid using this namespace.

Represents a single wallet transaction in the transaction history.
## -remarks
A WalletTransaction object represents the individual items for the [WalletItem.TransactionHistory](walletitem_transactionhistory.md) property.

Most of the APIs for this class can be seen in example usages in the [Quickstart: Using the   APIs](/previous-versions/windows/apps/dn631257(v=win.10)) topic.

If you update the values in any WalletTransaction object, which is contributing to the data of a [WalletItem](walletitem.md) object, make sure to call [WalletItemStore.UpdateAsync](walletitemstore_updateasync_1403447975.md) (passing that [WalletItem](walletitem.md) object) to commit the changes to the backing wallet store.

## -examples

## -see-also
[WalletItemTransactionHistory](walletitem_transactionhistory.md), [WalletItem](walletitem.md), [Quickstart: Using the   APIs](/previous-versions/windows/apps/dn631257(v=win.10))
