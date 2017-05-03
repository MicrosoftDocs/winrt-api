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

## -parameters
### -param profile
The name of the profile to set on the device.

## -returns
No object or value is returned when the method completes.

## -remarks
The input parameter must match one of the supported profiles. For more information, see [GetSupportedProfiles](barcodescanner_getsupportedprofiles.md) or [IsProfileSupported](barcodescanner_isprofilesupported.md).

Barcode scanners can support a number of features beyond scanning, such as focal length and scan duration. These features are typically exposed through settings or properties and can be as many as 100 on complex devices. The simplify the model of scanner configuration, one or more profiles are exposed to application developers with each profile containing one or more OEM defined settings.

## -examples

## -see-also
[GetSupportedProfiles](barcodescanner_getsupportedprofiles.md), [IsProfileSupported](barcodescanner_isprofilesupported.md)