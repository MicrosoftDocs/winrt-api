---
-api-id: P:Windows.Networking.NetworkOperators.MobileBroadbandCellLte.ReferenceSignalReceivedPowerInDBm
-api-type: winrt property
---

<!-- Property syntax.
public IReference<double> ReferenceSignalReceivedPowerInDBm { get; }
-->

# Windows.Networking.NetworkOperators.MobileBroadbandCellLte.ReferenceSignalReceivedPowerInDBm

## -description
Gets the average Reference Signal Received Power in dBm.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -property-value
The average Reference Signal Received Power in dBm.

## -remarks
The range of this value is -140~44; returns null if unknown.

## -see-also

## -examples


## -capabilities
cellularDeviceIdentity, cellularDeviceControl
