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
This event signals that the effective observable state of the radio changed. When a USB Bluetooth radio is removed or
otherwise goes offline, no state change is reported. Intermediate transitions can be coalesced. Physical removal (for
example unplugging a USB adapter) may result in no further events; the radio simply no longer appears in later
enumerations. Always read the current state when handling the event rather than inferring unobserved intermediate
values. Handlers may be invoked on a non-UI thread.

## -examples

## -see-also
