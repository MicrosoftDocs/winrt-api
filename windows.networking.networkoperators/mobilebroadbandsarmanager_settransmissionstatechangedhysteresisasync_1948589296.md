---
-api-id: M:Windows.Networking.NetworkOperators.MobileBroadbandSarManager.SetTransmissionStateChangedHysteresisAsync(Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncAction MobileBroadbandSarManager.SetTransmissionStateChangedHysteresisAsync(TimeSpan timerPeriod)
-->

# Windows.Networking.NetworkOperators.MobileBroadbandSarManager.SetTransmissionStateChangedHysteresisAsync

## -description
Sets the hysteresis timer (1-5 seconds) used to determine if transmission activity is idle.

> [!NOTE]
> To use this API you will need to contact Microsoft to request the custom capability **microsoft.cellularSARConfiguration_8wekyb3d8bbwe**. For more info, see the **Custom capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#custom-capabilities) topic, and [Creating a custom capability to pair a driver with a Hardware Support App](/windows-hardware/drivers/devapps/creating-a-custom-capability-to-pair-driver-with-hsa).

## -parameters
### -param timerPeriod
/**  The time-window size ranging from 1 to 5 seconds. 

## -returns
An asynchronous action.
## -remarks

## -see-also

## -examples


## -capabilities
cellularDeviceIdentity, cellularDeviceControl, microsoft.cellularSARConfiguration_8wekyb3d8bbwe