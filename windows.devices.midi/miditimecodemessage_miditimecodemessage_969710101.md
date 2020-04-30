---
-api-id: M:Windows.Devices.Midi.MidiTimeCodeMessage.#ctor(System.Byte,System.Byte)
-api-type: winrt method
---

<!-- Method syntax
public MidiTimeCodeMessage(System.Byte frameType, System.Byte values)
-->

# Windows.Devices.Midi.MidiTimeCodeMessage.MidiTimeCodeMessage

## -description
Creates a new [MidiTimeCodeMessage](miditimecodemessage.md) object.

## -parameters
### -param frameType
The frame type from 0-7.

### -param values
The time code from 0-15.

## -remarks
If any values passed into the constructor fo not adhere to the specified requirements, an invalid argument exception will be thrown.

## -examples

## -see-also
