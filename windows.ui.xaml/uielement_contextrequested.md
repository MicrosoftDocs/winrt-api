---
-api-id: E:Windows.UI.Xaml.UIElement.ContextRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ContextRequested<Windows.UI.Xaml.UIElement,  Windows.UI.Xaml.Input.ContextRequestedEventArgs>
-->

# Windows.UI.Xaml.UIElement.ContextRequested

## -description

Occurs when the user has completed a context input gesture, such as a right-click.

Equivalent WinUI event: [Microsoft.UI.Xaml.UIElement.ContextRequested](/windows/winui/api/microsoft.ui.xaml.uielement.contextrequested).

## -xaml-syntax

```xaml
<uiElement ContextRequested="eventhandler"/>
```

## -remarks

If the [ContextFlyout](uielement_contextflyout.md) property is **null**, this event is marked as handled.

ContextRequested is a routed event. For more info on the routed event concept, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

## -examples

## -see-also

[ContextRequestedEventArgs](../windows.ui.xaml.input/contextrequestedeventargs.md)
