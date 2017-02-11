---
-api-id: M:Windows.Devices.Midi.MidiPolyphonicKeyPressureMessage.#ctor(System.Byte,System.Byte,System.Byte)
-api-type: winrt method
---

<!-- Method syntax
public MidiPolyphonicKeyPressureMessage(System.Byte channel, System.Byte note, System.Byte pressure)
-->

# Windows.Devices.Midi.MidiPolyphonicKeyPressureMessage.MidiPolyphonicKeyPressureMessage

## -description
Creates a new [MidiPolyphonicKeyPressureMessage](midipolyphonickeypressuremessage.md) object.

## -parameters
### -param channel
The channel from 0-15 that this message applies to.

### -param note
The note which is specified as a value from 0-127.

### -param pressure
The polyphonic key pressure which is specified as a value from 0-127.

## -remarks
If any of the values passed in to the constructor do not adhere to the specified requirements, an ArgumentException will be thrown.

## -examples

## -see-also
