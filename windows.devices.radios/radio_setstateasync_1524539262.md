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
Attempts to change the operational state of the radio (On / Off) asynchronously, subject to user permission, hardware
capabilities, and system policy.

## -parameters
### -param value
The desired radio state. Pass [RadioState.On](radiostate.md) to enable or [RadioState.Off](radiostate.md) to disable the radio.

> [!NOTE]
> [RadioState.Disabled](radiostate.md) is reserved for OS use and cannot be set programmatically.

## -returns
A [RadioAccessStatus](radioaccessstatus.md) indicating whether the request was permitted. A result of **Allowed** means
the request was accepted; the radio may still transition asynchronously to the final state.

## -remarks
### Capabilities and permission flow
1. Call [RequestAccessAsync](radio_requestaccessasync_380675631.md) early (once per session).
2. Verify the returned [RadioAccessStatus](radioaccessstatus.md) is **Allowed**.
3. Invoke SetStateAsync only when permission is granted.

Required capabilities:
- radios
- cellularDeviceControl (only for mobile broadband kinds; restricted)


> [!IMPORTANT]  
> Hardware (for example, a physical kill switch) or policy can override an **Allowed** request, leaving the radio in
> its prior state. Always observe the subsequent [StateChanged](radio_statechanged.md) event (or re-read [State](radio_state.md))
> to confirm the effective state.

### Asynchronous behavior
The API returns after the request is queued; the observable transition may complete later. Avoid chaining multiple
rapid On/Off requests—coalesce user interactions.

### Result mapping
| Result | Meaning | Next step |
| -- | -- | -- |
| Allowed | Request accepted | Wait for [StateChanged](radio_statechanged.md) to confirm |
| DeniedByUser | User/privacy rejected | Offer guidance or limited UI; do not loop |
| DeniedBySystem | Policy or platform restriction | Suppress repeat attempts |
| Unspecified | Treat as denied | Fallback to read-only behavior |

### Xbox / platform note
> [!NOTE]  
> Many Xbox configurations do not permit programmatic radio control; requests commonly return DeniedBySystem.

### Recommended pattern (C# conceptual)
```csharp
using Windows.Devices.Radios;

async Task<bool> TryTurnRadioOffAsync(Radio r)
{
    if (r == null) return false;

    var access = await Radio.RequestAccessAsync();
    if (access != RadioAccessStatus.Allowed) return false;

    var result = await r.SetStateAsync(RadioState.Off);
    if (result != RadioAccessStatus.Allowed) return false;

    // App-specific: wait for r.StateChanged if you must confirm final state before continuing
    return true;
}
```

## -examples
Toggle a radio safely (C#):

```csharp
async Task<bool> ToggleAsync(Radio r)
{
    if (r == null) return false;

    var access = await Radio.RequestAccessAsync();
    if (access != RadioAccessStatus.Allowed) return false;

    var target = r.State == RadioState.On ? RadioState.Off : RadioState.On;
    var status = await r.SetStateAsync(target);
    if (status != RadioAccessStatus.Allowed) return false;

    // App-specific: optionally wait for StateChanged to confirm final state
    return true;
}
```

## -see-also
[Radio](radio.md),
[Radio.GetRadiosAsync](radio_getradiosasync_548754145.md),
[Radio.RequestAccessAsync](radio_requestaccessasync_380675631.md),
[Radio.SetStateAsync](radio_setstateasync_1524539262.md),
[Radio.StateChanged](radio_statechanged.md),
[RadioAccessStatus](radioaccessstatus.md),
[RadioState](radiostate.md)

## -capabilities
radios, cellularDeviceControl
