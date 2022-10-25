---
-api-id: P:Windows.Networking.NetworkOperators.MobileBroadbandCellsInfo.ServingCellsTdscdma
-api-type: winrt property
---

<!-- Property syntax.
public IVectorView<MobileBroadbandCellTdscdma> ServingCellsTdscdma { get; }
-->

# Windows.Networking.NetworkOperators.MobileBroadbandCellsInfo.ServingCellsTdscdma

## -description
Gets a read-only array of serving [MobileBroadbandCellTdscdma](mobilebroadbandcelltdscdma.md) containing all TDSCMA providers.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -property-value
A read-only array of serving [MobileBroadbandCellTdscdma](mobilebroadbandcellumts.md) containing all TDSCMA providers.

## -remarks
If not available or unknown, the size of array is 0.

## -see-also

## -examples


## -capabilities
cellularDeviceIdentity, cellularDeviceControl
