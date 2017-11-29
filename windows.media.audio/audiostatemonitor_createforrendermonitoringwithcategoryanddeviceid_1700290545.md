---
-api-id: M:Windows.Media.Audio.AudioStateMonitor.CreateForRenderMonitoringWithCategoryAndDeviceId(Windows.Media.Render.AudioRenderCategory,System.String)
-api-type: winrt method
---

<!-- Method syntax.
public AudioStateMonitor AudioStateMonitor.CreateForRenderMonitoringWithCategoryAndDeviceId(AudioRenderCategory category, String deviceId)
-->

# Windows.Media.Audio.AudioStateMonitor.CreateForRenderMonitoringWithCategoryAndDeviceId

## -description
Initializes a new instance of the [AudioStateMonitor](audiostatemonitor.md) class that monitors the sound level for audio render streams with the specified [MediaCategory](../windows.media.capture/mediacategory.md) that are using the specified audio device.

## -parameters
### -param category
A value from the [MediaCategory](../windows.media.capture/mediacategory.md) enumeration indicating the categories of audio streams that will be monitored. The system may use the category of an audio stream to determine if it should be muted or have its volume lowered in response to a particular system event.

### -param deviceId
A string containing the unique identifier of a audio device for which associated audio streams will be monitored.

## -returns
An [AudioStateMonitor](audiostatemonitor.md) object.

## -remarks
The method you use to instantiate **AudioStateMonitor** determines which audio streams are monitored. Other factory methods of the **AudioStateMonitor** class allow you to monitor the level of audio streams based on their [AudioDeviceRole](../windows.media.devices/audiodevicerole.md) and whether the stream is capturing or rendering audio. 

Call [FindAllAsync](../windows.devices.enumeration/deviceinformation_findallasync_326280522.md), passing in the value returned by [GetAudioRenderSelector](../windows.media.devices/mediadevice_getaudiorenderselector_1223331501.md), to get the list of  [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) objects representing the available audio render devices.

## -see-also

## -examples

