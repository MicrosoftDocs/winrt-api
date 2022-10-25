---
-api-id: P:Windows.Networking.NetworkOperators.MobileBroadbandCellCdma.PilotSignalStrengthInDB
-api-type: winrt property
---

<!-- Property syntax.
public IReference<double> PilotSignalStrengthInDB { get; }
-->

# Windows.Networking.NetworkOperators.MobileBroadbandCellCdma.PilotSignalStrengthInDB

## -description
Gets the pilot signal strength in dB. 

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -property-value
The pilot signal strength in dB. 

## -remarks
The range of this value is -120~-25; returns null if unknown.
## -see-also

## -examples


## -capabilities
cellularDeviceIdentity, cellularDeviceControl
