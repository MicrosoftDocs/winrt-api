---
-api-id: P:Windows.ApplicationModel.Wallet.WalletItem.DisplayProperties
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IMap<string, Windows.ApplicationModel.Wallet.WalletItemCustomProperty> DisplayProperties { get; }
-->

# Windows.ApplicationModel.Wallet.WalletItem.DisplayProperties

## -description
> [!CAUTION]
> The ApplicationModel.Wallet namespace is no longer supported, and will soon be deprecated. Developers are encouraged to avoid using this namespace.

Gets the collection of [WalletItemCustomProperty](walletitemcustomproperty.md) objects associated with the wallet item.

## -property-value
The collection of [WalletItemCustomProperty](walletitemcustomproperty.md) objects associated with the wallet item.

## -remarks
The key for the DisplayProperties map is typically not used for the user UI. It's a programming identifier that you use to distinguish the individual custom properties. That identifier isn't part of the construction of a [WalletItemCustomProperty](walletitemcustomproperty.md); you choose it when you add one of the custom properties to the DisplayProperties collection.

## -examples

## -see-also
[WalletItemCustomProperty](walletitemcustomproperty.md)
