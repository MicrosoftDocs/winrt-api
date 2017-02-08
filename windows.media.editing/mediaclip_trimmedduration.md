---
-api-id: P:Windows.Media.Editing.MediaClip.TrimmedDuration
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.TimeSpan TrimmedDuration { get; }
-->

# Windows.Media.Editing.MediaClip.TrimmedDuration

## -description
Duration of the media clip with [TrimTimeFromStart](mediaclip_trimtimefromstart.md) and [TrimTimeFromEnd](mediaclip_trimtimefromend.md) applied to playback.

## -property-value
The trimmed duration of the media clip is equal to [OriginalDuration](mediaclip_originalduration.md) - ([TrimTimeFromStart](mediaclip_trimtimefromstart.md) + [TrimTimeFromEnd](mediaclip_trimtimefromend.md)).

## -remarks

## -examples

## -see-also
