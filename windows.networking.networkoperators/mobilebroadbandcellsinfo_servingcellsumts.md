---
-api-id: P:Windows.Networking.NetworkOperators.MobileBroadbandCellsInfo.ServingCellsUmts
-api-type: winrt property
---

<!-- Property syntax.
public IVectorView<MobileBroadbandCellUmts> ServingCellsUmts { get; }
-->

# Windows.Networking.NetworkOperators.MobileBroadbandCellsInfo.ServingCellsUmts

## -description
Gets a read-only array of serving [MobileBroadbandCellUmts](mobilebroadbandcellumts.md) containing all UMTS providers.

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.

> If you want to use this API and publish your app to the Store, you will need special approval. For more information, see the **Special and restricted capabilities** section under [App capability declarations](https://docs.microsoft.com/en-us/windows/uwp/packaging/app-capability-declarations). 

## -property-value
A read-only array of serving [MobileBroadbandCellUmts](mobilebroadbandcellumts.md) containing all UMTS providers.

## -remarks
If not available or unknown, the size of array is 0.
## -see-also

## -examples


## -capabilities
cellularDeviceIdentity, cellularDeviceControl
