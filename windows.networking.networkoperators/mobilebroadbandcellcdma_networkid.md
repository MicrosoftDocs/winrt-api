---
-api-id: P:Windows.Networking.NetworkOperators.MobileBroadbandCellCdma.NetworkId
-api-type: winrt property
---

<!-- Property syntax.
public IReference<uint> NetworkId { get; }
-->

# Windows.Networking.NetworkOperators.MobileBroadbandCellCdma.NetworkId

## -description
Gets the network ID in CDMA only.

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.

> If you want to use this API and publish your app to the Store, you will need special approval. For more information, see the **Special and restricted capabilities** section under [App capability declarations](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations). 

## -property-value
The network ID in CDMA

## -remarks
The range of this value is 0~65535; returns null if unknown.

## -see-also

## -examples


## -capabilities
cellularDeviceIdentity, cellularDeviceControl
