---
-api-id: M:Windows.UI.Xaml.Controls.Control.OnPointerPressed(Windows.UI.Xaml.Input.PointerRoutedEventArgs)
-api-type: winrt method
---

<!-- Method syntax
virtual protected void OnPointerPressed(Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
-->

# Windows.UI.Xaml.Controls.Control.OnPointerPressed

## -description
Called before the [PointerPressed](../windows.ui.xaml/uielement_pointerpressed.md) event occurs.



## -parameters
### -param e
Event data for the event.

## -remarks
As it's implemented directly on [Control](control.md), OnPointerPressed has an empty implementation. But each ancestor in a control's hierarchy may have provided an implementation. You won't be able to see this implementation because it's internal native code. In some cases a control will already have existing **On**_Event_ overrides that mark the event **Handled**. OnPointerPressed happens to be an **On**_Event_ event that several Windows Runtime XAML controls have provided overrides for. For example, [ButtonBase](../windows.ui.xaml.controls.primitives/buttonbase.md) has overridden OnPointerPressed to mark the event **Handled**. What all buttons do instead is to then raise the [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) event that represents a higher-level event behavior for that control. That means you won't easily be able to handle [UIElement.PointerPressed](../windows.ui.xaml/uielement_pointerpressed.md) on a button, but you probably shouldn't be handling it anyways for most scenarios. Just use [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) instead.

## -examples

## -see-also
[UIElement.PointerPressed](../windows.ui.xaml/uielement_pointerpressed.md), [PointerRoutedEventArgs](../windows.ui.xaml.input/pointerroutedeventargs.md), [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview), [Custom user interactions](/windows/uwp/design/layout/index), [Handle pointer input](/windows/uwp/input-and-devices/handle-pointer-input)
