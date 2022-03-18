---
-api-id: P:Windows.ApplicationModel.Wallet.WalletItemCustomProperty.AutoDetectLinks
-api-type: winrt property
---

<!-- Property syntax
public bool AutoDetectLinks { get;  set; }
-->

# Windows.ApplicationModel.Wallet.WalletItemCustomProperty.AutoDetectLinks

## -description
> [!CAUTION]
> The ApplicationModel.Wallet namespace is no longer supported, and will soon be deprecated. Developers are encouraged to avoid using this namespace.

Gets or sets whether this [WalletItemCustomProperty](walletitemcustomproperty.md) is entity-extracted and actionable upon display.

## -property-value
**true** if the [WalletItemCustomProperty](walletitemcustomproperty.md) is entity-extracted and actionable upon display; Otherwise, **false**.

## -remarks
*Entity-extracted* is a term for the automatic behavior that can match strings in data to certain patterns, and automatically generate an appropriate action/behavior for that item in the UI. This technique is commonly used in e-mail applications, and is also used here for the UI logic of a wallet item display. For example, a 10-digit string where each character is a number 0-9 can be entity-extracted to represent a phone number, and the action associated is to initiate a call to that number. Because there can be false matches to the patterns, the default value is **false**, but if you know what the data and matching behavior is in your [WalletItemCustomProperty](walletitemcustomproperty.md) and you want entity-extracted behavior, set this property **true**.

## -examples

## -see-also
[Quickstart: Using the   APIs](/previous-versions/windows/apps/dn631257(v=win.10))
