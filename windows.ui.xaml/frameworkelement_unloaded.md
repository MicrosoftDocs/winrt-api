---
-api-id: E:Windows.UI.Xaml.FrameworkElement.Unloaded
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.RoutedEventHandler Unloaded
-->

# Windows.UI.Xaml.FrameworkElement.Unloaded

## -description
Occurs when this object is no longer connected to the main object tree.



## -xaml-syntax
```xaml
<frameworkElement Unloaded="eventhandler"/>
```


## -remarks
Although this event uses the [RoutedEventHandler](routedeventhandler.md) delegate and [RoutedEventArgs](routedeventargs.md) as event data, the event is not truly a routed event. It can only be handled on the element that originates the event (in other words, the sender). [OriginalSource](routedeventargs_originalsource.md) in event data for this event is always null.

## -examples

## -see-also
