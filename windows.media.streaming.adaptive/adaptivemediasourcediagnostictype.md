---
-api-id: T:Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDiagnosticType
-api-type: winrt enumeration
---

<!-- Enumeration syntax.
public enum AdaptiveMediaSourceDiagnosticType : int {
	BitrateDisabled = 7
	ManifestMismatchUponReload = 1
	ManifestSignaledEndOfLiveEventUponReload = 2
	ManifestUnchangedUponReload = 0
	MediaSegmentSkipped = 3
	ResourceNotFound = 4
	ResourceParsingError = 6
	ResourceTimedOut = 5
}
-->

# Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDiagnosticType

## -description
Specifies the type of diagnostic event that is associated with a [AdaptiveMediaSourceDiagnostics.DiagnosticAvailable](adaptivemediasourcediagnostics_diagnosticavailable.md).

## -enum-fields

## -field ResourceTimedOut:5
The [AdaptiveMediaSource](adaptivemediasource.md) was unable to fully download a particular resource in the allotted amount of time.  The download may be attempted again, or the **AdaptiveMediaSource** may switch to another bitrate to continue filling the buffer at the current download position. 

## -field ResourceParsingError:6
The [AdaptiveMediaSource](adaptivemediasource.md) encountered an error while parsing a segment or key.  This can indicate corruption on the CDN or an invalid decryption key. 

## -field ResourceNotFound:4
The AdaptiveMediaSource got a resource not found error when downloading a particular resource. This may indicate a problem with the content manifest or an issue with the CDN. 

## -field MediaSegmentSkipped:3
The [AdaptiveMediaSource](adaptivemediasource.md) skipped an entire media segment across all bitrates.  This could happen due to corruption on the CDN or missing resources. This will typically result in a gap in playback and video/audio artifacts. 

## -field ManifestUnchangedUponReload:0
During playback of live content, the new manifest is identical to the last one downloaded.  For HLS where the manifest is updated continuously to add new segments to the end of the playlist, this may indicate a stall in the server or encoding process. 

## -field ManifestSignaledEndOfLiveEventUponReload:2
During the playback of live content, the previous manifest did not specify a duration or contain an end of list indicator, and the new updated manifest does specify a duration or end of list indicator.  This means that a live presentation will end after the remaining media segments are downloaded and played. 

## -field ManifestMismatchUponReload:1
During playback of live content, the new manifest represents a different presentation than the previously downloaded manifest. 
This will also result in a playback error event for the associated [MediaElement](/uwp/api/windows.ui.xaml.controls.mediaelement) or [MediaPlayer](/uwp/api/windows.media.playback.mediaplayer). 

## -field BitrateDisabled:7
The [AdaptiveMediaSource](adaptivemediasource.md) will not attempt to download any more segments for a particular bitrate.   
This can occur if the web server returns a 410 – Gone response when downloading a manifest update for a particular bitrate if the server implements server side congestion control. It can also occur if the AdaptiveMediaSource is unable to download either the initialization segment or decryption key for a particular bitrate. 

### -field FatalMediaSourceError:8
Introduced in Windows.Foundation.UniversalApiContract v5. The **[AdaptiveMediaSource](/uwp/api/Windows.Media.Streaming.Adaptive.AdaptiveMediaSource)** passed an error to the media pipeline that caused playback to stop. This diagnostic is not intended to replace media failure events provided by the [MediaPlayer](/uwp/api/windows.media.playback.mediaplayer), such as the **[MediaFailed](/uwp/api/windows.media.playback.mediaplayer.MediaFailed)** event. Instead, this diagnostic can be useful for correlating errors originating from the media source with potential corruption of error conditions with the content delivery network. 

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | FatalMediaSourceError |

## -see-also

## -examples


