---
-api-id: P:Windows.Media.Miracast.MiracastReceiverStreamControl.MuteAudio
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public bool MuteAudio { get;  set; }
-->

# Windows.Media.Miracast.MiracastReceiverStreamControl.MuteAudio

## -description

Specifies whether the Miracast Transmitter should mute the audio stream. The default value is false.

## -property-value

True if the Miracast Transmitter should mute the audio stream.

## -remarks

If the Miracast Receiver app does not want to receive the audio stream, e.g., because audio playback is muted, then it can set the MuteAudio property to true.
This will request the Miracast Transmitter to stop transmitting audio data, which can save network bandwidth and extend battery life. 
Not all Miracast Transmitters suppport this request, so the app should not assume that audio data will cease to be transmitted.

## -see-also

## -examples

