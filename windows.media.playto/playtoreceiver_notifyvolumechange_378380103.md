---
-api-id: M:Windows.Media.PlayTo.PlayToReceiver.NotifyVolumeChange(System.Double,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public void NotifyVolumeChange(System.Double volume, System.Boolean mute)
-->

# Windows.Media.PlayTo.PlayToReceiver.NotifyVolumeChange

## -description
Notifies the Play To receiver that the volume of the audio or video playback has changed.

## -parameters
### -param volume
The new value for the volume.

### -param mute
True if the volume was muted; otherwise false.

## -remarks
For an example of creating a software Play To receiver, see [Media casting](http://msdn.microsoft.com/library/40b97e0c-eb1b-40c2-a022-1ab95dfb085e) or [Media casting](http://msdn.microsoft.com/library/40b97e0c-eb1b-40c2-a022-1ab95dfb085e).



[!code-csharp[NotifyVolumeChanged](../windows.media.playto/code/PlayTo_Receiver1/csharp/MainPage.xaml.cs#SnippetNotifyVolumeChanged)]

[!code-js[NotifyVolumeChanged](../windows.media.playto/code/PlayTo_Receiver1/javascript/default.js#SnippetNotifyVolumeChanged)]

[!code-vb[NotifyVolumeChanged](../windows.media.playto/code/PlayTo_Receiver1/vbnet/MainPage.xaml.vb#SnippetNotifyVolumeChanged)]

## -examples

## -see-also
[Play To sample](http://go.microsoft.com/fwlink/p/?linkid=245166), [PlayToReceiver sample](http://go.microsoft.com/fwlink/p/?linkid=245167), [Media Server sample](http://go.microsoft.com/fwlink/p/?linkid=245168)

## -capabilities
privateNetworkClientServer
ities
privateNetworkClientServer
