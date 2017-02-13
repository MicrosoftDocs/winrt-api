---
-api-id: M:Windows.Devices.Midi.MidiInPort.FromIdAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Midi.MidiInPort> FromIdAsync(System.String deviceId)
-->

# Windows.Devices.Midi.MidiInPort.FromIdAsync

## -description
Creates a [MidiInPort](midiinport.md) object for the specified device.

## -parameters
### -param deviceId
The device ID, which can be obtained by enumerating the devices on the system [Windows.Devices.Enumeration.DeviceInformation.FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync.md).

## -returns
The asynchronous operation. Upon completion, [IAsyncOperation.GetResults](../windows.foundation/iasyncoperation_1_getresults.md) returns a [MidiInPort](midiinport.md) object.

## -remarks
To enumerate the [MidiInPort](midiinport.md) objects on the system, pass the query string provided by [GetDeviceSelector](midiinport_getdeviceselector.md) to [Windows.Devices.Enumeration.DeviceInformation.FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync.md).

Suggested times to attempt to create a **MidiInPort** are on any sort of app activation or user interaction. If a function call on a **MidiInPort** fails, or if a message received from a **MidiInPort** is invalid, do not try to recreate the port immediately.

## -examples

## -see-also
