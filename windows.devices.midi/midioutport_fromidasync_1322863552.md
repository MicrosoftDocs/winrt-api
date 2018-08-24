---
-api-id: M:Windows.Devices.Midi.MidiOutPort.FromIdAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Midi.IMidiOutPort> FromIdAsync(System.String deviceId)
-->

# Windows.Devices.Midi.MidiOutPort.FromIdAsync

## -description
Creates a [MidiOutPort](midioutport.md) object for the specified device.

## -parameters
### -param deviceId
The device ID, which can be obtained by enumerating the devices on the system [Windows.Devices.Enumeration.DeviceInformation.FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md).

## -returns
The asynchronous operation. Upon completion, [IAsyncOperation.GetResults](../windows.foundation/iasyncoperation_1_getresults_732303200.md) returns a [MidiOutPort](midioutport.md) object.

## -remarks
To enumerate the [MidiOutPort](midioutport.md) objects on the system, pass the query string provided by [GetDeviceSelector](midiinport_getdeviceselector_838466080.md) to [Windows.Devices.Enumeration.DeviceInformation.FindAllAsync](/uwp/api/windows.devices.enumeration.deviceinformation.findallasync).

Suggested times to attempt to create a **MidiInPort** are on any sort of app activation or user interaction. If a function call on a **MidiInPort** fails, or if a message received from a **MidiInPort** is invalid, do not try to recreate the port immediately.

## -examples

## -see-also
