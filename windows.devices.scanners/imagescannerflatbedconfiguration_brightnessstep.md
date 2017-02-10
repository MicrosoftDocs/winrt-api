---
-api-id: P:Windows.Devices.Scanners.ImageScannerFlatbedConfiguration.BrightnessStep
-api-type: winrt property
---

<!-- Property syntax
public uint BrightnessStep { get; }
-->

# Windows.Devices.Scanners.ImageScannerFlatbedConfiguration.BrightnessStep

## -description
Gets the step size at which the brightness levels of the data source can be increased or decreased between the minimum and maximum values.

## -property-value
The step size to increment or decrement. A typical value is 1.

## -remarks
If the scanner doesn't allow brightness changes, then the **MinBrightness**, **MaxBrightness** and **DefaultBrightness** are set to the same value-oftentimes 0, and the **BrightnessStep** is set to 0. Your app can determine if the scan source doesn't support brightness adjustments by reading the **BrightnessStep** value. If the value is greater than 0, the scan source supports brightness adjustments.

## -examples

## -see-also
