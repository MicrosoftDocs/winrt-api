---
-api-id: E:Windows.Devices.Midi.MidiInPort.MessageReceived
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler MessageReceived<Windows.Devices.Midi.MidiInPort,  Windows.Devices.Midi.MidiMessageReceivedEventArgs>
-->

# Windows.Devices.Midi.MidiInPort.MessageReceived

## -description
Occurs when the [MidiInPort](midiinport.md) receives data.

## -remarks
Apps should subscribe to this event to handle the input messages.

If accessing any part of the message results in an exception, it can be assumed that the [MidiInPort](midiinport.md) has been disconnected from the device.

## -examples

## -see-also
