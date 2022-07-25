---
-api-id: T:Windows.UI.Xaml.RoutedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class RoutedEventArgs : Windows.UI.Xaml.IRoutedEventArgs
-->

# Windows.UI.Xaml.RoutedEventArgs

## -description
Contains state information and event data associated with a routed event.



## -remarks
RoutedEventArgs is a common event data type used for base element events in UWP app using C++, C#, or Visual Basic. Generally RoutedEventArgs as the event data type indicates that the event with this event data is a *routed event*, although there are some exceptions. For more info on routed events and how to handle them, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

The API that RoutedEventArgs adds to a generalized event data set is [OriginalSource](routedeventargs_originalsource.md). [OriginalSource](routedeventargs_originalsource.md) can be useful for determining the element that first raised the event for hit testing and event routing scenarios, but there are also times where the *sender* from the delegate signature is the more useful source object reference for a handler. For more info, see [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview).

### RoutedEventArgs and the Handled property

If you're familiar with Windows Presentation Foundation (WPF), you might know that Windows Presentation Foundation (WPF) declares a property named **Handled** on the RoutedEventArgs class. Certain routed event data classes in the Windows Runtime also define a **Handled** property, and you use it the same way you did in Windows Presentation Foundation (WPF) (it influences the event route from within your handler.) However, for Windows Runtime and also for Microsoft Silverlight this behavior is specific only to certain routed events rather than all routed events (as is true in Windows Presentation Foundation (WPF)). For example, you can set [Handled](../windows.ui.xaml.input/pointerroutedeventargs_handled.md) if you are handling a pointer event and the event data class is [PointerRoutedEventArgs](../windows.ui.xaml.input/pointerroutedeventargs.md), but you can't set **Handled** for a [Loaded](frameworkelement_loaded.md) event where the event data is a RoutedEventArgs instance.

### **RoutedEventArgs** derived classes

RoutedEventArgs is the parent class for several immediately derived classes that define event data for Windows Runtime events involving UI elements. Not all of the events where the classes provide data are necessarily routed events as defined in [Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview). But many are. The ones that aren't sometimes have the event data derived from RoutedEventArgs for compatibility reasons.

+ [DragEventArgs](drageventargs.md)
+ [ExceptionRoutedEventArgs](exceptionroutedeventargs.md)
+ [SizeChangedEventArgs](sizechangedeventargs.md)
+ [CleanUpVirtualizedItemEventArgs](../windows.ui.xaml.controls/cleanupvirtualizeditemeventargs.md)
+ [ContextMenuEventArgs](../windows.ui.xaml.controls/contextmenueventargs.md)
+ [ItemClickEventArgs](../windows.ui.xaml.controls/itemclickeventargs.md)
+ [SelectionChangedEventArgs](../windows.ui.xaml.controls/selectionchangedeventargs.md)
+ [TextChangedEventArgs](../windows.ui.xaml.controls/textchangedeventargs.md)
+ [DragCompletedEventArgs](../windows.ui.xaml.controls.primitives/dragcompletedeventargs.md)
+ [DragDeltaEventArgs](../windows.ui.xaml.controls.primitives/dragdeltaeventargs.md)
+ [DragStartedEventArgs](../windows.ui.xaml.controls.primitives/dragstartedeventargs.md)
+ [RangeBaseValueChangedEventArgs](../windows.ui.xaml.controls.primitives/rangebasevaluechangedeventargs.md)
+ [ScrollEventArgs](../windows.ui.xaml.controls.primitives/scrolleventargs.md)
+ [HyperlinkClickEventArgs](../windows.ui.xaml.documents/hyperlinkclickeventargs.md)
+ [DoubleTappedRoutedEventArgs](../windows.ui.xaml.input/doubletappedroutedeventargs.md)
+ [HoldingRoutedEventArgs](../windows.ui.xaml.input/holdingroutedeventargs.md)
+ [KeyRoutedEventArgs](../windows.ui.xaml.input/keyroutedeventargs.md)
+ [ManipulationCompletedRoutedEventArgs](../windows.ui.xaml.input/manipulationcompletedroutedeventargs.md)
+ [ManipulationDeltaRoutedEventArgs](../windows.ui.xaml.input/manipulationdeltaroutedeventargs.md)
+ [ManipulationInertiaStartingRoutedEventArgs](../windows.ui.xaml.input/manipulationinertiastartingroutedeventargs.md)
+ [ManipulationStartedRoutedEventArgs](../windows.ui.xaml.input/manipulationstartedroutedeventargs.md)
+ [ManipulationStartingRoutedEventArgs](../windows.ui.xaml.input/manipulationstartingroutedeventargs.md)
+ [PointerRoutedEventArgs](../windows.ui.xaml.input/pointerroutedeventargs.md)
+ [RightTappedRoutedEventArgs](../windows.ui.xaml.input/righttappedroutedeventargs.md)
+ [TappedRoutedEventArgs](../windows.ui.xaml.input/tappedroutedeventargs.md)
+ [RateChangedRoutedEventArgs](../windows.ui.xaml.media/ratechangedroutedeventargs.md)
+ [TimelineMarkerRoutedEventArgs](../windows.ui.xaml.media/timelinemarkerroutedeventargs.md)


## -examples

## -see-also
[Events and routed events overview](/windows/uwp/xaml-platform/events-and-routed-events-overview), [ExceptionRoutedEventArgs](exceptionroutedeventargs.md), [RoutedEventHandler](routedeventhandler.md)
