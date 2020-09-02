---
-api-id: T:Windows.Media.Playback.MediaBreak
-api-type: winrt class
---

<!-- Class syntax.
public class MediaBreak : Windows.Media.Playback.IMediaBreak
-->

# Windows.Media.Playback.MediaBreak

## -description
Represents a set of one or more [MediaPlaybackItem](mediaplaybackitem.md) objects that are played before, after, or at specified points during the playback of another [MediaPlaybackItem](mediaplaybackitem.md).

## -remarks
Get a reference to the currently playing **MediaBreak** using the constructor or by accessing the [CurrentBreak](mediabreakmanager_currentbreak.md) property of the [MediaBreakManager](mediabreakmanager.md). When a media break begins playing, you can get a reference to the associated **MediaBreak** object by handling the [BreakStarted](mediabreakmanager_breakstarted.md) event and accessing the [MediaBreak](mediabreakendedeventargs_mediabreak.md) property of the [MediaBreakStartedEventArgs](mediabreakstartedeventargs.md) passed into the handler.

Get or set a pre-roll or post-roll media break for a media item by accessing the [PrerollBreak](mediabreakschedule_prerollbreak.md) or [PostrollBreak](mediabreakschedule_postrollbreak.md) property of the [MediaBreakSchedule](mediabreakschedule.md) object associated with a [MediaPlaybackItem](mediaplaybackitem.md).

For how-to guidance for working with media breaks, see [Create, schedule, and manage media breaks](/windows/uwp/audio-video-camera/create-schedule-and-manage-media-breaks).

## -examples

## -see-also
[Create, schedule, and manage media breaks](/windows/uwp/audio-video-camera/create-schedule-and-manage-media-breaks)