---
-api-id: T:Windows.Devices.Midi.MidiMessageType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.Midi.MidiMessageType : int
-->

# MidiMessageType

## -description
Specifies constants used to map MIDI message types into their corresponding byte codes.

## -enum-fields
### -field None:0
Specifies no message type.

### -field NoteOff:128
A [MidiNoteOffMessage](midinoteoffmessage.md).

### -field NoteOn:144
A [MidiNoteOnMessage](midinoteonmessage.md).

### -field PolyphonicKeyPressure:160
A [MidiPolyphonicKeyPressureMessage](midipolyphonickeypressuremessage.md).

### -field ControlChange:176
A [MidiControlChangeMessage](midicontrolchangemessage.md).

### -field ProgramChange:192
A [MidiControlChangeMessage](midicontrolchangemessage.md).

### -field ChannelPressure:208
A [MidiChannelPressureMessage](midichannelpressuremessage.md).

### -field PitchBendChange:224
A [MidiPitchBendChangeMessage](midipitchbendchangemessage.md).

### -field SystemExclusive:240
A [MidiSystemExclusiveMessage](midisystemexclusivemessage.md).

### -field MidiTimeCode:241
A [MidiTimeCodeMessage](miditimecodemessage.md).

### -field SongPositionPointer:242
A [MidiSongPositionPointerMessage](midisongpositionpointermessage.md).

### -field SongSelect:243
A [MidiSongSelectMessage](midisongselectmessage.md).

### -field TuneRequest:246
A [MidiTuneRequestMessage](miditunerequestmessage.md).

### -field EndSystemExclusive:247
A [MidiSystemExclusiveMessage](midisystemexclusivemessage.md).

### -field TimingClock:248
A [MidiTimingClockMessage](miditimingclockmessage.md).

### -field Start:250
A [MidiStartMessage](midistartmessage.md).

### -field Continue:251
A [MidiContinueMessage](midicontinuemessage.md).

### -field Stop:252
A [MidiStopMessage](midistopmessage.md).

### -field ActiveSensing:254
A [MidiActiveSensingMessage](midiactivesensingmessage.md).

### -field SystemReset:255
A [SystemResetMessage](midisystemresetmessage.md).

## -remarks
Channel message values are put into the high nibble of the status byte of the Midi message.

System messages represent the entire status byte.

These values are pre-defined by the MIDI specification. The reserved system message bytes have been omitted.

## -examples

## -see-also

[MIDI sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/MIDI)

