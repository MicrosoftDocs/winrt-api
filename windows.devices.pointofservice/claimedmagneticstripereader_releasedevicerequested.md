---
-api-id: E:Windows.Devices.PointOfService.ClaimedMagneticStripeReader.ReleaseDeviceRequested
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.EventHandler ReleaseDeviceRequested<Windows.Devices.PointOfService.ClaimedMagneticStripeReader>
-->

# Windows.Devices.PointOfService.ClaimedMagneticStripeReader.ReleaseDeviceRequested

## -description
Occurs when the device gets a request to release its exclusive claim.

## -remarks

## -examples
The following example shows how to setup the event handler.



[!code-cpp[SetupMagStripeReader](../windows.devices.pointofservice/code/MagneticStripeReader/cpp/Scenario1.xaml.cpp#SnippetSetupMagStripeReader)]

[!code-csharp[SetupMagStripeReader](../windows.devices.pointofservice/code/MagneticStripeReader/cs/Scenario1.xaml.cs#SnippetSetupMagStripeReader)]



[!code-cpp[MagStripeReaderReleaseDeviceRequested](../windows.devices.pointofservice/code/MagneticStripeReader/cpp/Scenario1.xaml.cpp#SnippetMagStripeReaderReleaseDeviceRequested)]

[!code-csharp[MagStripeReaderReleaseDeviceRequested](../windows.devices.pointofservice/code/MagneticStripeReader/cs/Scenario1.xaml.cs#SnippetMagStripeReaderReleaseDeviceRequested)]

## -see-also
[Magnetic stripe reader sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/MagneticStripeReader)
