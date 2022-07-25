---
-api-id: T:Windows.UI.Xaml.Media.Animation.EdgeUIThemeTransition
-api-type: winrt class
---

<!-- Class syntax.
public class EdgeUIThemeTransition : Windows.UI.Xaml.Media.Animation.Transition, Windows.UI.Xaml.Media.Animation.IEdgeUIThemeTransition
-->

# Windows.UI.Xaml.Media.Animation.EdgeUIThemeTransition

## -description
Provides the animated transition behavior for an edge UI transition. 
<!--such as app bar appear disappear?-->



## -xaml-syntax
```xaml
<EdgeUIThemeTransition .../>
```


## -remarks
We recommend that you include edge UI by adding an [AppBar](../windows.ui.xaml.controls/appbar.md) via the [BottomAppBar](../windows.ui.xaml.controls/page_bottomappbar.md) and [TopAppBar](../windows.ui.xaml.controls/page_topappbar.md) properties, which will automatically apply all appropriate transitions and interaction behavior for you.

### **PaneThemeTransition** versus **EdgeUIThemeTransition**

+ Use edge UI animations (EdgeUIThemeTransition) to show or hide a custom message or error bar that does not extend far into the screen.
+ Use panel animations ([PaneThemeTransition](panethemetransition.md)) to show UI that slides a significant distance into the screen, such as a task pane or a custom soft keyboard.


## -examples

## -see-also
[Transition](transition.md), [Animating edge-based UI](/previous-versions/windows/apps/jj649428(v=win.10)), [Guidelines and checklist for edge-based UI animations](/windows/uwp/style/motion-edgebased)
