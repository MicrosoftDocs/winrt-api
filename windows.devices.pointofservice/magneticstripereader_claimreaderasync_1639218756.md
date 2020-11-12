---
-api-id: M:Windows.Devices.PointOfService.MagneticStripeReader.ClaimReaderAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.PointOfService.ClaimedMagneticStripeReader> ClaimReaderAsync()
-->

# Windows.Devices.PointOfService.MagneticStripeReader.ClaimReaderAsync

## -description
Attempts to get an exclusive access to the magnetic stripe reader.

## -returns
When the method completes, it returns a [ClaimedMagneticStripeReader](claimedmagneticstripereader.md) or it returns null if the operation fails to claim a magnetic stripe reader.

## -remarks

## -examples


[!code-cpp[ClaimMagStripeReader](../windows.devices.pointofservice/code/MagneticStripeReader/cpp/Scenario1.xaml.cpp#SnippetClaimMagStripeReader)]

[!code-csharp[ClaimMagStripeReader](../windows.devices.pointofservice/code/MagneticStripeReader/cs/Scenario1.xaml.cs#SnippetClaimMagStripeReader)]

## -see-also
[Magnetic stripe reader sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/MagneticStripeReader)
soft.com/fwlink/p/?LinkId=620017)
