---
-api-id: M:Windows.Devices.PointOfService.BarcodeScanner.GetSupportedProfiles
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<string> GetSupportedProfiles()
-->

# Windows.Devices.PointOfService.BarcodeScanner.GetSupportedProfiles

## -description
Gets the list of profiles supported by the barcode scanner.

## -returns
As array of strings representing the supported profiles. Returns an empty list if the scanner does not support profiles.

## -remarks
A barcode scanner can support a number of features in addition to scanning, such as focal length and scan duration. There can be as many as 100 features exposed through settings or properties. To simplify the scanner configuration, the concept of a profile is introduced, which wraps one or more settings defined by the manufacturer. An application developer can query for a list of supported profiles and set a profile.

## -examples

## -see-also
