---
-api-id: T:Windows.UI.Xaml.Media.Animation.FadeOutThemeAnimation
-api-type: winrt class
---

<!-- Class syntax.
public class FadeOutThemeAnimation : Windows.UI.Xaml.Media.Animation.Timeline, Windows.UI.Xaml.Media.Animation.IFadeOutThemeAnimation
-->

# Windows.UI.Xaml.Media.Animation.FadeOutThemeAnimation

## -description
Represents the preconfigured opacity animation that applies to controls when they are removed from the UI or hidden.

## -xaml-syntax
```xaml
<FadeOutThemeAnimation ... />
```


## -remarks

## -examples
The following example applies a [FadeInThemeAnimation](fadeinthemeanimation.md) and FadeOutThemeAnimation to a rectangle.


<!--  
      <p xml:space="preserve">
            <TRANSLATE_MANUALLY>
              <externalLink xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5">
                <linkText>Run this sample</linkText>
                <linkUri>http://go.microsoft.com/fwlink/p/?linkid=139798&amp;sref=BackEase_scale</linkUri>
              </externalLink>
            </TRANSLATE_MANUALLY>
          </p>-->



[!code-xaml[FadeThemeAnimation](../windows.ui.xaml.media.animation/code/FadeInThemeAnimation/csharp/BlankPage.xaml#SnippetFadeThemeAnimation)]

[!code-csharp[FadeThemeAnimation_code](../windows.ui.xaml.media.animation/code/FadeInThemeAnimation/csharp/BlankPage.xaml.cs#SnippetFadeThemeAnimation_code)]

## -see-also
[Timeline](timeline.md), [Animating fades](https://docs.microsoft.com/previous-versions/windows/apps/jj649429(v=win.10)), [Guidelines and checklist for fade animations](https://docs.microsoft.com/windows/uwp/style/motion-fade)
