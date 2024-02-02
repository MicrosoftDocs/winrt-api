---
-api-id: P:Windows.Media.PlayTo.PlayToManager.DefaultSourceSelection
-api-type: winrt property
---

<!-- Property syntax
public bool DefaultSourceSelection { get;  set; }
-->

# Windows.Media.PlayTo.PlayToManager.DefaultSourceSelection

## -description
Enables or disables the default source selection for Play To.

## -property-value
True to enable default source selection; otherwise false. The default is true.

## -remarks

An app that contains media elements has Play To enabled by default. If a user invokes the **Devices** charm while running the app and selects a target device to stream media to, Play To will stream the media from the first audio, video, or image element on the current page. You can disable this default behavior by setting the **DefaultSourceSelection** property to **false**.
```javascript
var ptm = Windows.Media.PlayTo.PlayToManager.getForCurrentView();
ptm.defaultSourceSelection = false;

```



You can exclude individual HTML elements from the default Play To behavior by adding the **-ms-playToDisabled** attribute in your HTML markup.
```javascript
<video src="http://www.example.com/videos/video.mp4" x-ms-playToDisabled/>
```




<!--What about XAML exclusion attribute?-->

## -examples

## -see-also
[Play To sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Play%20To%20sample%20(Windows%208)), [PlayToReceiver sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Play%20To%20sample%20(Windows%208)), [Media Server sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Server%20client%20sample%20(Windows%208)/C%2B%2B)