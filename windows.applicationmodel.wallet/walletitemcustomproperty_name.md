---
-api-id: P:Windows.ApplicationModel.Wallet.WalletItemCustomProperty.Name
-api-type: winrt property
---

<!-- Property syntax
public string Name { get;  set; }
-->

# Windows.ApplicationModel.Wallet.WalletItemCustomProperty.Name

## -description
> [!CAUTION]
> The ApplicationModel.Wallet namespace is no longer supported, and will soon be deprecated. Developers are encouraged to avoid using this namespace.

Gets or sets the custom property label.

## -property-value
The custom property label.

## -remarks
Unlike the key for the [DisplayProperties](walletitem_displayproperties.md) collection, the Name value of a [WalletItemCustomProperty](walletitemcustomproperty.md) object is intended for user UI. Setting the value that's reported by Name is a required parameter when you construct a new [WalletItemCustomProperty](walletitemcustomproperty.md) (see [WalletItemCustomProperty constructor](walletitemcustomproperty_walletitemcustomproperty_1571897524.md)). In most cases you won't be setting the Name property of an existing [WalletItemCustomProperty](walletitemcustomproperty.md), as opposed to constructing a new one.

## -examples

## -see-also
