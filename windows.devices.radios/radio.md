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

**Static enumeration methods:**
- **[GetRadiosAsync](radio_getradiosasync_548754145.md)**: Retrieves all available radios on the system
- **[GetDeviceSelector](radio_getdeviceselector_838466080.md)**: Returns a device selector string for advanced device enumeration
- **[FromIdAsync](radio_fromidasync_1322863552.md)**: Creates a Radio object from a specific device ID

**Access control:**
- **[RequestAccessAsync](radio_requestaccessasync_380675631.md)**: Requests permission to control radio states

> [!IMPORTANT]
> Always call [RequestAccessAsync](radio_requestaccessasync_380675631.md) before attempting to change radio states. 
> In some regions and configurations, radio control requires explicit user consent.

### Radio properties and control

**Core properties:**
- **[State](radio_state.md)**: Current radio state ([RadioState](radiostate.md))
- **[Kind](radio_kind.md)**: Radio technology type ([RadioKind](radiokind.md))  
- **[Name](radio_name.md)**: Human-readable radio name

**State control:**
- **[SetStateAsync](radio_setstateasync_1524539262.md)**: Changes radio state (On/Off)
- **[StateChanged](radio_statechanged.md)**: Event fired when radio state changes

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

private async Task<bool> CheckRadioAccessAsync()
{
    var accessStatus = await Radio.RequestAccessAsync();
    if (accessStatus != RadioAccessStatus.Allowed)
    {
        // App-specific: handle access denial
        return false;
    }
    
    var radios = await Radio.GetRadiosAsync();
    foreach (var radio in radios)
    {
        // App-specific: process each radio based on kind and state
        ProcessRadio(radio);
    }
    
    return true;
}

private void ProcessRadio(Radio radio)
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
