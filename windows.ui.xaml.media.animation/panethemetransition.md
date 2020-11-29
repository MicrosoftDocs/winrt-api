---
-api-id: T:Windows.UI.Xaml.Media.Animation.PaneThemeTransition
-api-type: winrt class
---

<!-- Class syntax.
public class PaneThemeTransition : Windows.UI.Xaml.Media.Animation.Transition, Windows.UI.Xaml.Media.Animation.IPaneThemeTransition
-->

# Windows.UI.Xaml.Media.Animation.PaneThemeTransition

## -description
Provides the animated transition behavior for a panel UI transition.

Equivalent WinUI class: [Microsoft.UI.Xaml.Media.Animation.PaneThemeTransition](/windows/winui/api/microsoft.ui.xaml.media.animation.panethemetransition).

## -xaml-syntax
```xaml
<PaneThemeTransition .../>
```


## -remarks
### **PaneThemeTransition** versus **EdgeUIThemeTransition**

+ Use edge UI animations ([EdgeUIThemeTransition](edgeuithemetransition.md)) to show or hide a custom message or error bar that does not extend far into the screen.
+ Use panel animations (PaneThemeTransition) to show UI that slides a significant distance into the screen, such as a task pane or a custom soft keyboard.


## -examples

## -see-also
[Transition](transition.md), [EdgeUIThemeTransition](edgeuithemetransition.md), [Animating edge-based UI](/previous-versions/windows/apps/jj649428(v=win.10)), [Guidelines and checklist for edge-based UI animations](/windows/uwp/style/motion-edgebased)
