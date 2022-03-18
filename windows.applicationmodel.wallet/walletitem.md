---
-api-id: T:Windows.ApplicationModel.Wallet.WalletItem
-api-type: winrt class
---

<!-- Class syntax.
public class WalletItem : Windows.ApplicationModel.Wallet.IWalletItem
-->

# Windows.ApplicationModel.Wallet.WalletItem

## -description
> [!CAUTION]
> The ApplicationModel.Wallet namespace is no longer supported, and will soon be deprecated. Developers are encouraged to avoid using this namespace.

Represents an item (data) that is stored in the wallet.

## -remarks
Use the [WalletItem constructor](walletitem_walletitem_1121193137.md) if you're defining a new item to insert into the wallet. Use methods of [WalletItemStore](walletitemstore.md) such as [GetWalletItemAsync](walletitemstore_getwalletitemasync_998830941.md) or [GetItemsAsync](walletitemstore_getitemsasync_1518547059.md) if you're retrieving existing items from the wallet.

If you modify/set any of the properties in an existing WalletItem (including the [WalletItemCustomProperty](walletitemcustomproperty.md) values in [DisplayProperties](walletitem_displayproperties.md)), call [WalletItemStore.UpdateAsync](walletitemstore_updateasync_1403447975.md) to commit these changes to the backing store. You can see example code for this in [Quickstart: Using the   APIs](/previous-versions/windows/apps/dn631257(v=win.10)).

## -examples

## -see-also
[WalletItemStore](walletitemstore.md), [WalletManager](walletmanager.md), [Quickstart: Using the   APIs](/previous-versions/windows/apps/dn631257(v=win.10))
