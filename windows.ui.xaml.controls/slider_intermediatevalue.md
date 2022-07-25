---
-api-id: P:Windows.UI.Xaml.Controls.Slider.IntermediateValue
-api-type: winrt property
---

<!-- Property syntax
public double IntermediateValue { get;  set; }
-->

# Windows.UI.Xaml.Controls.Slider.IntermediateValue

## -description
Gets or sets the value of the [Slider](slider.md) while the user is interacting with it, before the value is snapped to either the tick or step value. The value the [Slider](slider.md) snaps to is specified by the [SnapsTo](slider_snapsto.md) property.



## -property-value
A temporary value.

## -remarks

Use this property to get the value of the [Slider](slider.md) while the user is interacting with it, before the value is snapped to either the tick or step value (as specified by the [SnapsTo](slider_snapsto.md) property).

This property isn't typically set in XAML. It could be useful though as an element binding source for another XAML UI element that displays the IntermediateValue value.

## -examples

## -see-also
[SnapsTo](slider_snapsto.md), [StepFrequency](slider_stepfrequency.md), [TickFrequency](slider_tickfrequency.md)
