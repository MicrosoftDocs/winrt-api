---
-api-id: M:Windows.Devices.Radios.Radio.GetRadiosAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Devices.Radios.Radio>> GetRadiosAsync()
-->

# Windows.Devices.Radios.Radio.GetRadiosAsync

## -description
Retrieves a collection (snapshot) of [Radio](radio.md) objects representing the radios present when the call executes.

## -returns
On successful completion, a read-only list of [Radio](radio.md) objects representing the radios present at call time.

## -remarks
### Snapshot behavior
Each invocation returns a fresh snapshot. Radios physically added or removed since the previous call will appear or
disappear accordingly. Cache validity is therefore limited; re-enumerate when you receive hardware change signals or
user actions implying device addition/removal.

### Empty results
An empty collection does not imply failure. It can mean:
- Platform does not expose radio enumeration (for example, Xbox in many configurations).
- The process architecture is incompatible (see Architecture considerations below).
- The user/device has no radios currently enabled or present.
Validate required capabilities (for APIs that require them) before retry logic.

### Re-enumeration guidance
Re-query when:
- A UI that lists radios is brought back to foreground after suspension.
- You receive a radio state change and need to detect newly available hardware.
- A device arrival/removal notification occurs (classic desktop companion component).

Avoid excessive polling; enumerate on demand or event-driven triggers.

### Architecture considerations
- UWP apps: Works across x86, x64, and ARM64.
- Desktop (Win32) processes: Enumeration returns radios only when process architecture matches the OS architecture
  (x64 process on x64 OS, ARM64 on ARM64). An x86 process on x64/ARM64 commonly yields an empty list.

> [!NOTE]
> Architecture mismatch and platform restrictions are common reasons for an empty result. Handle the empty case
> defensively instead of surfacing generic error messaging.

### Platform notes
- Xbox: Enumeration may return zero radios; state control operations may be unavailable.

### Usage pattern (conceptual C#)
```csharp
var radios = await Radio.GetRadiosAsync();
if (radios.Count == 0)
{
    // App-specific: disable radio-dependent UI or show a contextual message
}
foreach (var r in radios)
{
    // App-specific: aggregate by r.Kind or subscribe to r.StateChanged
}
```

## -examples

## -see-also
[Radio](radio.md),
[Radio.FromIdAsync](radio_fromidasync_1322863552.md),
[Radio.GetDeviceSelector](radio_getdeviceselector_838466080.md),
[Radio.RequestAccessAsync](radio_requestaccessasync_380675631.md),
[Radio.SetStateAsync](radio_setstateasync_1524539262.md),
[Radio.StateChanged](radio_statechanged.md),
[RadioAccessStatus](radioaccessstatus.md),
[RadioKind](radiokind.md),
[RadioManager sample](https://github.com/microsoft/Windows-universal-samples/tree/main/Samples/RadioManager),
[RadioState](radiostate.md)
