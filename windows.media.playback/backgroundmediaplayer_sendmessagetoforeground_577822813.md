---
-api-id: M:Windows.Media.Playback.BackgroundMediaPlayer.SendMessageToForeground(Windows.Foundation.Collections.ValueSet)
-api-type: winrt method
---

<!-- Method syntax
public void SendMessageToForeground(Windows.Foundation.Collections.ValueSet value)
-->

# Windows.Media.Playback.BackgroundMediaPlayer.SendMessageToForeground

## -description
Sends a message to the foreground task.

> [!NOTE]
> Starting with Windows, version 1703, **BackgroundMediaPlayer** is deprecated and may not be available in future versions of Windows. Use the [MediaPlayer](mediaplayer.md) class instead. For more information, see [Play media in the background](/windows/uwp/audio-video-camera/background-audio).

## -parameters
### -param value
Set of values representing the message.

## -remarks
Apps should only call **SendMessageToForeground** while the foreground app is running. Attempting to call this method while the foreground app is not running will throw an exception. An app is responsible for communicating the foreground app state to the background process. This can be done using app lifecycle events, state values kept in local storage, and messages between processes.

Calls to **SendMessageToForeground** should always be made within a **try** block so that the exception thrown can be caught if the system is unable to send the message.

## -examples

## -see-also
