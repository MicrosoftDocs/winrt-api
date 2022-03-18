---
-api-id: T:Windows.ApplicationModel.Wallet.WalletItemCustomProperty
-api-type: winrt class
---

<!-- Class syntax.
public class WalletItemCustomProperty : Windows.ApplicationModel.Wallet.IWalletItemCustomProperty
-->

# Windows.ApplicationModel.Wallet.WalletItemCustomProperty

## -description
> [!CAUTION]
> The ApplicationModel.Wallet namespace is no longer supported, and will soon be deprecated. Developers are encouraged to avoid using this namespace.

Defines a custom property on a wallet item. Apps can show data in the details view or back of card view of the item.

## -remarks
WalletItemCustomProperty values are stored in the [DisplayProperties](walletitem_displayproperties.md) property of a [WalletItem](walletitem.md). In addition to the basic data ([Name](walletitemcustomproperty_name.md) and [Value](walletitemcustomproperty_value.md)) a WalletItemCustomProperty object has other properties that influence how the property appears in the default wallet UI (for example [SummaryViewPosition](walletitemcustomproperty_summaryviewposition.md), [DetailViewPosition](walletitemcustomproperty_detailviewposition.md)).

## -examples

## -see-also
[WalletItem](walletitem.md), [WalletItem.DisplayProperties](walletitem_displayproperties.md), [Quickstart: Using the   APIs](/previous-versions/windows/apps/dn631257(v=win.10))
