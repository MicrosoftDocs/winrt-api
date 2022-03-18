---
-api-id: T:Windows.ApplicationModel.Store.ProductLicense
-api-type: winrt class
---

<!-- Class syntax.
public class ProductLicense : Windows.ApplicationModel.Store.IProductLicense, Windows.ApplicationModel.Store.IProductLicenseWithFulfillment
-->

# Windows.ApplicationModel.Store.ProductLicense

## -description
Provides info about a license that is associated with an add-on (also called an in-app product or IAP).

## -remarks
The [ProductLicenses](licenseinformation_productlicenses.md) property of the [LicenseInformation](licenseinformation.md) object contains one or more instances of this object.

## -examples
The following code example demonstrates how to use this object to get the expiration date of an add-on offer.

```csharp
// get the license info for this app from the simulator
LicenseInformation licenseInformation = CurrentAppSimulator.LicenseInformation;

// get the license info for one of the app's in-app offers
ProductLicense inAppOfferLicense =
    licenseInformation.ProductLicenses["MyFavoriteInAppOffer"];

// get the expiration date of this in-app offer
DateTimeOffset expirationDate = inAppOfferLicense.ExpirationDate;
```

## -see-also
[Store sample](https://github.com/Microsoft/Windows-universal-samples/tree/win10-1507/Samples/Store), [Trial app and in-app purchase sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Trial%20app%20and%20in-app%20purchase%20sample), [Enable in-app product purchases](/windows/uwp/monetize/enable-in-app-product-purchases)
