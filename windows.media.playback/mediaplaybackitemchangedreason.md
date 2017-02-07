---
-api-id: T:Windows.Media.Playback.MediaPlaybackItemChangedReason
-api-type: winrt enumeration
---

<!-- Enumeration syntax.
public enum MediaPlaybackItemChangedReason : int {
	AppRequested = 3
	EndOfStream = 1
	Error = 2
	InitialItem = 0
}
-->

# Windows.Media.Playback.MediaPlaybackItemChangedReason

## -description
Specifies the reason why the current [MediaPlaybackItem](mediaplaybackitem.md) in a [MediaPlaybackList](mediaplaybacklist.md) changed. Check for the reason by accessing the [Reason](currentmediaplaybackitemchangedeventargs_reason.md) property of the [CurrentMediaPlaybackItemChangedEventArgs](currentmediaplaybackitemchangedeventargs.md) object passed into the [MediaPlaybackList.CurrentItemChanged](mediaplaybacklist_currentitemchanged.md) event.

## -enum-fields

## -field InitialItem:0
The current item is the first item in the playback list.

## -field Error:2
The current item changed because there was an error playing back the previous item in the list.

## -field EndOfStream:1
The current item changed because the previous item in the list played successfully to the end of its media stream.

## -field AppRequested:3
The current item changed because the app initiated the change.

## -remarks

## -see-also

## -examples

