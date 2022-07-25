---
-api-id: E:Windows.UI.Xaml.UIElement.KeyUp
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.Input.KeyEventHandler KeyUp
-->

# Windows.UI.Xaml.UIElement.KeyUp

## -description

Occurs when a keyboard key is released while the [UIElement](uielement.md) has focus.



## -xaml-syntax

```xaml
<uiElement KeyUp="eventhandler"/>
```

## -remarks

Controls in your UI generate keyboard events only when they have input focus. By default, the first focusable element in the visual tree is given focus by the system. An individual control gains focus when the user clicks or taps directly on that control in the layout, or uses the Tab key to step into a tab sequence within the content area. You can also focus controls programmatically by calling [Control.Focus](../windows.ui.xaml.controls/control_focus_195503898.md).

KeyUp is a routed event. For more info on the routed event concept, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

KeyUp uses [KeyRoutedEventArgs](../windows.ui.xaml.input/keyroutedeventargs.md) event data. The most relevant properties of [KeyRoutedEventArgs](../windows.ui.xaml.input/keyroutedeventargs.md) for most handler scenarios are [Key](../windows.ui.xaml.input/keyroutedeventargs_key.md) and possibly [KeyStatus](../windows.ui.xaml.input/keyroutedeventargs_keystatus.md). For more info on handling keyboard events, including example code for defining a [KeyEventHandler](../windows.ui.xaml.input/keyeventhandler.md) method, see [Keyboard interactions](/windows/uwp/input-and-devices/keyboard-interactions).

One scenario for handling keyboard events is to support access keys or accelerator keys for an app, or a region or control within an app. For more info about this scenario, see [Keyboard accessibility](/windows/uwp/accessibility/keyboard-accessibility).

Specific Windows Runtime controls may have class-based handling for the KeyUp input event. If so, the control probably has an override for the method [OnKeyUp](../windows.ui.xaml.controls/control_onkeyup_802918872.md). Typically these class handlers are intended to process a subset of key presses that enable a keyboard-based user interaction with that control, and often this interaction supports a keyboard accessibility feature. If a keyboard key event is handled by class-based handling, then the key event is considered to be already handled, and the KeyUp event is not raised for handling by any user code handlers on that control. Usually this is just for a few dedicated keys. For example, [ButtonBase](../windows.ui.xaml.controls.primitives/buttonbase.md) has class handling so that the Space key and Enter key are handled as keyboard equivalents for invoking the [Button](../windows.ui.xaml.controls/button.md). That provides a built-in keyboard equivalent for tapping the button or clicking on it with a mouse, and enables the accessibility scenario of using the UI and the button using a keyboard only. But any other keys other than Space or Enter will still fire a [KeyDown](uielement_keydown.md) and KeyUp event for a [Button](../windows.ui.xaml.controls/button.md). For more info on how class-based handling for events works, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

KeyUp supports the ability to attach event handlers to the route that will be invoked even if the event data for the event is marked [Handled](../windows.ui.xaml.input/keyroutedeventargs_handled.md). See [AddHandler](uielement_addhandler_2121467075.md).

## -examples

## -see-also

[KeyRoutedEventArgs](../windows.ui.xaml.input/keyroutedeventargs.md), [KeyDown](uielement_keydown.md), [GotFocus](uielement_gotfocus.md), [OnKeyUp](../windows.ui.xaml.controls/control_onkeyup_802918872.md), [Keyboard interactions](/windows/uwp/input-and-devices/keyboard-interactions), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview), [XAML user input events sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample)
