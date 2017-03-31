---
-api-id: M:Windows.Devices.PointOfService.MagneticStripeReader.GetDefaultAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.PointOfService.MagneticStripeReader> GetDefaultAsync()
-->

# Windows.Devices.PointOfService.MagneticStripeReader.GetDefaultAsync

## -description
Returns the first magnetic stripe reader found.

## -returns
The first magnetic stripe reader found. Returns a null object in the following cases:
+ A device is not found.
+ Access denied to the existing device. The user can deny access to a device, which is not treated as an exception.


## -remarks

## -examples


[!code-cpp[CreateMagStripeReader](../windows.devices.pointofservice/code/MagneticStripeReader/cpp/Scenario1.xaml.cpp#SnippetCreateMagStripeReader)]

[!code-csharp[CreateMagStripeReader](../windows.devices.pointofservice/code/MagneticStripeReader/cs/Scenario1.xaml.cs#SnippetCreateMagStripeReader)]


[!code-js[CreateMagStripeReaderJS](../windows.devices.pointofservice/code/MagneticStripeReader/js/scenario1.js#SnippetCreateMagStripeReaderJS)]

## -see-also
[Magnetic stripe reader sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620017)
