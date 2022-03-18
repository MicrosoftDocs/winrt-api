---
-api-id: M:Windows.Devices.PointOfService.ClaimedBarcodeScanner.SetActiveProfileAsync(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction SetActiveProfileAsync(System.String profile)
-->

# Windows.Devices.PointOfService.ClaimedBarcodeScanner.SetActiveProfileAsync

## -description

Sets the active profile on the barcode scanner.

> [!IMPORTANT]
> This API applies only to Build 10240 and Build 10586 of the Windows Mobile device family (Windows Mobile Extensions for the UWP). This API doesn't apply to the Windows Desktop device family, nor to other device families, nor to builds of Windows Mobile other than 10240 and 10586. When called on an operating system (OS) to which it doesn't apply, the behavior of this API is undefined. For more info about device families, see [Device family extension SDKs and API contracts](/uwp/extension-sdks/).

## -parameters
### -param profile
The name of the profile to set on the device.

## -returns
No object or value is returned when the method completes.

## -remarks
The input parameter must match one of the supported profiles. For more information, see [GetSupportedProfiles](barcodescanner_getsupportedprofiles_321103645.md) or [IsProfileSupported](barcodescanner_isprofilesupported_1386341468.md).

Barcode scanners can support a number of features beyond scanning, such as focal length and scan duration. These features are typically exposed through settings or properties and can be as many as 100 on complex devices. The simplify the model of scanner configuration, one or more profiles are exposed to application developers with each profile containing one or more OEM defined settings.

## -examples

## -see-also
[GetSupportedProfiles](barcodescanner_getsupportedprofiles_321103645.md), [IsProfileSupported](barcodescanner_isprofilesupported_1386341468.md)