---
-api-id: T:Windows.UI.Xaml.SizeChangedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class SizeChangedEventArgs : Windows.UI.Xaml.RoutedEventArgs, Windows.UI.Xaml.ISizeChangedEventArgs
-->

# Windows.UI.Xaml.SizeChangedEventArgs

## -description
Provides data related to the [FrameworkElement.SizeChanged](frameworkelement_sizechanged.md) event.



## -remarks
The [PreviousSize](sizechangedeventargs_previoussize.md) value is based on [ActualHeight](frameworkelement_actualheight.md) and [ActualWidth](frameworkelement_actualwidth.md) values on the element before the layout change that motivated the [SizeChanged](frameworkelement_sizechanged.md) event. The [NewSize](sizechangedeventargs_newsize.md) value is based on the [ActualHeight](frameworkelement_actualheight.md) and [ActualWidth](frameworkelement_actualwidth.md) values after the layout change is processed.

There's another event named **SizeChanged** that's defined by the [Window](window.md) class. Event handlers for [Window.SizeChanged](window_sizechanged.md) use the [WindowSizeChangedEventArgs](../windows.ui.core/windowsizechangedeventargs.md) class for data. [Window.SizeChanged](window_sizechanged.md) can occur in some of the same circumstances that [FrameworkElement.SizeChanged](frameworkelement_sizechanged.md) occurs; for more info, see [FrameworkElement.SizeChanged](frameworkelement_sizechanged.md).

## -examples

## -see-also
[FrameworkElement.SizeChanged](frameworkelement_sizechanged.md), [RoutedEventArgs](routedeventargs.md), [ActualHeight](frameworkelement_actualheight.md), [ActualWidth](frameworkelement_actualwidth.md)
