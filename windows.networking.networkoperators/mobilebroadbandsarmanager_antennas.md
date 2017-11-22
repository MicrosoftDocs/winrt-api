---
-api-id: P:Windows.Networking.NetworkOperators.MobileBroadbandSarManager.Antennas
-api-type: winrt property
---

<!-- Property syntax.
public IVectorView<MobileBroadbandAntennaSar> Antennas { get; }
-->

# Windows.Networking.NetworkOperators.MobileBroadbandSarManager.Antennas

## -description
Gets the collection of current SAR configuration models for each antenna on the device. 

> [!NOTE]
> To use this API you will need to contact Microsoft to request the special capability **microsoft.cellularSARConfiguration_8wekyb3d8bbwe**. For more info, see the **Special and restricted capabilities** section under [App capability declarations](/windows/uwp/packaging/app-capability-declarations?branch=live), and [Creating a custom capability to pair a driver with a Hardware Support App](/windows-hardware/drivers/devapps/creating-a-custom-capability-to-pair-driver-with-hsa?branch=live).

## -property-value
The collection of current SAR configuration models for each antenna on the device.

## -remarks
The size of this collection is guaranteed to be the same as the number of antennas on device.

## -see-also

## -examples


## -capabilities
cellularDeviceIdentity, cellularDeviceControl, microsoft.cellularSARConfiguration_8wekyb3d8bbwe