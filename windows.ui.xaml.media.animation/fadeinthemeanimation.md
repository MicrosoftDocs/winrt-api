---
-api-id: T:Windows.UI.Xaml.Media.Animation.FadeInThemeAnimation
-api-type: winrt class
---

<!-- Class syntax.
public class FadeInThemeAnimation : Windows.UI.Xaml.Media.Animation.Timeline, Windows.UI.Xaml.Media.Animation.IFadeInThemeAnimation
-->

# Windows.UI.Xaml.Media.Animation.FadeInThemeAnimation

## -description
Represents the preconfigured opacity animation that applies to controls when they are first shown.



## -xaml-syntax
```xaml
<FadeInThemeAnimation ... />
```


## -remarks

## -examples
The following example applies a FadeInThemeAnimation and [FadeOutThemeAnimation](fadeoutthemeanimation.md) to a rectangle.


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
[Timeline](timeline.md), [Animating fades](/previous-versions/windows/apps/jj649429(v=win.10)), [Guidelines and checklist for fade animations](/windows/uwp/style/motion-fade)
