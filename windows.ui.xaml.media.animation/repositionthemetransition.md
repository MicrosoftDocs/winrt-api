---
-api-id: T:Windows.UI.Xaml.Media.Animation.RepositionThemeTransition
-api-type: winrt class
---

<!-- Class syntax.
public class RepositionThemeTransition : Windows.UI.Xaml.Media.Animation.Transition, Windows.UI.Xaml.Media.Animation.IRepositionThemeTransition, Windows.UI.Xaml.Media.Animation.IRepositionThemeTransition2
-->

# Windows.UI.Xaml.Media.Animation.RepositionThemeTransition

## -description
Reacts to layout moves when no context is set and a trigger of *move* is passed.

## -xaml-syntax
```xaml
<RepositionThemeTransition ../>
```


## -remarks

## -examples
The following example applies a [RepositionThemeTransition](repositionthemetransition.md) to a button. When you click the button, its margin changes, which changes its position. This position change is animated.


<!--  
      <p xml:space="preserve">
            <TRANSLATE_MANUALLY>
              <externalLink xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5">
                <linkText>Run this sample</linkText>
                <linkUri>http://go.microsoft.com/fwlink/p/?linkid=139798&amp;sref=BackEase_scale</linkUri>
              </externalLink>
            </TRANSLATE_MANUALLY>
          </p>-->



[!code-xml[RepositionThemeTransitionSimple](../windows.ui.xaml.media.animation/code/RepositionThemeTransition/csharp/BlankPage.xaml#SnippetRepositionThemeTransitionSimple)]

[!code-csharp[RepositionThemeTransitionSimple_code](../windows.ui.xaml.media.animation/code/RepositionThemeTransition/csharp/BlankPage.xaml.cs#SnippetRepositionThemeTransitionSimple_code)]


<!--  
      <p xml:space="preserve">
            <TRANSLATE_MANUALLY>
              <externalLink xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5">
                <linkText>Run this sample</linkText>
                <linkUri>http://go.microsoft.com/fwlink/p/?linkid=139798&amp;sref=BackEase_scale</linkUri>
              </externalLink>
            </TRANSLATE_MANUALLY>
          </p>-->



[!code-xml[RepositionThemeTransition](../windows.ui.xaml.media.animation/code/RepositionThemeTransition/csharp/BlankPage.xaml#SnippetRepositionThemeTransition)]

[!code-csharp[RepositionThemeTransition_code](../windows.ui.xaml.media.animation/code/RepositionThemeTransition/csharp/BlankPage.xaml.cs#SnippetRepositionThemeTransition_code)]

## -see-also
[Transition](transition.md), [Animating repositions](http://msdn.microsoft.com/library/4d715c69-79e6-4179-a66c-a193629966d1), [Guidelines and checklist for reposition animations](http://msdn.microsoft.com/library/25d1ee31-5c25-4f21-b34c-fbd8fb1c8fff)
 reposition animations](http://msdn.microsoft.com/library/25d1ee31-5c25-4f21-b34c-fbd8fb1c8fff)