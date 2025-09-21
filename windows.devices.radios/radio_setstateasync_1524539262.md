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
The `radios` capability is required for all radios. If the radio Kind is **RadioKind.MobileBroadband**, then this also
requires `cellularDeviceControl`, a restricted capability granted to Mobile Operators.

Only **On** and **Off** states are settable. A requested change can be superseded by system or user actions. Rapid
internal transitions may not surface individually through events.

If the state changes externally at the same time as the request, the operation can complete with a status indicating
the final effective state rather than an intermediate step.

 A radio can be present but not user-controllable if required capabilities or policies are not in place; in that case
 its reported state is observable but attempts to change it have no effect.

## -examples

## -see-also

## -capabilities
radios, cellularDeviceControl
