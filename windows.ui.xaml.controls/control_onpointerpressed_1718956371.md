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
As it's implemented directly on [Control](control.md), [OnPointerPressed](control_onpointerpressed_1718956371.md) has an empty implementation. But each ancestor in a control's hierarchy may have provided an implementation. You won't be able to see this implementation because it's internal native code. In some cases a control will already have existing **On*** overrides that mark the event **Handled**. [OnPointerPressed](control_onpointerpressed_1718956371.md) happens to be an **On*** event that several Windows Runtime XAML controls have provided overrides for. For example, [ButtonBase](../windows.ui.xaml.controls.primitives/buttonbase.md) has overridden [OnPointerPressed](control_onpointerpressed_1718956371.md) to mark the event **Handled**. What all buttons do instead is to then raise the [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) event that represents a higher-level event behavior for that control. That means you won't easily be able to handle [UIElement.PointerPressed](../windows.ui.xaml/uielement_pointerpressed.md) on a button, but you probably shouldn't be handling it anyways for most scenarios. Just use [Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) instead.

## -examples

## -see-also
[UIElement.PointerPressed](../windows.ui.xaml/uielement_pointerpressed.md), [PointerRoutedEventArgs](../windows.ui.xaml.input/pointerroutedeventargs.md), [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832), [Custom user interactions](http://msdn.microsoft.com/library/9403c46c-60da-4c13-a381-6fbd069dd9ce), [Handle pointer input](http://msdn.microsoft.com/library/bdbc9e33-4037-4671-9596-471dcf855c82)