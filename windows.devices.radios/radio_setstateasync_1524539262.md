---
-api-id: M:Windows.Devices.Radios.Radio.SetStateAsync(Windows.Devices.Radios.RadioState)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Radios.RadioAccessStatus> SetStateAsync(Windows.Devices.Radios.RadioState value)
-->

# Windows.Devices.Radios.Radio.SetStateAsync

## -description
An asynchronous operation that attempts to set the state of the radio represented by this object.

## -parameters
### -param value
The desired radio state. 

> [!NOTE]
> Only **RadioState.On** and **RadioState.Off** may be set using SetStateAsync.

## -returns
An asynchronous state setting operation. On successful completion, contains an enumeration value describing status of the state change request.

## -remarks

The `radios` capability is required for all radios.
If the radio Kind is **RadioKind.MobileBroadband**, then this also requires `cellularDeviceControl`, a restricted capability given to Mobile Operators.

The returned `IAsyncOperation<RadioAccessStatus>` can throw the ERROR_BUSY exception when retrieving the result, if the radio state is changed by another process simultaneously. This exception must be caught and the operation retried if necessary.

## -examples

## -see-also

## -capabilities
radios, cellularDeviceControl
