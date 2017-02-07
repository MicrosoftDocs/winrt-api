---
-api-id: T:Windows.Media.Playback.MediaPlayerAudioCategory
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Playback.MediaPlayerAudioCategory : int
-->

# MediaPlayerAudioCategory

## -description
Specifies the types of audio that can be played by a media player.

## -enum-fields
### -field Other:0
The audio type is not one of the provided enumeration values.

### -field Communications:3
The audio is used for communications.

### -field Alerts:4
The audio is used for alerts.

### -field SoundEffects:5
The audio is a sound effect.

### -field GameEffects:6
The audio is a game effect.

### -field GameMedia:7
The audio is game media, such as background music.

### -field GameChat:8
The audio is used for game chat.

### -field Speech:9
The audio is used for speech.

### -field Movie:10
The audio is for movie playback.

### -field Media:11
The audio is for media playback.


## -remarks
Games should categorize their music streams as **GameMedia** so that game music mutes automatically if another application plays music in the background. Music or video applications should categorize their streams as **Media** or **Movie** so they will take priority over **GameMedia** streams.

## -examples

## -see-also