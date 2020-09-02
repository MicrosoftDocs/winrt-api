---
-api-id: T:Windows.ApplicationModel.Store.LicenseInformation
-api-type: winrt class
---

<!-- Class syntax.
public class LicenseInformation : Windows.ApplicationModel.Store.ILicenseInformation
-->

# Windows.ApplicationModel.Store.LicenseInformation

## -description
Provides access to the current app's license metadata.

## -remarks
For app trial versions of an app, [IsActive](licenseinformation_isactive.md) will return true so long as the trial hasn’t expired. During the trial period the [IsTrial](licenseinformation_istrial.md) returns true; returning false when the customer upgrades to the full version of the app.

You access this object through the [LicenseInformation](currentappsimulator_licenseinformation.md) property of the [CurrentAppSimulator](currentappsimulator.md) object during testing, or the [LicenseInformation](currentapp_licenseinformation.md) property of the [CurrentApp](currentapp.md) object when the app is distributed through the Microsoft Store.

> [!NOTE]
> The [CurrentApp](currentapp.md) object obtains its data from the Microsoft Store, which requires that you have a Microsoft Store developer account and that the app has been published in the Microsoft Store. If you don't have a Microsoft Store developer account, you can test the functions of this class by using the [CurrentAppSimulator](currentappsimulator.md).

## -examples

## -see-also
[Store sample ()](https://github.com/Microsoft/Windows-universal-samples/tree/win10-1507/Samples/Store), [Trial app and in-app purchase sample ()](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Trial%20app%20and%20in-app%20purchase%20sample), [Enable in-app product purchases](/windows/uwp/monetize/enable-in-app-product-purchases)
