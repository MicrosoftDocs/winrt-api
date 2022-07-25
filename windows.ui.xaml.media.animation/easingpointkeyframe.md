---
-api-id: T:Windows.UI.Xaml.Media.Animation.EasingPointKeyFrame
-api-type: winrt class
---

<!-- Class syntax.
public class EasingPointKeyFrame : Windows.UI.Xaml.Media.Animation.PointKeyFrame, Windows.UI.Xaml.Media.Animation.IEasingPointKeyFrame
-->

# Windows.UI.Xaml.Media.Animation.EasingPointKeyFrame

## -description
Associates an easing function with a [PointAnimationUsingKeyFrames](pointanimationusingkeyframes.md) key-frame animation.



## -xaml-syntax
```xaml
<EasingPointKeyFrame .../>
```


## -remarks
Easing functions allow you to apply custom mathematical formulas to your animations. Mathematical operations are often useful to produce animations that simulate real-world physics in a 2-D coordinate system. For example, you may want an object to realistically bounce or behave as though it were on a spring. For a list of easing functions and info on how to use them, see [Key-frame animations and easing function animations](/windows/uwp/graphics/key-frame-and-easing-function-animations).

## -examples
This XAML example shows how to use key frames that have easing functions associated with them to create an animation that simulates an oval going up in the air and falling back down, where it bounces to a stop.



[!code-xaml[EasingFunctionPointKeyFrame](../windows.ui.xaml.media.animation/code/EasingFunctionKeyFrames/csharp/Page.xaml#SnippetEasingFunctionPointKeyFrame)]

[!code-csharp[EasingFunctionPointKeyFrame_code](../windows.ui.xaml.media.animation/code/EasingFunctionKeyFrames/csharp/Page.xaml.cs#SnippetEasingFunctionPointKeyFrame_code)]

[!code-vb[EasingFunctionPointKeyFrame_code](../windows.ui.xaml.media.animation/code/EasingFunctionKeyFrames/vbnet/MainPage.xaml.vb#SnippetEasingFunctionPointKeyFrame_code)]

## -see-also
[Storyboarded animations](/windows/uwp/graphics/storyboarded-animations), [Key-frame animations and easing function animations](/windows/uwp/graphics/key-frame-and-easing-function-animations), [XAML animation sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20animation%20library%20sample), [PointKeyFrame](pointkeyframe.md), EasingPointKeyFrame, [EasingDoubleKeyFrame](easingdoublekeyframe.md), [KeyTime](pointkeyframe_keytime.md), [Value](pointkeyframe_value.md)
