---
-api-id: P:Windows.Services.Store.StoreAppLicense.AddOnLicenses
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IMapView<string, Windows.Services.Store.StoreLicense> AddOnLicenses { get; }
-->

# Windows.Services.Store.StoreAppLicense.AddOnLicenses

## -description
Gets the collection of licenses for durable add-ons for which the user has entitlements to use. This property does not include licenses for consumable add-ons.

## -property-value
A map of key and value pairs, where each key is the Store ID of an add-on SKU from the Microsoft Store catalog and each value is a [StoreLicense](storelicense.md) object that contains license info for the add-on.

## -remarks
This collection contains durable add-on licenses that are currently valid. When a license is expired or no longer valid, it will no longer be available in this collection.

## -examples

## -see-also
