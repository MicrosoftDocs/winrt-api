---
-api-id: E:Windows.UI.Xaml.Window.VisibilityChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.WindowVisibilityChangedEventHandler VisibilityChanged
-->

# Windows.UI.Xaml.Window.VisibilityChanged

## -description
Occurs when the value of the [Visible](window_visible.md) property changes.



## -remarks
[VisibilityChangedEventArgs](../windows.ui.core/visibilitychangedeventargs.md) includes a Boolean **Visible** property that you should check to determine the current visibility state.

<!--TBW discussion of the factors of window visibility. Lower z order behind and otherwise occluded probably factor in. Should we mention WM_VISIBILITYCHANGED and or CoreWindow? One scenario mentioned in the  BC doc that spawns this is so that apps that do perform some background (eg a video app that continues to play the bg audio after user or system hides window) can make the right choices about shutting down some (but not all) resources.-->

## -examples

## -see-also
