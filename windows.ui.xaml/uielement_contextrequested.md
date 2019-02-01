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

## -xaml-syntax

```xaml
<uiElement ContextRequested="eventhandler"/>
```

## -remarks

If the [ContextFlyout](uielement_contextflyout.md) property is **null**, this event is marked as handled.

[ContextRequested](uielement_contextrequested.md) is a routed event. For more info on the routed event concept, see [Events and routed events overview](https://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832).

## -examples

## -see-also

[ContextRequestedEventArgs](../windows.ui.xaml.input/contextrequestedeventargs.md)