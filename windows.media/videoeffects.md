---
-api-id: T:Windows.Media.VideoEffects
-api-type: winrt class
---

<!-- Class syntax.
public class VideoEffects 
-->

# Windows.Media.VideoEffects

## -description
Provides video-related effects.

## -remarks
For information in using the effects when capturing video, see [Effects for video capture](https://msdn.microsoft.com/en-us/windows/uwp/audio-video-camera/effects-for-video-capture).

## -examples
The following JavaScript example adds the [VideoStabilization](videoeffects_videostabilization.md) effect to a &lt;video&gt; element. To add a different effect, replace the first parameter with the activatable ClassID of your media extension.

```javascript
var myVideo = document.getElementById("videoTag1");
myVideo.msAddVideoEffect(
   “Windows.Media.VideoEffects.VideoStabilization”, // ClassID
    true,   // effectRequired
    null);  // config
    myVideo.play();

```



## -see-also
[Effects for video capture](https://msdn.microsoft.com/en-us/windows/uwp/audio-video-camera/effects-for-video-capture), [Media extension sample](http://go.microsoft.com/fwlink/p/?linkid=241427)