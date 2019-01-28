---
-api-id: P:Windows.Networking.NetworkOperators.MobileBroadbandCellGsm.ReceivedSignalStrengthInDBm
-api-type: winrt property
---

<!-- Property syntax.
public IReference<double> ReceivedSignalStrengthInDBm { get; }
-->

# Windows.Networking.NetworkOperators.MobileBroadbandCellGsm.ReceivedSignalStrengthInDBm

## -description
Gets the received signal strength in dB.

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.

> If you want to use this API and publish your app to the Store, you will need special approval. For more information, see the **Special and restricted capabilities** section under [App capability declarations](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations). 

## -property-value
The received signal strength, in dB.

## -remarks
The range of this value is -110~49; returns null if unknown.

## -see-also

## -examples


## -capabilities
cellularDeviceIdentity, cellularDeviceControl
