---
-api-id: P:Windows.System.Power.Diagnostics.BackgroundEnergyDiagnostics.DeviceSpecificConversionFactor
-api-type: winrt property
---

<!-- Property syntax
public double DeviceSpecificConversionFactor { get; }
-->

# Windows.System.Power.Diagnostics.BackgroundEnergyDiagnostics.DeviceSpecificConversionFactor

## -description
Gets the device-specific conversion factor used to convert energy usage (mW) to a normalized percentage.

> [!IMPORTANT]
> These APIs consume significant CPU resources. We recommend using these APIs only for debugging purposes.

## -property-value
The device-specific conversion factor used to convert energy usage (mW) to a normalized percentage.

## -remarks
To determine the estimated energy usage for the device in units of milliwatts (mW), divide the computed total energy usage by the DeviceSpecificConversionFactor.

## -examples

## -see-also
