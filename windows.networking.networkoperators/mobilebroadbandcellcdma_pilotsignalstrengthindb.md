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
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.

> If you want to use this API and publish your app to the Store, you will need special approval. For more information, see the **Special and restricted capabilities** section under [App capability declarations](https://docs.microsoft.com/en-us/windows/uwp/packaging/app-capability-declarations). 

## -property-value
The pilot signal strength in dB. 

## -remarks
The range of this value is -120~-25; returns null if unknown.
## -see-also

## -examples


## -capabilities
cellularDeviceIdentity, cellularDeviceControl
