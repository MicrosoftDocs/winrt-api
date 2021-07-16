---
-api-id: P:Windows.Media.Playback.MediaPlayer.AudioStateMonitor
-api-type: winrt property
---

<!-- Property syntax.
public AudioStateMonitor AudioStateMonitor { get; }
-->

# Windows.Media.Playback.MediaPlayer.AudioStateMonitor

## -description
Gets an [AudioStateMonitor](../windows.media.audio/audiostatemonitor.md) object that allows a UWP app to determine if any of the app's audio streams are currently being muted or having their volume reduced by the system. 

## -property-value
An [AudioStateMonitor](../windows.media.audio/audiostatemonitor.md) object.

## -remarks
Windows dynamically mutes or lowers the level of audio streams in response to system events. For example, the volume of a podcast app's audio render stream may be lowered while an alarm is ringing. **AudioStateMonitor** allows apps to respond to changes in the level of their audio streams. For example, a podcast app may choose to pause playback when the sound level is lowered by the system and then resume playback when the volume level returns to normal. 

Use the [AudioStateMonitor.SoundLevel](../windows.media/soundlevel.md) property to determine the current sound level of the **MediaPlayer**. Register a handler for the [SoundLevelChanged](../windows.media.audio/audiostatemonitor_soundlevelchanged.md) event to receive notifications when the sound level of the **MediaPlayer** changes, and then check the **SoundLevel** property to determine the new current audio level.

## -see-also

## -examples





