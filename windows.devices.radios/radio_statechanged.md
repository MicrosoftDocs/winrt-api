---
-api-id: E:Windows.Devices.Radios.Radio.StateChanged
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler StateChanged<Windows.Devices.Radios.Radio,  object>
-->

# Windows.Devices.Radios.Radio.StateChanged

## -description
Event raised when the radio state changes.

## -remarks
The [StateChanged](radio_statechanged.md) event provides notification when a radio's operational state transitions between 
[RadioState](radiostate.md) values, enabling applications to respond to both user-initiated and system-initiated changes.

### Event behavior and timing

**State change detection:**
- Event fires for all observable state transitions ([On](radiostate.md), [Off](radiostate.md), [Disabled](radiostate.md), [Unknown](radiostate.md))
- Rapid intermediate transitions may be coalesced into single events
- Physical radio removal typically results in no event - the radio disappears from subsequent enumerations

**Threading considerations:**
- Event handlers are invoked on background threads
- Use appropriate thread marshalling when interfacing with thread-sensitive operations
- Avoid long-running operations in event handlers to prevent blocking radio state monitoring

### Event handling best practices

**State reading:**
- Always read [Radio.State](radio_state.md) property when handling events
- Do not assume intermediate state transitions occurred
- Handle all possible [RadioState](radiostate.md) values

**Resource management:**
- Unsubscribe from events when radio objects are no longer needed
- Avoid subscribing multiple handlers to the same radio
- Consider using weak event patterns for long-lived objects

> [!NOTE]
> Event handlers are invoked on background threads. Use appropriate thread marshalling mechanisms when interfacing with 
> thread-sensitive operations.

## -examples

For complete radio enumeration and state monitoring examples, see [Radio class documentation](radio.md).

## -see-also
[Radio](radio.md),
[Radio.State](radio_state.md),
[RadioState](radiostate.md)
