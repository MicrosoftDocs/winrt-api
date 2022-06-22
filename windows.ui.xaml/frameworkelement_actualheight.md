---
-api-id: P:Windows.UI.Xaml.FrameworkElement.ActualHeight
-api-type: winrt property
---

<!-- Property syntax
public double ActualHeight { get; }
-->

# Windows.UI.Xaml.FrameworkElement.ActualHeight

## -description
Gets the rendered height of a [FrameworkElement](frameworkelement.md). See Remarks.



## -property-value
The height, in pixels, of the object. The default is 0. The default might be encountered if the object has not been loaded and hasn't yet been involved in a layout pass that renders the UI.

## -remarks
> [!NOTE]
> Although it has an [ActualHeightProperty](frameworkelement_actualheightproperty.md) backing field, ActualHeight does not raise property change notifications and it should be thought of as a regular property and not a dependency property.

ActualHeight is a calculated property. The calculations are a result of a layout pass, where the object is sized in layout according to the logic of its successive layout parents. For more info see [Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml).


<!--BUG this is a terrible formoreinfo. Need meaty stuff about how layout actually works.-->
ActualHeight can have multiple or incremental reported changes to the value because of operations by the layout system. If you get the value while layout is still iterating, the layout system might still be calculating the required measure of space for child objects, constraints by the parent object, and so on. Because the value is based on an actual rendering pass, it may lag slightly behind the set value of properties like [Height](frameworkelement_height.md), which can be the basis of the input change.

For purposes of [ElementName](../windows.ui.xaml.data/binding_elementname.md) binding, ActualHeight does not post updates when it changes (due to its asynchronous and run-time calculated nature). Do not attempt to use ActualHeight as a binding source for an [ElementName](../windows.ui.xaml.data/binding_elementname.md) binding. If you have a scenario that requires updates based on ActualHeight, use a [SizeChanged](frameworkelement_sizechanged.md) handler.

## -examples
This example shows a common scenario where you use the ActualHeight of one or more elements in UI to set the [Height](frameworkelement_height.md) of either one of the involved elements or a different element, so that the same net height is maintained after the action. This is usually done in response to event handlers that are invoked when elements are opened or closed, or the display area changes.



[!code-cpp[FEActualHeight](../windows.ui.xaml/code/BaseElementEvents/cpp/PageWithAppBar.xaml.cpp#SnippetFEActualHeight)]

[!code-csharp[FEActualHeight](../windows.ui.xaml/code/BaseElementEvents/csharp/PageWithAppBar.xaml.cs#SnippetFEActualHeight)]

[!code-vb[FEActualHeight](../windows.ui.xaml/code/BaseElementEvents/vbnet/PageWithAppBar.xaml.vb#SnippetFEActualHeight)]

## -see-also
[ActualWidth](frameworkelement_actualwidth.md), [Height](frameworkelement_height.md), [SizeChanged](frameworkelement_sizechanged.md)
(frameworkelement_sizechanged.md)
