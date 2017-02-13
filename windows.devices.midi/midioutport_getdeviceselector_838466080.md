---
-api-id: M:Windows.Devices.Midi.MidiOutPort.GetDeviceSelector
-api-type: winrt method
---

<!-- Method syntax
public string GetDeviceSelector()
-->

# Windows.Devices.Midi.MidiOutPort.GetDeviceSelector

## -description
Gets a query string that can be used to enumerate all [MidiOutPort](midioutport.md) objects on the system.

## -returns
The query string used to enumerate the [MidiOutPort](midioutport.md) objects on the system.

## -remarks
To enumerate the [MidiOutPort](midioutport.md) objects on the system, pass the query string provided by this method to [Windows.Devices.Enumeration.DeviceInformation.FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync.md).

## -examples

## -see-also
