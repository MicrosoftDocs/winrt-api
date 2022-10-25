---
-api-id: P:Windows.Networking.NetworkOperators.MobileBroadbandCellsInfo.NeighboringCellsNR
-api-type: winrt property
---

# Windows.Networking.NetworkOperators.MobileBroadbandCellsInfo.NeighboringCellsNR

<!--
public System.Collections.Generic.IReadOnlyList<Windows.Networking.NetworkOperators.MobileBroadbandCellNR> NeighboringCellsNR { get; }
-->

## -description

Gets a collection of [MobileBroadbandCellNR](/uwp/api/windows.networking.networkoperators.mobilebroadbandcellnr) objects, each representing a collection of properties for a neighboring 5G-NR cell.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic.

## -property-value

A collection of [MobileBroadbandCellNR](/uwp/api/windows.networking.networkoperators.mobilebroadbandcellnr) objects, each representing a collection of properties for a neighboring 5G-NR cell, or an empty collection if the modem doesn't support 5G.

## -remarks

## -see-also

## -examples

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
