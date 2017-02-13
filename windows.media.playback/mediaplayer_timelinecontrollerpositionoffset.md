---
-api-id: P:Windows.Media.Playback.MediaPlayer.TimelineControllerPositionOffset
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.TimeSpan TimelineControllerPositionOffset { get;  set; }
-->

# Windows.Media.Playback.MediaPlayer.TimelineControllerPositionOffset

## -description
Gets or sets the offset applied to the position of the [MediaTimelineController](../windows.media/mediatimelinecontroller.md) associated with the [MediaPlayer](mediaplayer.md).

## -property-value
The offset applied to the position of the [MediaTimelineController](../windows.media/mediatimelinecontroller.md) associated with the [MediaPlayer](mediaplayer.md).

## -remarks
A [MediaTimelineController](../windows.media/mediatimelinecontroller.md) can be associated with multiple instances of [MediaPlayer](mediaplayer.md) which could be playing different media sources. This property allows you to offset the actual playback position of the player from the current position of the timeline controller.

## -examples

## -see-also
