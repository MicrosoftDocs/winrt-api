---
-api-id: P:Windows.Networking.NetworkOperators.MobileBroadbandCellGsm.BaseStationId
-api-type: winrt property
---

<!-- Property syntax.
public IReference<uint> BaseStationId { get; }
-->

# Windows.Networking.NetworkOperators.MobileBroadbandCellGsm.BaseStationId

## -description
Gets the base station ID. 

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.

> If you want to use this API and publish your app to the Store, you will need special approval. For more information, see the **Special and restricted capabilities** section under [App capability declarations](https://docs.microsoft.com/en-us/windows/uwp/packaging/app-capability-declarations). 

## -property-value
The base station ID.

## -remarks
The range of this value is 0~63; returns null if unknown.

## -see-also

## -examples


## -capabilities
cellularDeviceIdentity, cellularDeviceControl
