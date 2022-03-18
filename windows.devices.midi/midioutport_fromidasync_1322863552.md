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

```csharp
// Opens the default MIDI output device.
private async Task<IMidiOutPort> OpenDefaultMidiOut()
{
    IMidiOutPort midiOut = null;

    string midiOutQueryString = MidiOutPort.GetDeviceSelector();
    DeviceInformationCollection midiOutDevices = await DeviceInformation.FindAllAsync(midiOutQueryString);
    int selectedMidiDevice = 0;

    if (0 == midiOutDevices.Count)
    {
        Debug.WriteLine("No Midi output devices");
        return null;
    }
    // If there are > 1 MIDI out devices, pick the first non-integrated one.
    else if (2 <= midiOutDevices.Count)
    {
        for (int midiDeviceIdx = 0; midiDeviceIdx < midiOutDevices.Count; midiDeviceIdx++)
        {
            if (false == MidiSynthesizer.IsSynthesizer(midiOutDevices[midiDeviceIdx]))
            {
                selectedMidiDevice = midiDeviceIdx;
                break;
            }
        }
    }

    midiOut = await MidiOutPort.FromIdAsync(midiOutDevices[selectedMidiDevice].Id);

    return midiOut;
}
```

```cppwinrt
// Opens the default MIDI output device.
winrt::Windows::Foundation::IAsyncOperation<IMidiOutPort> OpenDefaultMidiOut()
{
    IMidiOutPort midiOut{ nullptr };

    winrt::hstring midiOutQueryString{ MidiOutPort::GetDeviceSelector() };
    DeviceInformationCollection midiOutDevices{ co_await DeviceInformation::FindAllAsync(midiOutQueryString) };
    uint32_t selectedMidiDevice{ 0 };

    if (0 == midiOutDevices.Size())
    {
        // No Midi output devices.
        co_return midiOut;
    }
    // If there are > 1 MIDI out devices, pick the first non-integrated one.
    else if (2 <= midiOutDevices.Size())
    {
        for (uint32_t midiDeviceIdx = 0; midiDeviceIdx < midiOutDevices.Size(); midiDeviceIdx++)
        {
            if (false == MidiSynthesizer::IsSynthesizer(midiOutDevices.GetAt(midiDeviceIdx)))
            {
                selectedMidiDevice = midiDeviceIdx;
                break;
            }
        }
    }

    midiOut = co_await MidiOutPort::FromIdAsync(midiOutDevices.GetAt(selectedMidiDevice).Id());

    co_return midiOut;
}
```

## -see-also
