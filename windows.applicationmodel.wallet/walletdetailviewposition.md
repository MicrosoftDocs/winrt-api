---
-api-id: T:Windows.ApplicationModel.Wallet.WalletDetailViewPosition
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Wallet.WalletDetailViewPosition : int
-->

# WalletDetailViewPosition

## -description
> [!CAUTION]
> The ApplicationModel.Wallet namespace is no longer supported, and will soon be deprecated. Developers are encouraged to avoid using this namespace.

Describes the position in the detail view of a wallet item that a [WalletItemCustomProperty](walletitemcustomproperty.md) record should be displayed at.

## -enum-fields
### -field Hidden:0
This property is hidden from the detail view of the wallet item, but will be displayed on the back-of-card view of the item.

### -field HeaderField1:1
The first header slot in UI.

### -field HeaderField2:2
The second header slot in UI.

### -field PrimaryField1:3
The first content slot in UI.

### -field PrimaryField2:4
The second content slot in UI.

### -field SecondaryField1:5
The first content slot in UI under Header2.

### -field SecondaryField2:6
The second content slot in UI under Header2.

### -field SecondaryField3:7
The third content slot in UI under Header2.

### -field SecondaryField4:8
The fourth content slot in UI under Header2.

### -field SecondaryField5:9
The fifth content slot in UI under Header2.

### -field CenterField1:10
If the value of the property at this position contains a URL (**http:// or https://**), the data is displayed as a button that can navigate to that URL.

### -field FooterField1:11
The first footer slot in UI.

### -field FooterField2:12
The second footer slot in UI.

### -field FooterField3:13
The third footer slot in UI.

### -field FooterField4:14
The fourth footer slot in UI.


## -remarks

## -examples

## -see-also
[WalletItemCustomProperty](walletitemcustomproperty.md), [WalletItemCustomProperty.DetailViewPosition](walletitemcustomproperty_detailviewposition.md)