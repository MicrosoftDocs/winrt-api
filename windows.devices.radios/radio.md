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
Your code uses static members of this class like [GetRadiosAsync](radio_getradiosasync_548754145.md), [GetDeviceSelector](radio_getdeviceselector_838466080.md), and [FromIdAsync](radio_fromidasync_1322863552.md) to query for radios and to retrieve instantiated Radio objects representing particular radios on the device.

Note that your code should call [RequestAccessAsync](radio_requestaccessasync_380675631.md) at least once, from the UI thread, before trying to call [SetStateAsync](radio_setstateasync_1524539262.md). This is because in some regions, with some user settings choices, attempting to change radio state requires user permission. In this situation, calling [RequestAccessAsync](radio_requestaccessasync_380675631.md) shows the user a prompt asking if they want to allow your app to have permission to control the radio. If your app is running on a device that requires user permission and your code hasn't requested and received permission, then [SetStateAsync](radio_setstateasync_1524539262.md) will fail for lack of user permission.

Functional behavior:

* Radios can appear or disappear while your app is running; enumeration is not fixed after launch.
* A newly discovered radio may already be On or Off based on prior system configuration or policy.
* Removing a radio (for example, unplugging a USB adapter) causes it simply to stop appearing in subsequent enumerations; there is no transient “removed” state object.
* Rapid internal state transitions may be coalesced; only a final observable state might surface through events.
* Friendly names can change. Do not use a friendly name as a persistent identifier.
* Different radio technologies (for example, Wi‑Fi, Bluetooth, Mobile Broadband) are managed independently. The state of one does not imply the presence or state of another.
* Enumeration calls present a snapshot. Each call reflects the set of radios known and active at that moment.
* System or administrative policy can limit which radios are visible or which state changes are permitted.
* Attach only one handler per component to a radio's [StateChanged](radio_statechanged.md) event to avoid redundant processing of the same transition.

## -examples
### Enumerate, subscribe, and control radios (C#)
```csharp
var access = await Radio.RequestAccessAsync();
if (access == RadioAccessStatus.Allowed)
{
	var radios = await Radio.GetRadiosAsync();
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
