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
The [Radio](radio.md) class serves as the primary interface for radio management on Windows devices, providing both 
enumeration capabilities and individual radio control.

### Radio discovery and access

Radio discovery begins with the static enumeration methods that allow you to find radios available on the system. You can 
retrieve all radios at once with [GetRadiosAsync](radio_getradiosasync_548754145.md), use 
[GetDeviceSelector](radio_getdeviceselector_838466080.md) for advanced device enumeration scenarios with DeviceWatcher, 
or create a Radio instance from a known device ID using [FromIdAsync](radio_fromidasync_1322863552.md).

Before attempting to control any radio, you must request permission using 
[RequestAccessAsync](radio_requestaccessasync_380675631.md). This is essential because radio control may require explicit 
user consent depending on regional settings and system configuration.

> [!IMPORTANT]
> Always call [RequestAccessAsync](radio_requestaccessasync_380675631.md) before attempting to change radio states. 
> In some regions and configurations, radio control requires explicit user consent.

### Radio properties and control

Once you have a Radio instance, you can examine its current state and properties. The [State](radio_state.md) property 
indicates whether the radio is currently on, off, or disabled, while [Kind](radio_kind.md) tells you the radio 
technology (Wi-Fi, Bluetooth, etc.), and [Name](radio_name.md) provides a human-readable identifier.

For state management, use [SetStateAsync](radio_setstateasync_1524539262.md) to turn radios on or off programmatically, 
and subscribe to the [StateChanged](radio_statechanged.md) event to respond to state transitions that occur due to user 
actions, system policies, or hardware switches.

### Platform and policy considerations

**Platform-specific behavior:**
- On Xbox, radio enumeration typically returns no results, and state change requests are generally denied by system policy
- On other platforms, similar restrictions may apply depending on system configuration, user permissions, or hardware capabilities

**System behavior:**
- Radios can appear or disappear during application lifetime
- Different radio types operate independently
- System policies may restrict radio visibility or control
- Hardware switches can force radios into [RadioState.Disabled](radiostate.md) state

## -examples

### Basic radio access and enumeration

```csharp
using Windows.Devices.Radios;

// Request permission to control radios
var accessStatus = await Radio.RequestAccessAsync();
if (accessStatus != RadioAccessStatus.Allowed)
{
    // App-specific: handle access denial
    return;
}

// Enumerate available radios and subscribe to state changes
var radios = await Radio.GetRadiosAsync();
foreach (var radio in radios)
{
    // Subscribe to state changes
    radio.StateChanged += (sender, args) => {
        // App-specific: respond to state changes
    };
    
    // App-specific: radio management logic based on radio.Kind and radio.State
}
```

For comprehensive radio management examples including capability-aware control, state monitoring, and device enumeration  
patterns, see the  
[RadioManager sample](https://github.com/microsoft/Windows-universal-samples/tree/main/Samples/RadioManager).

## -see-also
[DeviceInformation](../windows.devices.enumeration/deviceinformation.md),
[DeviceWatcher](../windows.devices.enumeration/devicewatcher.md),
[RadioAccessStatus](radioaccessstatus.md),
[RadioKind](radiokind.md),
[RadioState](radiostate.md)
