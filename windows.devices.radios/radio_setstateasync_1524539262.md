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
Attempts to set the state of the radio represented by this object.

## -parameters
### -param value
The desired radio state.

> [!NOTE]
> Only **RadioState.On** and **RadioState.Off** may be set using SetStateAsync.

## -returns
When complete, returns a [RadioAccessStatus](radioaccessstatus.md) value describing the result of the state change
request.

## -remarks
Platform notes:
* **Xbox:** Not supported for UWP apps. Attempts to change radio state fail or are denied.

The `radios` capability is required for all radios. If the radio Kind is **RadioKind.MobileBroadband**, it also
requires `cellularDeviceControl`, a restricted capability granted to mobile operators.

Only **On** and **Off** states are settable. A requested change can be superseded by system or user actions. Rapid
internal transitions may be coalesced and not surface individually through events.

If the state changes externally while the request is in flight, the operation may complete with a status indicating
the final effective state rather than an intermediate step.

 A radio can be present but not user-controllable if required capabilities or policies are missing; its reported state
 is observable but attempts to change it have no effect.

## -examples

## -see-also

## -capabilities
radios, cellularDeviceControl
