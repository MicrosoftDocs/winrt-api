---
-api-id: M:Windows.Devices.Radios.Radio.RequestAccessAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Radios.RadioAccessStatus> RequestAccessAsync()
-->

# Windows.Devices.Radios.Radio.RequestAccessAsync

## -description
Requests permission to control radios and returns a [RadioAccessStatus](radioaccessstatus.md) indicating the current
user's access level for radio control operations.

## -returns
An asynchronous operation whose result is a [RadioAccessStatus](radioaccessstatus.md) value indicating the user's
permission to control radios.

## -remarks
> [!IMPORTANT]  
> This method may prompt the user the first time access is requested. Call it from a context where user interaction
> (consent UI) is valid. Do not block critical UI threads with long-running logic after the call completes.

### When to call
Call once per app session (or when you suspect status may have changed due to settings/policy). Repeated calls waste
cycles and can degrade user experience.

### Returned statuses (see [RadioAccessStatus](radioaccessstatus.md))
- **Allowed**: You may enumerate and change radio states (subject to individual radio kind limitations).
- **DeniedByUser**: The user explicitly denied permission (for example, privacy settings). Offer guidance, not repeated prompts.
- **DeniedBySystem**: Blocked by system policy/admin restrictions; do not retry automatically.
- **Unspecified**: Treat as denied; fall back to read-only scenarios if applicable.

An access status other than **Allowed** does not imply radios are absent—only that control is restricted. Enumeration
may still succeed and state can often be read.

### Typical sequence
1. Request access.
2. Check status - proceed only if **Allowed**.
3. Enumerate radios via [GetRadiosAsync](radio_getradiosasync_548754145.md) or a device query using
   [GetDeviceSelector](radio_getdeviceselector_838466080.md).
4. Subscribe to [StateChanged](radio_statechanged.md) for displayed radios.
5. Invoke [SetStateAsync](radio_setstateasync_1524539262.md) (access already validated).

### Usage pattern (C#)
```csharp
using Windows.Devices.Radios;

var access = await Radio.RequestAccessAsync();
if (access != RadioAccessStatus.Allowed)
{
    // App-specific: degrade functionality or show limited-controls message
    return;
}

var radios = await Radio.GetRadiosAsync();
foreach (var r in radios)
{
    r.StateChanged += (sender, args) =>
    {
        // App-specific: refresh UI / logic based on sender.State
    };
}
```

> [!NOTE]  
> Cache the result for the session. Re-check only after a settings change notification or when returning from a
> system privacy page the user opened from your app.

## -examples

## -see-also
[Radio](radio.md),
[Radio.FromIdAsync](radio_fromidasync_1322863552.md),
[Radio.GetDeviceSelector](radio_getdeviceselector_838466080.md),
[Radio.GetRadiosAsync](radio_getradiosasync_548754145.md),
[Radio.SetStateAsync](radio_setstateasync_1524539262.md),
[Radio.StateChanged](radio_statechanged.md),
[RadioAccessStatus](radioaccessstatus.md)
