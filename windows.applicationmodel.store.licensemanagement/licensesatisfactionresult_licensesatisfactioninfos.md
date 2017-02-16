---
-api-id: P:Windows.ApplicationModel.Store.LicenseManagement.LicenseSatisfactionResult.LicenseSatisfactionInfos
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IMapView<string, Windows.ApplicationModel.Store.LicenseManagement.LicenseSatisfactionInfo> LicenseSatisfactionInfos { get; }
-->

# Windows.ApplicationModel.Store.LicenseManagement.LicenseSatisfactionResult.LicenseSatisfactionInfos

## -description
Provides access to entitlement info that is returned by the [GetSatisfactionInfosAsync](licensemanager_getsatisfactioninfosasync.md) method.

## -property-value
A map of key and value pairs that represent entitlement info for the specified products. In each pair, the key is a content ID that you passed to [GetSatisfactionInfosAsync](licensemanager_getsatisfactioninfosasync.md), and the value is a [LicenseSatisfactionInfo](licensesatisfactioninfo.md) object that provides entitlement info for the corresponding product.

## -remarks

## -examples

## -see-also
