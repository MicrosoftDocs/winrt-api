---
-api-id: P:Windows.UI.Xaml.FrameworkElement.ActualWidth
-api-type: winrt property
---

<!-- Property syntax
public double ActualWidth { get; }
-->

# Windows.UI.Xaml.FrameworkElement.ActualWidth

## -description
Gets the rendered width of a [FrameworkElement](frameworkelement.md). See Remarks.



## -property-value
The width, in pixels, of the object. The default is 0. The default might be encountered if the object has not been loaded and hasn't yet been involved in a layout pass that renders the UI.

## -remarks
> [!NOTE]
> Although it has an [ActualWidthProperty](frameworkelement_actualwidthproperty.md) backing field, ActualWidth does not raise property change notifications and it should be thought of as a regular CLR property and not a dependency property.

ActualWidth is a calculated property. The calculations are a result of a layout pass, where the object is sized in layout according to the logic of its successive layout parents. For more info see [Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml).


<!--BUG this is a terrible formoreinfo. Need meaty stuff about how layout actually works.-->
ActualWidth can have multiple or incremental reported changes to the value because of operations by the layout system. If you get the value while layout is still iterating, the layout system might still be calculating the required measure of space for child objects, constraints by the parent object, and so on. Because the value is based on an actual rendering pass, it may lag slightly behind the set value of properties like [Width](frameworkelement_width.md), which can be the basis of the input change.

For purposes of [ElementName](../windows.ui.xaml.data/binding_elementname.md) binding, ActualWidth does not post updates when it changes (due to its asynchronous and run-time calculated nature). Do not attempt to use ActualWidth as a binding source for an [ElementName](../windows.ui.xaml.data/binding_elementname.md) binding. If you have a scenario that requires updates based on ActualWidth, use a [SizeChanged](frameworkelement_sizechanged.md) handler.

## -examples

## -see-also
[ActualHeight](frameworkelement_actualheight.md), [Width](frameworkelement_width.md), [SizeChanged](frameworkelement_sizechanged.md)
