---
-api-id: E:Windows.UI.Xaml.FrameworkElement.DataContextChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler DataContextChanged<Windows.UI.Xaml.FrameworkElement,  Windows.UI.Xaml.DataContextChangedEventArgs>
-->

# Windows.UI.Xaml.FrameworkElement.DataContextChanged

## -description
Occurs when the value of the [FrameworkElement.DataContext](frameworkelement_datacontext.md) property changes.



## -xaml-syntax

```xaml
<frameworkElement DataContextChanged="eventhandler"/>
```

## -remarks
The [FrameworkElement.DataContext](frameworkelement_datacontext.md) property has a built-in behavior whereby its value inherits to all [FrameworkElement](frameworkelement.md) child elements of a [FrameworkElement](frameworkelement.md) where a [DataContext](frameworkelement_datacontext.md) value is set. This behavior enables a set of related elements to use the same context to bind to different source properties, which is particularly useful for item templates, data templates, and other data binding scenarios. Because [DataContext](frameworkelement_datacontext.md) inherits, there's potential for each [FrameworkElement](frameworkelement.md) that uses the inherited value to fire another DataContextChanged event that's sourced from the inheriting element, not the parent element, once the element detects that its inherited [DataContext](frameworkelement_datacontext.md) value has changed. If you don't want this behavior, you should handle the DataContextChanged event on the parent source, where the event will fire first. As part of your handler logic, set the value of the [Handled](datacontextchangedeventargs_handled.md) property in the [DataContextChangedEventArgs](datacontextchangedeventargs.md) event data to **true**. That action will prevent the event from routing to child elements.

> [!NOTE]
> DataContextChanged has routing behavior but isn't a true routed event (it does not have a [RoutedEvent](routedevent.md) identifier). Also, it routes from parent to child whereas the true routed events route from child to parent. If you're familiar with Windows Presentation Foundation (WPF), DataContextChanged might be considered a tunneling routed event by the Windows Presentation Foundation (WPF) event routing definitions.

DataContextChanged is useful for scenarios where control logic or other code-based logic wants notification that the data context for bindings has changed, which often means that data bound values will change. This can be useful as a trigger to run code that makes context-driven changes, and then the new context can be used by existing bindings to recalculate values. It's also useful for cases where you don't want a pre-existing declared binding in data templates, but need a notification for changes. In this scenario you can handle DataContextChanged to detect changes to the data context and make direct changes to other properties in your code in response, just like a XAML-declared binding does dynamically through the data binding engine. For example, you might have a custom control that's mainly for use inside data templates, and you want the control to be able to perform binding operations without any explicit **Binding** declarations either in the app UI XAML or in the data template.

## -examples

## -see-also
[DataContext](frameworkelement_datacontext.md), [DataContextChangedEventArgs](datacontextchangedeventargs.md), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth)
