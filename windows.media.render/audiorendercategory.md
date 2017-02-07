---
-api-id: T:Windows.Media.Render.AudioRenderCategory
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Render.AudioRenderCategory : int
-->

# AudioRenderCategory

## -description
Describes the purpose of the audio information in an audio stream.

## -enum-fields
### -field Other:0
All other streams.

### -field ForegroundOnlyMedia:1
Audio is for general media, for example audio for video, or streaming audio, but should not be played as background.

### -field BackgroundCapableMedia:2
Audio is for general media, for example audio for video, or streaming audio, and can be played as background.

### -field Communications:3
Audio is for peer-to-peer communications, for example chat or VoIP.

### -field Alerts:4
Audio is for system or application notifications, for example ring tones.

### -field SoundEffects:5
Audio is for sound effects.

### -field GameEffects:6
Audio is for game-specific sound effects.

### -field GameMedia:7
Audio is background (non-event or ambient) audio for games.

### -field GameChat:8
Audio is voice chat for games.

### -field Speech:9
Audio is speech.

### -field Movie:10
Audio is movie audio.

### -field Media:11
Audio is media playback.


## -remarks

## -examples

## -see-also