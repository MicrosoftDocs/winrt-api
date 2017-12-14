---
-api-id: P:Windows.Services.Store.StoreLicense.IsActive
-api-type: winrt property
---

<!-- Property syntax
public bool IsActive { get; }
-->

# Windows.Services.Store.StoreLicense.IsActive

## -description
This property is reserved for future use, and it is not intended to be used in the current release. Currently, it always returns true.

## -property-value
True in all cases.

## -remarks
The license for a durable add-on is valid and provides the current user with an entitlement to use the add-on if the [StoreLicense](storelicense.md) object is included in the collection returned by the [StoreAppLicense.AddOnLicenses](storeapplicense_addonlicenses.md) property. When the add-on license expires or is no longer valid, it will no longer be available in the [StoreAppLicense.AddOnLicenses](storeapplicense_addonlicenses.md) collection.

## -examples

## -see-also
