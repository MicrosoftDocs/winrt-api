---
-api-id: T:Windows.UI.Xaml.Media.Animation.EntranceThemeTransition
-api-type: winrt class
---

<!-- Class syntax.
public class EntranceThemeTransition : Windows.UI.Xaml.Media.Animation.Transition, Windows.UI.Xaml.Media.Animation.IEntranceThemeTransition
-->

# Windows.UI.Xaml.Media.Animation.EntranceThemeTransition

## -description
Provides the animated transition behavior on controls when they first appear. You can use this on individual objects or on containers of objects. In the latter case, child elements will animate into view in sequence rather than all at the same time.

## -xaml-syntax
```xaml
<EntranceThemeTransition .../>
```


## -remarks

## -examples
The following example shows a how to apply an [EntranceThemeTransition](entrancethemetransition.md) to a [Button](../windows.ui.xaml.controls/button.md).


<!--  
      <p xml:space="preserve">
            <TRANSLATE_MANUALLY>
              <externalLink xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5">
                <linkText>Run this sample</linkText>
                <linkUri>http://go.microsoft.com/fwlink/p/?linkid=139798&amp;sref=BackEase_scale</linkUri>
              </externalLink>
            </TRANSLATE_MANUALLY>
          </p>-->



[!code-xml[EntranceThemeTransitionSimple](../windows.ui.xaml.media.animation/code/EntranceThemeTransition/csharp/BlankPage.xaml#SnippetEntranceThemeTransitionSimple)]


<!--  
      <p xml:space="preserve">
            <TRANSLATE_MANUALLY>
              <externalLink xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5">
                <linkText>Run this sample</linkText>
                <linkUri>http://go.microsoft.com/fwlink/p/?linkid=139798&amp;sref=BackEase_scale</linkUri>
              </externalLink>
            </TRANSLATE_MANUALLY>
          </p>-->



[!code-xml[EntranceThemeTransitionStyle](../windows.ui.xaml/code/EntranceThemeTransitionStyle/csharp/BlankPage.xaml#SnippetEntranceThemeTransitionStyle)]


<!--  
      <p xml:space="preserve">
            <TRANSLATE_MANUALLY>
              <externalLink xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5">
                <linkText>Run this sample</linkText>
                <linkUri>http://go.microsoft.com/fwlink/p/?linkid=139798&amp;sref=BackEase_scale</linkUri>
              </externalLink>
            </TRANSLATE_MANUALLY>
          </p>-->



[!code-xml[EntranceThemeTransitionGrid](../windows.ui.xaml.media.animation/code/EntranceThemeTransition/csharp/BlankPage.xaml#SnippetEntranceThemeTransitionGrid)]



## -see-also
[Transition](transition.md), [Animating page transitions](http://msdn.microsoft.com/library/57659b10-39c2-4ff4-95ff-51a349d01911), [Guidelines and checklist for page transition animations](http://msdn.microsoft.com/library/a5784163-05a0-414f-872c-f14793d00a91)