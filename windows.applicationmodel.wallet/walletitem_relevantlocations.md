---
-api-id: P:Windows.ApplicationModel.Wallet.WalletItem.RelevantLocations
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IMap<string, Windows.ApplicationModel.Wallet.WalletRelevantLocation> RelevantLocations { get; }
-->

# Windows.ApplicationModel.Wallet.WalletItem.RelevantLocations

## -description
> [!CAUTION]
> The ApplicationModel.Wallet namespace is no longer supported, and will soon be deprecated. Developers are encouraged to avoid using this namespace.

Gets a collection of all relevant locations for the wallet item.

## -property-value
A collection of all relevant locations for the wallet item

## -remarks
The string key for items in this collection is usually a programmatic identifier that isn't intended for user UI. Data within a [WalletRelevantLocation](walletrelevantlocation.md) value is sometimes intended for UI.

Each [WalletRelevantLocation](walletrelevantlocation.md) value has a [Position](walletrelevantlocation_position.md) property to capture a [BasicGeoposition](../windows.devices.geolocation/basicgeoposition.md) value, and associates each position with a position-specific display message. You can see example code for this in [Quickstart: Using the   APIs](/previous-versions/windows/apps/dn631257(v=win.10)).

## -examples

## -see-also
[WalletRelevantLocation](walletrelevantlocation.md), [BasicGeoposition](../windows.devices.geolocation/basicgeoposition.md)