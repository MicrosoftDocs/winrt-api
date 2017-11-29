---
-api-id: P:Windows.Media.Audio.AudioStateMonitor.SoundLevel
-api-type: winrt property
---

<!-- Property syntax.
public SoundLevel SoundLevel { get; }
-->

# Windows.Media.Audio.AudioStateMonitor.SoundLevel

## -description
Gets a value indicating the current sound level of the audio streams being monitored by the [AudioStateMonitor](audiostatemonitor.md).
 
## -property-value
A value indicating the current sound level of the monitored audio streams.

## -remarks
The method you use to instantiate **AudioStateMonitor** determines which audio streams are monitored. The different factory methods of the **AudioStateMonitor** class allow you to monitor the level of audio streams based on their [MediaCategory](../windows.media.capture/mediacategory.md), [AudioDeviceRole](../windows.media.devices/audiodevicerole.md), the ID of the associated audio device, and whether the stream is capturing or rendering audio. 

You can check the value of this property, to determine if a category of audio streams will be muted or have its volume lowered, before initiating audio capture or playback. You can register a handler for the [SoundLevelChanged](audiostatemonitor_soundlevelchanged.md) event to receive notifications when the sound level for a category of audio streams changes, and then check the **SoundLevel** property to determine the new current audio level.

## -see-also

## -examples

