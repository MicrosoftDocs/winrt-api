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
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -property-value
The received signal code power in dBm. 

## -remarks
This value is the ratio of the received energy per PN chip for the CPICH to the total received power spectral density at the antenna. 
The range of this value is -50~0; returns null if unknown.

## -see-also

## -examples


## -capabilities
cellularDeviceIdentity, cellularDeviceControl
