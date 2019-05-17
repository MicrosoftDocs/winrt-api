---
-api-id: P:Windows.Media.SystemMediaTransportControls.SoundLevel
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.SoundLevel SoundLevel { get; }
-->

# Windows.Media.SystemMediaTransportControls.SoundLevel

## -description
Gets the sound level of the media for the capture and render streams.

## -property-value
The sound level.

## -remarks
Music and media capture apps should monitor the SoundLevel to determine whether the audio streams on the app have been [Muted](soundlevel.md). For apps using the [MediaCapture](../windows.media.capture/mediacapture.md) object, capture will be automatically stopped when the capture streams of the app are muted. Capture is not re-started automatically when the audio streams are unmuted, so the SoundLevel changed notification can be used to restart capture. Use the [PropertyChanged](systemmediatransportcontrols_propertychanged.md) event to determine when the SoundLevel property changes.

## -examples

## -see-also
