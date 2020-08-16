---
-api-id: M:Windows.UI.Xaml.Controls.Control.OnKeyDown(Windows.UI.Xaml.Input.KeyRoutedEventArgs)
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnKeyDown(Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
-->

# Windows.UI.Xaml.Controls.Control.OnKeyDown

## -description
Called before the [KeyDown](../windows.ui.xaml/uielement_keydown.md) event occurs.

## -parameters
### -param e
The data for the event.

## -remarks
As it's implemented directly on [Control](control.md), OnKeyDown has an empty implementation. But each ancestor in a control's hierarchy may have provided an implementation. You won't be able to see this implementation because it's internal native code. In some cases a control will already have existing **On**_Event_ overrides that mark the event **Handled**. For key events, controls are usually only handling for certain keys, by checking values in [KeyRoutedEventArgs](../windows.ui.xaml.input/keyroutedeventargs.md). For example, [ButtonBase](../windows.ui.xaml.controls.primitives/buttonbase.md) detects the Space key as a way to fire [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md). Control code or your code probably shouldn't be suppressing all key events, because it's a common pattern to let key events bubble to the root visual so that they can be shortcuts or accelerators for app interaction. For more info see [Keyboard interactions](https://docs.microsoft.com/windows/uwp/input-and-devices/keyboard-interactions).

## -examples

## -see-also
[UIElement.KeyDown](../windows.ui.xaml/uielement_keydown.md), [KeyRoutedEventArgs](../windows.ui.xaml.input/keyroutedeventargs.md), [Keyboard interactions](https://docs.microsoft.com/windows/uwp/input-and-devices/keyboard-interactions), [Events and routed events overview](https://docs.microsoft.com/windows/uwp/xaml-platform/events-and-routed-events-overview)
