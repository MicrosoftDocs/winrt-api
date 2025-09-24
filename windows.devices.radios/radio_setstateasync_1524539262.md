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
Asynchronously attempts to change the operational state of the radio device, enabling applications to turn radios on or off 
programmatically.

## -parameters
### -param value
The desired radio state. Only [RadioState.On](radiostate.md) and [RadioState.Off](radiostate.md) are valid values.

> [!IMPORTANT]
> Do not pass [RadioState.Disabled](radiostate.md) or [RadioState.Unknown](radiostate.md) to this method. These states 
> represent hardware or system conditions that cannot be set programmatically.

## -returns
A [RadioAccessStatus](radioaccessstatus.md) indicating whether the state change request was successful, denied, or 
restricted by system policy.

## -remarks
[SetStateAsync](radio_setstateasync_1524539262.md) provides programmatic control over radio devices, subject to system 
policies and hardware capabilities.

### Prerequisites and permissions

**Required capabilities:**
- **radios**: Required for all radio types
- **cellularDeviceControl**: Additional requirement for [RadioKind.MobileBroadband](radiokind.md) (restricted capability)

**Access requirements:**
- Call [RequestAccessAsync](radio_requestaccessasync_380675631.md) before attempting state changes
- Only proceed with state changes when access status is [RadioAccessStatus.Allowed](radioaccessstatus.md)

### Operation behavior

**Asynchronous completion:**
- State changes are not instantaneous and may take time to complete
- External factors (hardware switches, system policy) can override requests
- Rapid transitions may be coalesced, with only final state observable

**Result interpretation:**
- [RadioAccessStatus.Allowed](radioaccessstatus.md): State change was successful
- [RadioAccessStatus.DeniedByUser](radioaccessstatus.md): User settings prevent the change
- [RadioAccessStatus.DeniedBySystem](radioaccessstatus.md): System policy blocks the change

> [!NOTE]
> Xbox platform does not support radio state changes through this API. State change requests will be denied or fail 
> on Xbox systems.

## -examples

For complete radio enumeration and management examples, see [Radio class documentation](radio.md).

## -see-also
[Radio](radio.md),
[Radio.RequestAccessAsync](radio_requestaccessasync_380675631.md),
[Radio.StateChanged](radio_statechanged.md),
[RadioAccessStatus](radioacccessstatus.md),
[RadioState](radiostate.md)

## -capabilities
radios, cellularDeviceControl
