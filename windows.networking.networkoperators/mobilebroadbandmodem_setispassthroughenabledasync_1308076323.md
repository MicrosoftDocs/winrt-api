---
-api-id: M:Windows.Networking.NetworkOperators.MobileBroadbandModem.SetIsPassthroughEnabledAsync(System.Boolean)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<MobileBroadbandModemStatus> MobileBroadbandModem.SetIsPassthroughEnabledAsync(Boolean value)
-->

# Windows.Networking.NetworkOperators.MobileBroadbandModem.SetIsPassthroughEnabledAsync

## -description
Asynchronously enables or disables passthrough mode.

## -parameters
### -param value
True if passthrough should be enabled; otherwise, false.

## -returns
An asynchronous operation that returns a [MobileBroadbandModemStatus](mobilebroadbandmodemstatus.md) value on completion.

## -remarks

Enabling passthrough mode allows the host to communicate with the SIM directly (the communication between the host and the SIM is *passthrough*). For example, to upgrade firmware. The miniport adapter doesn't send any application protocol data units (APDUs) to the card, and doesn't interfere at any time with the communication between the host and the SIM.

## -see-also

## -examples

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
