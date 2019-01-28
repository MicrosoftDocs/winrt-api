---
-api-id: E:Windows.UI.Xaml.UIElement.PreviewKeyUp
-api-type: winrt event
---

<!-- Event syntax.
public event KeyEventHandler PreviewKeyUp
-->

# Windows.UI.Xaml.UIElement.PreviewKeyUp

## -description

Occurs when a keyboard key is released while the [UIElement](uielement.md) has focus.

## -xaml-syntax

```xaml
<uiElement PreviewKeyUp="eventhandler"/>
```

## -remarks

[PreviewKeyDown](uielement_previewkeydown.md) is a routed event. For more info on the routed event concept, see [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832).

This event uses the tunneling routing strategy. The corresponding bubbling event is [KeyUp](uielement_keyup.md).

## -see-also

[KeyRoutedEventArgs](../windows.ui.xaml.input/keyroutedeventargs.md), [KeyUp](uielement_keyup.md)

## -examples
