---
-api-id: T:Windows.Media.Audio.AudioStateMonitor
-api-type: winrt class
---

<!-- Class syntax.
public class AudioStateMonitor 
-->

# Windows.Media.Audio.AudioStateMonitor

## -description
Allows a UWP app to determine if any of the app's audio streams are currently being muted or having their volume reduced by the system. 

## -remarks
Windows dynamically mutes or lowers the level of audio streams in response to system events. For example, the volume of a podcast app's audio render stream may be lowered while an alarm is ringing. Or an audio recording app may have their capture stream muted when the app moves to the background. This class allows apps to respond to changes in the level of their audio streams. For example, a podcast app may choose to pause playback when the sound level is lowered by the system and then resume playback when the volume level returns to normal. Or, an audio recording app may choose to stop recording while its capture stream is muted.

Create an **AudioStateMonitor** by calling one of its factory methods that determines which streams are monitored based on their [MediaCategory](../windows.media.capture/mediacategory.md), [AudioDeviceRole](../windows.media.devices/audiodevicerole.md), the ID of the associated audio device, and whether the stream is capturing or rendering audio. 

Use the [SoundLevel](../windows.media/soundlevel.md) property to determine the current sound level of the monitored streams. You can check the value of this property, to determine if a category of audio streams will be muted or have its volume lowered, before initiating audio capture or playback. You can register a handler for the [SoundLevelChanged](audiostatemonitor_soundlevelchanged.md) event to receive notifications when the sound level for a category of audio streams changes, and then check the **SoundLevel** property to determine the new current audio level.

For more information on using **AudioStateMonitor** in a UWP app, see [Detect and respond to audio state changes](/windows/uwp/audio-video-camera/detect-and-respond-to-audio-state-changes).

## -see-also

## -examples

