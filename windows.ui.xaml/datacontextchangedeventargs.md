---
-api-id: T:Windows.UI.Xaml.DataContextChangedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class DataContextChangedEventArgs : Windows.UI.Xaml.IDataContextChangedEventArgs
-->

# Windows.UI.Xaml.DataContextChangedEventArgs

## -description
Provides data for the [DataContextChanged](frameworkelement_datacontextchanged.md) event.



## -remarks
The [FrameworkElement.DataContext](frameworkelement_datacontext.md) property has a built-in behavior whereby its value inherits to all [FrameworkElement](frameworkelement.md) child elements of a [FrameworkElement](frameworkelement.md) where a [DataContext](frameworkelement_datacontext.md) value is set. This behavior enables a set of related elements to use the same context to bind to different source properties, which is particularly useful for item templates, data templates, and other data binding scenarios. Because [DataContext](frameworkelement_datacontext.md) inherits, there's potential for each [FrameworkElement](frameworkelement.md) that uses the inherited value to fire another [DataContextChanged](frameworkelement_datacontextchanged.md) event. That event is sourced from the inheriting element, not the parent element, once the element detects that its inherited [DataContext](frameworkelement_datacontext.md) value has changed. If you don't want this behavior, you should handle the [DataContextChanged](frameworkelement_datacontextchanged.md) event on the parent source, where the event will occur first. As part of your handler logic, set the value of the [Handled](datacontextchangedeventargs_handled.md) property in the DataContextChangedEventArgs event data to **true**. That action will prevent the event from routing to child elements.

> [!NOTE]
> [DataContextChanged](frameworkelement_datacontextchanged.md) has routing behavior but isn't a true routed event (it does not have a [RoutedEvent](routedevent.md) identifier). Also, it routes from parent to child whereas the true routed events route from child to parent. If you're familiar with Windows Presentation Foundation (WPF), [DataContextChanged](frameworkelement_datacontextchanged.md) might be considered a tunneling routing event by the Windows Presentation Foundation (WPF) event routing definitions.

## -examples

## -see-also
[DataContextChanged](frameworkelement_datacontextchanged.md), [DataContext](frameworkelement_datacontext.md)
