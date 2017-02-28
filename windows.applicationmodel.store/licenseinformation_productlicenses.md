---
-api-id: P:Windows.ApplicationModel.Store.LicenseInformation.ProductLicenses
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IMapView<string, Windows.ApplicationModel.Store.ProductLicense> ProductLicenses { get; }
-->

# Windows.ApplicationModel.Store.LicenseInformation.ProductLicenses

## -description
Gets the associative list of licenses for in-app products that the user is currently entitled to.

## -property-value
The associative list of feature licenses.

## -remarks
To determine if the user is entitled to the in-app products, use the [IsActive](productlicense_isactive.md) property of the [ProductLicense](productlicense.md) objects.

> [!IMPORTANT]
> The returned list of [ProductLicense](productlicense.md) objects will always represent all in-app products that the user is currently entitled to (where **IsActive = true**). However, this list may or may not also contain [ProductLicense](productlicense.md) objects for products that the user is not currently entitled to (where **IsActive = false**).

## -examples

## -see-also
