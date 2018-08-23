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
> Only **RadioStateOn** and **RadioStateOff** may be set using [SetStateAsync](radio_setstateasync_1524539262.md).

## -returns
An asynchronous state setting operation. On successful completion, contains an enumeration value describing status of the state change request.

## -remarks

## -examples

## -see-also

## -capabilities
radios
