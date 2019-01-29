---
-api-id: P:Windows.Networking.NetworkOperators.MobileBroadbandCellLte.TimingAdvanceInBitPeriods
-api-type: winrt property
---

<!-- Property syntax.
public IReference<int> TimingAdvanceInBitPeriods { get; }
-->

# Windows.Networking.NetworkOperators.MobileBroadbandCellLte.TimingAdvanceInBitPeriods

## -description
Gets the Timing Advance in bit periods, where a bit period is 48/13us.

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.

> If you want to use this API and publish your app to the Store, you will need special approval. For more information, see the **Special and restricted capabilities** section under [App capability declarations](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations). 

## -property-value
The Timing Advance in bit periods.

## -remarks
The range of this value is 0~255; returns null if unknown.

## -see-also

## -examples


## -capabilities
cellularDeviceIdentity, cellularDeviceControl
