---
-api-id: E:Windows.UI.Xaml.FrameworkElement.SizeChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.SizeChangedEventHandler SizeChanged
-->

# Windows.UI.Xaml.FrameworkElement.SizeChanged

## -description
Occurs when either the [ActualHeight](frameworkelement_actualheight.md) or the [ActualWidth](frameworkelement_actualwidth.md) property changes value on a [FrameworkElement](frameworkelement.md).



## -xaml-syntax
```xaml
<frameworkElement SizeChanged="eventhandler"/>
```


## -remarks
SizeChanged fires whenever the size (either [ActualHeight](frameworkelement_actualheight.md) or [ActualWidth](frameworkelement_actualwidth.md)) has changed on the object, which is after the **Measure** and **Arrange** passes are complete.

The [SizeChangedEventArgs](sizechangedeventargs.md) event data for the SizeChanged event provides two properties: the [PreviousSize](sizechangedeventargs_previoussize.md) value, representing the size of the element before the layout change happened, and the [NewSize](sizechangedeventargs_newsize.md) value, representing the current size. To get the height and width info use the [Height](/uwp/api/windows.foundation.size.height) and [Width](/uwp/api/windows.foundation.size.width) values of the [Size](../windows.foundation/size.md) structure value for these [SizeChangedEventArgs](sizechangedeventargs.md) properties within your event handler.

One reason to handle the SizeChanged event is to see whether the ratio of an element's [ActualHeight](frameworkelement_actualheight.md) versus [ActualWidth](frameworkelement_actualwidth.md) have changed, because of a new layout. For example, this might happen if the user has resized the app window and the overall app view is now a narrow view.

SizeChanged occurs during initial layout of elements on a page, when the app first is activated, because the [ActualHeight](frameworkelement_actualheight.md) and [ActualWidth](frameworkelement_actualwidth.md) values for UI elements are undefined before layout happens. They only get values during the initial layout pass and thus the SizeChanged event occurs. Thereafter, during an app's lifetime, the SizeChanged event can fire from an element again if the [ActualHeight](frameworkelement_actualheight.md) and [ActualWidth](frameworkelement_actualwidth.md) values change for other reasons. These include:
+ Code that adjusts the [Height](frameworkelement_height.md) and [Width](frameworkelement_width.md) of that element specifically.
+ Code that changes the constraint properties (like [MinHeight](frameworkelement_minheight.md) or [MaxHeight](frameworkelement_maxheight.md) affecting the [ActualHeight](frameworkelement_actualheight.md)).
+ Databinding values refreshed or new styles applied that affect any of the layout-related properties of [FrameworkElement](frameworkelement.md).
+ Code that adjusts the dimensions of a container like a [Panel](../windows.ui.xaml.controls/panel.md) or [ListBox](../windows.ui.xaml.controls/listbox.md) that is the parent of an element. This often triggers a layout pass. Due to the new layout conditions, a contained child element might now have more or less space available, and that could result in a new [ActualHeight](frameworkelement_actualheight.md) and [ActualWidth](frameworkelement_actualwidth.md) for an element within.
+ Other changes that happen at run-time that change layout space even if they're not directly changing [FrameworkElement](frameworkelement.md) layout properties. For example, a list that's based on databinding to items might refresh or update, and that could cause size changes in items, items controls, list views, and so on. Or a list view that supports incremental loading might fetch more items and expand the list view.
+ The user changes the app [Window](window.md) size ([Window.SizeChanged](window_sizechanged.md) occurs), which in turn affects the size of the top-level [Page](../windows.ui.xaml.controls/page.md) and perhaps the adaptive layout-derived sizes of elements within that page that use "Auto" layout or **Stretch** alignment and didn't specify dimensions.
+ [ApplicationView](../windows.ui.viewmanagement/applicationview.md) changes or [DisplayInformation](../windows.graphics.display/displayinformation.md) changes that ultimately affect the window and page dimensions, and potentially all the UI elements within.


It is not strictly necessary to avoid calling other API that influence layout of the current object from within a SizeChanged handler. For example: setting [Height](frameworkelement_height.md) or [Width](frameworkelement_width.md); calling [InvalidateMeasure](uielement_invalidatemeasure_969784920.md) or [UpdateLayout](uielement_updatelayout_1243658106.md); calling [ApplyTemplate](../windows.ui.xaml.controls/control_applytemplate_1368990630.md); any operation that might resize child elements and thus invalidate the parent layout. The layout engine has internal logic that stabilizes the values before an object fires the event again, so the logic is usually robust enough to avoid looping conditions. However, it is still possible to inadvertently define sizing or rendering loops that can hang your app, which generally throws exceptions like [LayoutCycleException](/dotnet/api/windows.ui.xaml.layoutcycleexception?view=dotnet-plat-ext-3.1?&preserve-view=true) rather than actually hanging. This happens if your handler logic combined with surrounding layout is not capable of reaching an end result for the size of the relevant object.

If the position of the object within a parent container changes, but not the size, SizeChanged won't occur.

[LayoutUpdated](frameworkelement_layoutupdated.md) is a similar event, but [LayoutUpdated](frameworkelement_layoutupdated.md) is also fired for position changes. Also, [LayoutUpdated](frameworkelement_layoutupdated.md) occurrence is not scoped to a specific object's layout properties, it's reporting on the entire visual tree that an object is contained in. [LayoutUpdated](frameworkelement_layoutupdated.md) informs you that something within the overall visual tree that contains the object has changed, but the layout specifics (size, position) of the object where the handler is attached might not have changed.

Although this event uses a [RoutedEventHandler](routedeventhandler.md)-related delegate and a [RoutedEventArgs](routedeventargs.md)-derived class as event data, the event is not truly a routed event. It doesn't bubble through an object tree. It can be handled only on the element that originates the event (in other words, the sender). [OriginalSource](routedeventargs_originalsource.md) in event data for this event is always **null**, so don't try to use the [OriginalSource](routedeventargs_originalsource.md).

## -examples

## -see-also
[SizeChangedEventHandler](sizechangedeventhandler.md), [SizeChangedEventArgs](sizechangedeventargs.md), [LayoutUpdated](frameworkelement_layoutupdated.md)
