---
-api-id: M:Windows.Media.Audio.AudioStateMonitor.CreateForCaptureMonitoring(Windows.Media.Capture.MediaCategory)
-api-type: winrt method
---

<!-- Method syntax.
public AudioStateMonitor AudioStateMonitor.CreateForCaptureMonitoring(MediaCategory category)
-->

# Windows.Media.Audio.AudioStateMonitor.CreateForCaptureMonitoring

## -description
Initializes a new instance of the [AudioStateMonitor](audiostatemonitor.md) class that monitors the sound level for audio capture streams with the specified [MediaCategory](../windows.media.capture/mediacategory.md).

## -parameters
### -param category
A value from the [MediaCategory](../windows.media.capture/mediacategory.md) enumeration indicating the categories of audio streams that will be monitored. The system may use the category of an audio stream to determine if it should be muted or have its volume lowered in response to a particular system event.

## -returns
An [AudioStateMonitor](audiostatemonitor.md) object.

## -remarks
The method you use to instantiate **AudioStateMonitor** determines which audio streams are monitored. Other factory methods of the **AudioStateMonitor** class allow you to monitor the level of audio streams based on their [AudioDeviceRole](../windows.media.devices/audiodevicerole.md), the ID of the associated audio device, and whether the stream is capturing or rendering audio. 

## -see-also

## -examples

