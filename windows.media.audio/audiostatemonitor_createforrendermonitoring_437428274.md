---
-api-id: M:Windows.Media.Audio.AudioStateMonitor.CreateForRenderMonitoring
-api-type: winrt method
---

<!-- Method syntax.
public AudioStateMonitor AudioStateMonitor.CreateForRenderMonitoring()
-->

# Windows.Media.Audio.AudioStateMonitor.CreateForRenderMonitoring

## -description
Initializes a new instance of the [AudioStateMonitor](audiostatemonitor.md) class that monitors the sound level for all audio render streams.

## -returns
An [AudioStateMonitor](audiostatemonitor.md) object.

## -remarks
The method you use to instantiate **AudioStateMonitor** determines which audio streams are monitored. Other factory methods of the **AudioStateMonitor** class allow you to monitor the level of audio streams based on their [MediaCategory](../windows.media.capture/mediacategory.md), [AudioDeviceRole](../windows.media.devices/audiodevicerole.md), the ID of the associated audio device, and whether the stream is capturing or rendering audio. 

## -see-also

## -examples

