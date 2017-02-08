---
-api-id: E:Windows.Devices.PointOfService.ClaimedMagneticStripeReader.ReleaseDeviceRequested
-api-type: winrt event
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

[!code-cs[SetupMagStripeReader](../windows.devices.pointofservice/code/MagneticStripeReader/cs/Scenario1.xaml.cs#SnippetSetupMagStripeReader)]



[!code-cpp[MagStripeReaderReleaseDeviceRequested](../windows.devices.pointofservice/code/MagneticStripeReader/cpp/Scenario1.xaml.cpp#SnippetMagStripeReaderReleaseDeviceRequested)]

[!code-cs[MagStripeReaderReleaseDeviceRequested](../windows.devices.pointofservice/code/MagneticStripeReader/cs/Scenario1.xaml.cs#SnippetMagStripeReaderReleaseDeviceRequested)]

## -see-also
[Magnetic stripe reader sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620017)
