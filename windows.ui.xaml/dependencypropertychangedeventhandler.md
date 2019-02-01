---
-api-id: T:Windows.UI.Xaml.DependencyPropertyChangedEventHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void DependencyPropertyChangedEventHandler(System.Object sender, Windows.UI.Xaml.DependencyPropertyChangedEventArgs e)
-->
# Windows.UI.Xaml.DependencyPropertyChangedEventHandler

## -description
Represents the method that will handle events that occur when a [DependencyProperty](dependencyproperty.md) is changed on a particular [DependencyObject](dependencyobject.md) implementation.

## -parameters
### -param sender
The source of the event (typically the object where the property changed).

### -param e
The event data.


## -remarks
[DependencyPropertyChangedEventHandler](dependencypropertychangedeventhandler.md) is the delegate to use when writing handlers for the [Control.IsEnabledChanged](../windows.ui.xaml.controls/control_isenabledchanged.md) event. That event is the only defined Windows Runtime event that uses this delegate.

A custom control implementer might consider using [DependencyPropertyChangedEventHandler](dependencypropertychangedeventhandler.md) as the delegate type if a custom event is fired as a result of a dependency property value change. You can only fire such an event from within the context of a [PropertyChangedCallback](propertychangedcallback.md). This is because the value that changed (the property, the old and new value) should be in the [DependencyPropertyChangedEventArgs](dependencypropertychangedeventargs.md) that are reported for the event at the property-system level. But there aren't any constructors for [DependencyPropertyChangedEventArgs](dependencypropertychangedeventargs.md) and none of its properties are settable, so the only way to get a [DependencyPropertyChangedEventArgs](dependencypropertychangedeventargs.md) value is to get it from the original [PropertyChangedCallback](propertychangedcallback.md) parameters and pass it through when you fire your custom event.

[DependencyPropertyChangedEventHandler](dependencypropertychangedeventhandler.md) is not the delegate that you use for custom dependency property metadata and a custom property-changed callback behavior. For that, you want [PropertyChangedCallback](propertychangedcallback.md). For more info, see [Custom dependency properties](https://msdn.microsoft.com/library/5adf7935-f2cf-4bb6-b1a5-f535c2ed8ef8).

## -examples

## -see-also
[PropertyChangedCallback](propertychangedcallback.md), [DependencyPropertyChangedEventArgs](dependencypropertychangedeventargs.md), [Control.IsEnabledChanged](../windows.ui.xaml.controls/control_isenabledchanged.md), [Custom dependency properties](https://msdn.microsoft.com/library/5adf7935-f2cf-4bb6-b1a5-f535c2ed8ef8)
