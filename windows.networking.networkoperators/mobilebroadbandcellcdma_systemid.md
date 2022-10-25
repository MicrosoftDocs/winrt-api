---
-api-id: P:Windows.Networking.NetworkOperators.MobileBroadbandCellCdma.SystemId
-api-type: winrt property
---

<!-- Property syntax.
public IReference<uint> SystemId { get; }
-->

# Windows.Networking.NetworkOperators.MobileBroadbandCellCdma.SystemId

## -description
Gets the system ID in CDMA only.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -property-value
The system ID in CDMA

## -remarks
The range of this value is 0~32767; returns null if unknown.
## -see-also

## -examples


## -capabilities
cellularDeviceIdentity, cellularDeviceControl
