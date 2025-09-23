---
-api-id: T:Windows.Devices.Radios.Radio
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class Radio : Windows.Devices.Radios.IRadio
-->

# Windows.Devices.Radios.Radio

## -description
Represents a radio device on the system.

## -remarks
Platform notes:
* **Xbox:** This API surface isn't supported for UWP apps on Xbox. Enumeration can return an empty set, and state
  change requests may fail or be denied by the system.

Use static members such as [GetRadiosAsync](radio_getradiosasync_548754145.md),
[GetDeviceSelector](radio_getdeviceselector_838466080.md), and [FromIdAsync](radio_fromidasync_1322863552.md) to query for
radios and retrieve instantiated Radio objects representing specific device radios.

Call [RequestAccessAsync](radio_requestaccessasync_380675631.md) at least once from the UI thread before calling
[SetStateAsync](radio_setstateasync_1524539262.md). In some regions, and with certain user settings, changing radio
state requires user consent. Calling [RequestAccessAsync](radio_requestaccessasync_380675631.md) prompts the user to
grant permission. If permission is required but not granted, [SetStateAsync](radio_setstateasync_1524539262.md) fails.

Functional behavior:
* Radios can appear or disappear while your app runs; enumeration is not fixed after launch.
* A newly discovered radio may already be On or Off based on prior configuration or policy.
* Removing a radio (for example, unplugging a USB adapter) simply causes it to stop appearing in subsequent
  enumerations; there is no transient "removed" state object.
* Rapid internal state transitions may be coalesced; only a final observable state may surface through events.
* Friendly names can change. Do not use a friendly name as a persistent identifier.
* Different radio technologies (for example, Wi-Fi, Bluetooth, Mobile Broadband) are managed independently. The state
  of one does not imply the presence or state of another.
* Each enumeration call returns a snapshot of the radios known and active at that moment.
* System or administrative policy can limit which radios are visible or which state changes are permitted.
* Attach only one handler per component to a radio's [StateChanged](radio_statechanged.md) event to avoid duplicate
  processing of the same transition.

## -examples
### Enumerate, subscribe, and control radios (C#)
```csharp
using Windows.Devices.Radios;

var access = await Radio.RequestAccessAsync();
if (access == RadioAccessStatus.Allowed)
{
    var radios = await Radio.GetRadiosAsync();
    // Attach handlers before making any state changes so no events are missed.
    foreach (var r in radios)
    {
        r.StateChanged += (sender, _) => UpdateRadioDisplay(sender);
    }
    // Example: turn on all Wi-Fi radios that are currently off.
    foreach (var r in radios)
    {
        if (r.Kind == RadioKind.WiFi && r.State == RadioState.Off)
        {
            await r.SetStateAsync(RadioState.On);
        }
    }
}
```

## -see-also
