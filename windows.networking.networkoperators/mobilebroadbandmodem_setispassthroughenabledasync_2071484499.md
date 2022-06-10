---
-api-id: M:Windows.Networking.NetworkOperators.MobileBroadbandModem.SetIsPassthroughEnabledAsync(System.Boolean,System.Int32)
-api-type: winrt method
---

# Windows.Networking.NetworkOperators.MobileBroadbandModem.SetIsPassthroughEnabledAsync(System.Boolean,System.Int32)

<!--
public Windows.Foundation.IAsyncOperation<Windows.Networking.NetworkOperators.MobileBroadbandModemStatus> SetIsPassthroughEnabledAsync (bool value, int slotindex);
-->


## -description

Asynchronously enables or disables passthrough mode (for either the active or inactive slot, for Dual Sim Single Active devices).

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).

## -parameters

### -param value

A value of `true` to enable passthrough mode; `false` to disable it.

### -param slotindex

The 0-based slot index (slot number) to enable or disable passthrough mode for.

## -returns

An asynchronous object which, when it completes, contains a [MobileBroadbandModemStatus](mobilebroadbandmodemstatus.md) value.

## -remarks

Enabling passthrough mode allows the host to communicate with the SIM directly (the communication between the host and the SIM is *passthrough*). For example, to upgrade firmware. The miniport adapter doesn't send any application protocol data units (APDUs) to the card, and doesn't interfere at any time with the communication between the host and the SIM.

## -see-also

## -examples

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe
