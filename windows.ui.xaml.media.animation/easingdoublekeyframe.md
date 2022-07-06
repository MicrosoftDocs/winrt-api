---
-api-id: T:Windows.UI.Xaml.Media.Animation.EasingDoubleKeyFrame
-api-type: winrt class
---

<!-- Class syntax.
public class EasingDoubleKeyFrame : Windows.UI.Xaml.Media.Animation.DoubleKeyFrame, Windows.UI.Xaml.Media.Animation.IEasingDoubleKeyFrame
-->

# Windows.UI.Xaml.Media.Animation.EasingDoubleKeyFrame

## -description
Associates an easing function with a [DoubleAnimationUsingKeyFrames](doubleanimationusingkeyframes.md) key-frame animation.



## -xaml-syntax
```xaml
<EasingDoubleKeyFrame .../>
```


## -remarks
Easing functions allow you to apply custom mathematical formulas to your animations. Mathematical operations are often useful to produce animations that simulate real-world physics in a 2-D coordinate system. For example, you may want an object to realistically bounce or behave as though it were on a spring. For a list of easing functions and info on how to use them, see [Key-frame animations and easing function animations](/windows/uwp/graphics/key-frame-and-easing-function-animations).

If no easing function is set, the default easing function will be linear. 

## -examples
This XAML example shows how to use key frames that have easing functions associated with them to create an animation of a rectangle that contracts upward, slows down, then expands downward (as though falling), and then bounces to a stop.



[!code-xaml[EasingFunctionDoubleKeyFrame](../windows.ui.xaml.media.animation/code/EasingFunctionDoubleKeyFrame/csharp/Page.xaml#SnippetEasingFunctionDoubleKeyFrame)]

[!code-csharp[EasingFunctionDoubleKeyFrame_code](../windows.ui.xaml.media.animation/code/EasingFunctionDoubleKeyFrame/csharp/Page.xaml.cs#SnippetEasingFunctionDoubleKeyFrame_code)]

[!code-vb[EasingFunctionDoubleKeyFrame_code](../windows.ui.xaml.media.animation/code/EasingFunctionDoubleKeyFrame/vbnet/MainPage.xaml.vb#SnippetEasingFunctionDoubleKeyFrame_code)]

## -see-also
[Storyboarded animations](/windows/uwp/graphics/storyboarded-animations), [Key-frame animations and easing function animations](/windows/uwp/graphics/key-frame-and-easing-function-animations), [XAML animation sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20animation%20library%20sample), [DoubleKeyFrame](doublekeyframe.md), [EasingColorKeyFrame](easingcolorkeyframe.md), [EasingPointKeyFrame](easingpointkeyframe.md), [KeyTime](doublekeyframe_keytime.md), [Value](doublekeyframe_value.md)
