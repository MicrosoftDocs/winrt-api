---
-api-id: E:Windows.Media.Audio.AudioStateMonitor.SoundLevelChanged
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler SoundLevelChanged<AudioStateMonitor,  object>
-->

# Windows.Media.Audio.AudioStateMonitor.SoundLevelChanged

## -description
Occurs when the system changes the sound level of the audio streams being monitored by the [AudioStateMonitor](audiostatemonitor.md). 

## -remarks
Windows dynamically mutes or lowers the level of audio streams in response to system events. For example, the volume of a podcast app's audio render stream may be lowered while an alarm is ringing. Or an audio recording app may have their capture stream muted when the app moves to the background. Register a handler for this event to receive notifications when the sound level for a category of audio streams changes, and then check the [SoundLevel](../windows.media/soundlevel.md) property to determine the new current audio level.

## -see-also

## -examples

