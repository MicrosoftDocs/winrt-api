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
Easing functions allow you to apply custom mathematical formulas to your animations. Mathematical operations are often useful to produce animations that simulate real-world physics in a 2-D coordinate system. For example, you may want an object to realistically bounce or behave as though it were on a spring. For a list of easing functions and info on how to use them, see [Key-frame animations and easing function animations](https://msdn.microsoft.com/library/d8af24cd-f4c2-4562-afd7-25010955d677).

If no easing function is set, the default easing function will be linear. 

## -examples
This XAML example shows how to use key frames that have easing functions associated with them to create an animation of a rectangle that contracts upward, slows down, then expands downward (as though falling), and then bounces to a stop.



[!code-xml[EasingFunctionDoubleKeyFrame](../windows.ui.xaml.media.animation/code/EasingFunctionDoubleKeyFrame/csharp/Page.xaml#SnippetEasingFunctionDoubleKeyFrame)]

[!code-csharp[EasingFunctionDoubleKeyFrame_code](../windows.ui.xaml.media.animation/code/EasingFunctionDoubleKeyFrame/csharp/Page.xaml.cs#SnippetEasingFunctionDoubleKeyFrame_code)]

[!code-vb[EasingFunctionDoubleKeyFrame_code](../windows.ui.xaml.media.animation/code/EasingFunctionDoubleKeyFrame/vbnet/MainPage.xaml.vb#SnippetEasingFunctionDoubleKeyFrame_code)]

## -see-also
[Storyboarded animations](https://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a), [Key-frame animations and easing function animations](https://msdn.microsoft.com/library/d8af24cd-f4c2-4562-afd7-25010955d677), [XAML animation sample](https://go.microsoft.com/fwlink/p/?linkid=238571), [DoubleKeyFrame](doublekeyframe.md), [EasingColorKeyFrame](easingcolorkeyframe.md), [EasingPointKeyFrame](easingpointkeyframe.md), [KeyTime](doublekeyframe_keytime.md), [Value](doublekeyframe_value.md)
eyTime](doublekeyframe_keytime.md), [Value](doublekeyframe_value.md)
