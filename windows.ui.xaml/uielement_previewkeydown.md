---
-api-id: E:Windows.UI.Xaml.UIElement.PreviewKeyDown
-api-type: winrt event
---

<!-- Event syntax.
public event KeyEventHandler PreviewKeyDown
-->

# Windows.UI.Xaml.UIElement.PreviewKeyDown

## -description

Occurs when a keyboard key is pressed while the [UIElement](uielement.md) has focus.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.UIElement.PreviewKeyDown](/windows/winui/api/microsoft.ui.xaml.uielement.previewkeydown) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<uiElement PreviewKeyDown="eventhandler"/>
```

## -remarks

PreviewKeyDown is a routed event. For more info on the routed event concept, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

This event uses the tunneling routing strategy. The corresponding bubbling event is [KeyDown](uielement_keydown.md).

## -see-also

[KeyRoutedEventArgs](../windows.ui.xaml.input/keyroutedeventargs.md), [KeyDown](uielement_keydown.md)

## -examples
