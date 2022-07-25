---
-api-id: P:Windows.UI.Xaml.RoutedEventArgs.OriginalSource
-api-type: winrt property
---

<!-- Property syntax
public object OriginalSource { get; }
-->

# Windows.UI.Xaml.RoutedEventArgs.OriginalSource

## -description
Gets a reference to the object that raised the event. This is often a template part of a control rather than an element that was declared in your app UI.



## -property-value
The object that raised the event.

## -remarks
When a routed event bubbles up an event route, *sender* is no longer the same object as the event-raising object. Instead, *sender* is the object where the handler that is being invoked is attached.

In some cases, *sender* is not interesting, and you are instead interested in info such as which of the possible child objects the pointer is over when a pointer event fired, or which object in a larger UI held focus when a user pressed a keyboard key. For these cases, you can use the value of the OriginalSource property. At all points on the route, OriginalSource reports the original object that fired the event, instead of the object where the handler is attached. However, for [UIElement](uielement.md) input events, that original object is often an object that is not immediately visible in the page-level UI definition XAML. Instead, that original source object might be a templated part of a control. For example, if the user hovers the pointer over the very edge of a [Button](../windows.ui.xaml.controls/button.md), for most pointer events the OriginalSource is a [Border](../windows.ui.xaml.controls/border.md) template part in the [Template](../windows.ui.xaml.controls/control_template.md), not the [Button](../windows.ui.xaml.controls/button.md) itself. Therefore, you can't always rely on OriginalSource representing an object that you specifically declared in your XAML page-level UI definitions.

> [!TIP]
> Input event bubbling is especially useful if you are creating a templated control. Any control that has a template can have a new template applied by its consumer. The consumer that's trying to recreate a working template might unintentionally eliminate some event handling declared in the default template. You can still provide control-level event handling by attaching handlers as part of the [OnApplyTemplate](frameworkelement_onapplytemplate_1955470198.md) override in the class definition. Then you can catch the input events that bubble up to the control's root on instantiation.

## -examples

## -see-also
[Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview), [Quickstart: Control templates](/previous-versions/windows/apps/hh465374(v=win.10))
