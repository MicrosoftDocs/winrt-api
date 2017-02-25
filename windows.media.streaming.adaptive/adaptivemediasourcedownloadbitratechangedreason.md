---
-api-id: T:Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadBitrateChangedReason
-api-type: winrt enumeration
---

<!-- Enumeration syntax.
public enum AdaptiveMediaSourceDownloadBitrateChangedReason : int {
	DesiredBitratesChanged = 5
	ErrorInPreviousBitrate = 6
	InsufficientInboundBitsPerSecond = 1
	LowBufferLevel = 2
	PositionChanged = 3
	SufficientInboundBitsPerSecond = 0
	TrackSelectionChanged = 4
}
-->

# Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceDownloadBitrateChangedReason

## -description
Specifies the reason that the download bitrate changed. This value is used for the [AdaptiveMediaSource.DownloadBitrateChanged](adaptivemediasource_downloadbitratechanged.md) event.

## -enum-fields

## -field TrackSelectionChanged:4
The bitrate changed as a result of a track selection change.  The system may switch to a lower bitrate temporarily in order to refill the buffer for the new track and resume playback faster. 

## -field SufficientInboundBitsPerSecond:0
The estimated [InboundBitsPerSecond](adaptivemediasource_inboundbitspersecond.md) was large enough to allow switching to a higher bitrate. 

## -field PositionChanged:3
The bitrate changed as a result of seeking to a new position.  The system may switch to a lower bitrate temporarily in order to refill the buffer and resume playback faster. 

## -field LowBufferLevel:2
The amount of data buffered ahead of the playback position dropped enough that a change in download bitrate was required in order to avoid stalling playback while rebuffering. 

## -field InsufficientInboundBitsPerSecond:1
The estimated [InboundBitsPerSecond](adaptivemediasource_inboundbitspersecond.md) dropped, which required switching to a lower bitrate to avoid stalls in playback. 

## -field ErrorInPreviousBitrate:6
The bitrate changed as a result of an error occurring with the previously selected bitrate.  If there is a missing resource, or corruption is detected, or a download times out, the system may switch to a different bitrate in order to fill the buffer at the current download position to avoid gaps in playback. The conditions that caused an error in the previous bitrate will also generate other events that can be observed, such as [DownloadFailed](adaptivemediasource_downloadfailed.md) or the [AdaptiveMediaSourceDiagnostics.DiagnosticAvailable](adaptivemediasourcediagnostics_diagnosticavailable) event. 

## -field DesiredBitratesChanged:5
The bitrate changed as a result of the app changing one of the properties on the [AdaptiveMediaSource](adaptivemediasource.md) such as the [DesiredMinBitrate](adaptivemediasource_desiredminbitrate.md), [DesiredMaxBitrate](adaptivemediasource_desiredmaxbitrate.md), or [InitialBitrate](adaptivemediasource_initialbitrate.md). 

## -remarks

## -see-also

## -examples

