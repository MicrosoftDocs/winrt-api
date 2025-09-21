---
-api-id: P:Windows.Devices.Radios.Radio.State
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Devices.Radios.RadioState State { get; }
-->

# Windows.Devices.Radios.Radio.State

## -description
Gets the current state of the radio represented by this object.

## -property-value
The current radio state.

## -remarks
The value reflects the current effective state when accessed. Internal intermediate transitions may be coalesced and
not all steps are observable. The state of one radio does not imply the state or availability of other radio
technologies.

## -examples

## -see-also