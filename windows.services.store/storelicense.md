---
-api-id: T:Windows.Services.Store.StoreLicense
-api-type: winrt class
---

<!-- Class syntax.
public class StoreLicense : Windows.Services.Store.IStoreLicense
-->

# Windows.Services.Store.StoreLicense

## -description
Provides license info for a durable add-on that is associated with the current app.

## -remarks
To retrieve [StoreLicense](storelicense.md) objects for the durable add-ons for the current app, use the [StoreAppLicense.AddOnLicenses](storeapplicense_addonlicenses.md) property. This property contains only the add-on licenses that are still valid and provide the current user with an entitlement to use the add-on. When an add-on license expires or is longer valid, it will no longer be available in the [StoreAppLicense.AddOnLicenses](storeapplicense_addonlicenses.md) collection.

## -examples

## -see-also
