---
-api-id: M:Windows.ApplicationModel.DataTransfer.DataProviderDeferral.Complete
-api-type: winrt method
---

<!-- Method syntax
public void Complete()
-->

# Windows.ApplicationModel.DataTransfer.DataProviderDeferral.Complete

## -description
Informs a [DataPackage](datapackage.md) that it is ready for processing.

## -remarks
For clipboard scenarios, your app must call Complete within 30 seconds of getting a deferral. For share scenarios, your app must call Complete within 6 minutes.

Be careful not to confuse this method with the [DataRequestDeferral.Complete](datarequestdeferral_complete_1807836922.md) method that is used in share scenarios.

## -examples

## -see-also
