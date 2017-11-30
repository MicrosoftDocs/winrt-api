---
-api-id: M:Windows.Networking.NetworkOperators.MobileBroadbandSarManager.SetConfigurationAsync(Windows.Foundation.Collections.IIterable{Windows.Networking.NetworkOperators.MobileBroadbandAntennaSar})
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncAction MobileBroadbandSarManager.SetConfigurationAsync(IIterable<MobileBroadbandAntennaSar> antennas)
-->

# Windows.Networking.NetworkOperators.MobileBroadbandSarManager.SetConfigurationAsync

## -description
Sends a request to the device to change the SAR configuration.  

> [!NOTE]
> This is a pre-release API. It will be fully usable in a future release, when the appropriate [MobileBroadbandAntennaSar](mobilebroadbandantennasar.md) constructor is available.
>
> To use this API you will need to contact Microsoft to request the special capability **microsoft.cellularSARConfiguration_8wekyb3d8bbwe**. For more info, see the **Special and restricted capabilities** section under [App capability declarations](/windows/uwp/packaging/app-capability-declarations?branch=live), and [Creating a custom capability to pair a driver with a Hardware Support App](/windows-hardware/drivers/devapps/creating-a-custom-capability-to-pair-driver-with-hsa?branch=live).

## -parameters
### -param antennas
The collection of antennas containing the SAR backoff property to configure. 

## -returns
An asynchronous action.

## -remarks

**Note** 

## -see-also

## -examples


## -capabilities
cellularDeviceIdentity, cellularDeviceControl, microsoft.cellularSARConfiguration_8wekyb3d8bbwe