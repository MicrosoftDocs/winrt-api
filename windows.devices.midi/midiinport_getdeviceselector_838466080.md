---
-api-id: M:Windows.Devices.Midi.MidiInPort.GetDeviceSelector
-api-type: winrt method
---

<!-- Method syntax
public string GetDeviceSelector()
-->

# Windows.Devices.Midi.MidiInPort.GetDeviceSelector

## -description
Gets a query string that can be used to enumerate all [MidiInPort](midiinport.md) objects on the system.

## -returns
The query string used to enumerate the [MidiInPort](midiinport.md) objects on the system.

## -remarks
To enumerate the [MidiInPort](midiinport.md) objects on the system, pass the query string provided by this method to [Windows.Devices.Enumeration.DeviceInformation.FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync.md).

## -examples

## -see-also
