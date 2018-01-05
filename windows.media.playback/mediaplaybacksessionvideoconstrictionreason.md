---
-api-id: T:Windows.Media.Playback.MediaPlaybackSessionVideoConstrictionReason
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum MediaPlaybackSessionVideoConstrictionReason : int 
-->

# Windows.Media.Playback.MediaPlaybackSessionVideoConstrictionReason

## -description
Specifies the policy-based reason that video output of a media item is constricted.

## -enum-fields
### -field None:0
The content is not currently being constricted.

### -field VirtualMachine:1
The content is being played back on a virtual machine.

### -field UnsupportedDisplayAdapter:2
The content is being displayed on an unsupported display adapter.

### -field UnsignedDriver:3
The content is being displayed by a device with an unsigned driver.

### -field Unknown:6
The reason is unknown.

### -field OutputProtectionFailed:5
Output protection for the content failed.

### -field FrameServerEnabled:4
The content is being rendered in a [MediaPlayer](mediaplayer.md) with [IsVideoFrameServerEnabled](mediaplayer_isvideoframeserverenabled.md), providing direct access to video frames to the app.

## -remarks
This enumeration supports the [MediaPlaybackSessionOutputDegradationPolicyState.VideoConstrictionReason](mediaplaybacksessionoutputdegradationpolicystate_videoconstrictionreason.md) property.

## -see-also

## -examples

