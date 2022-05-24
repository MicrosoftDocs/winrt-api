---
-api-id: T:Windows.UI.Xaml.Media.AudioCategory
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Media.AudioCategory : int
-->

# AudioCategory

## -description

Describes the purpose of the audio information in an audio stream. Used as a value by [AudioCategory](../windows.ui.xaml.controls/mediaelement_audiocategory.md).


## -enum-fields

### -field Other:0

All other streams.

### -field ForegroundOnlyMedia:1

Audio is for general media, for example audio for video, or streaming audio, but should not be played as background. This enumeration value is deprecated. For more information, see **Remarks**.

### -field BackgroundCapableMedia:2

Audio is for general media, for example audio for video, or streaming audio, and can be played as background. This enumeration value is deprecated. For more information, see **Remarks**.

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

Game chat audio. Similar to **Communications** except that **GameChat** will not attenuate other streams.

### -field Speech:9

Audio is speech.

### -field Movie:10

Stream that includes audio with dialog.

### -field Media:11

Stream that includes audio without dialog.

## -remarks

These enumeration values are used by the [MediaElement.AudioCategory](../windows.ui.xaml.controls/mediaelement_audiocategory.md) property. If you use the [MediaPlayerElement](../windows.ui.xaml.controls/mediaplayerelement.md) control, you use the [MediaPlayerAudioCategory](../windows.media.playback/mediaplayeraudiocategory.md) enumeration values to set the [AudioCategory](../windows.media.playback/mediaplayer_audiocategory.md) directly on the underlying [MediaPlayer](../windows.media.playback/mediaplayer.md) instead.

Starting in Windows 10, version 1511 the **ForegroundOnlyMedia** and **BackgroundCapableMedia** enumeration values are deprecated. For more info about using background audio in your app, see [Play media in the background](/windows/uwp/audio-video-camera/background-audio).

Games should categorize their music streams as **GameMedia** so that game music mutes automatically if another application plays music in the background. Music or video applications should categorize their streams as **Media** or **Movie** so they will take priority over **GameMedia** streams. Game audio for in-game cinematics or cutscenes, when the audio is premixed or for creative reasons should take priority over background audio, should also be categorized as **Media** or **Movie**.

## -examples

## -see-also

[Audio categories sample](https://github.com/Microsoft/Windows-universal-samples/tree/dev/Samples/AudioCategory)
