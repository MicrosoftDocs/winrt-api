---
-api-id: P:Windows.Networking.NetworkOperators.MobileBroadbandCellUmts.SignalToNoiseRatioInDB
-api-type: winrt property
---

<!-- Property syntax.
public IReference<double> SignalToNoiseRatioInDB { get; }
-->

# Windows.Networking.NetworkOperators.MobileBroadbandCellUmts.SignalToNoiseRatioInDB

## -description
Gets the signal to noise ratio in dB. 

> [!NOTE]
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

## -property-value
The received signal code power in dBm. 

## -remarks
This value is the ratio of the received energy per PN chip for the CPICH to the total received power spectral density at the antenna. 
The range of this value is -50~0; returns null if unknown.

## -see-also

## -examples

