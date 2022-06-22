---
-api-id: P:Windows.UI.Xaml.UIElement.DesiredSize
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Size DesiredSize { get; }
-->

# Windows.UI.Xaml.UIElement.DesiredSize

## -description
Gets the size that this [UIElement](uielement.md) computed during the measure pass of the layout process.



## -property-value
The size that this [UIElement](uielement.md) computed during the measure pass of the layout process.

## -remarks
DesiredSize is typically checked as one of the measurement factors when you implement layout behavior overrides such as [ArrangeOverride](frameworkelement_arrangeoverride_1795048387.md) or [MeasureOverride](frameworkelement_measureoverride_1586581644.md). Depending on the parent container's layout logic, DesiredSize might be fully respected, constraints on DesiredSize might be applied, and such constraints might also change other characteristics of either the parent element or child element. For example, a control that supports scrollable regions (but chooses not to derive from the controls that already enable scrollable regions) could compare available size to DesiredSize. The control could then set an internal state that enabled scrollbars in the UI for that control. Or, DesiredSize could be ignored and the element always gets a layout that is sized by other considerations such as checking attached property values.

DesiredSize won't contain a useful value unless at least one "Measure" pass of layout has run on the element.

DesiredSize is really only intended for use when you define your own layout override methods. If you're just interested in the size of an element in your app's UI at run time, then you should use the [ActualWidth](frameworkelement_actualwidth.md) and [ActualHeight](frameworkelement_actualheight.md) properties instead. You might be checking size this way if an element is influenced by dynamic layout techniques such as star sizing of [Grid](../windows.ui.xaml.controls/grid.md) cells. Rely on [ActualWidth](frameworkelement_actualwidth.md) and [ActualHeight](frameworkelement_actualheight.md) values only in situations that are sure to be after layout has run: for example, in [Loaded](frameworkelement_loaded.md) events, or triggered by user actions that are only possible after the UI has been rendered initially.

## -examples
This example queries DesiredSize as part of the child iteration for an [ArrangeOverride](frameworkelement_arrangeoverride_1795048387.md) implementation.



[!code-csharp[2](../windows.ui.xaml.controls.primitives/code/BlockPanel/csharp/BlankPage.xaml.cs#Snippet2)]

[!code-vb[2](../windows.ui.xaml.controls.primitives/code/BlockPanel/vbnet/BlankPage.xaml.vb#Snippet2)]

## -see-also
[ArrangeOverride](frameworkelement_arrangeoverride_1795048387.md), [MeasureOverride](frameworkelement_measureoverride_1586581644.md), [Arrange](uielement_arrange_958316931.md), [Measure](uielement_measure_1722732750.md)
, [Measure](uielement_measure_1722732750.md)
