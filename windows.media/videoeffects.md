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
For information in using the effects when capturing video, see [Effects for video capture](https://docs.microsoft.com/windows/uwp/audio-video-camera/effects-for-video-capture).

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
[Effects for video capture](https://docs.microsoft.com/windows/uwp/audio-video-camera/effects-for-video-capture), [Media extension sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Media%20extensions%20sample)
