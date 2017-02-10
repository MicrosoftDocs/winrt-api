---
-api-id: P:Windows.UI.Xaml.FrameworkElement.FocusVisualMargin
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Thickness FocusVisualMargin { get;  set; }
-->

# Windows.UI.Xaml.FrameworkElement.FocusVisualMargin

## -description
Gets or sets the outer margin of the focus visual for a [FrameworkElement](frameworkelement.md).

## -property-value
Provides margin values for the focus visual. The default value is a default [Thickness](thickness.md) with all properties (dimensions) equal to 0.

## -remarks
[FocusVisualMargin](frameworkelement_focusvisualmargin.md) values greater than 0 apply space outside the [ActualWidth](frameworkelement_actualwidth.md) and [ActualHeight](frameworkelement_actualheight.md) of the object.

Negative values for margin dimensions are permitted, but should be used with caution. Negative margins can cause the content of the object to be clipped.

Non-integral values for margin values are technically permitted, but should typically be avoided.

[HighVisibility](focusvisualkind.md) focus visuals are rendered with an outer (primary) and inner (secondary) border. 
For more info:

+ [FocusVisualPrimaryBrush](frameworkelement_focusvisualprimarybrush.md)
+ [FocusVisualSecondaryBrush](frameworkelement_focusvisualsecondarybrush.md)
+ [FocusVisualPrimaryThickness](frameworkelement_focusvisualprimarythickness.md)
+ [FocusVisualSecondaryThickness](frameworkelement_focusvisualsecondarythickness.md)


## -examples

## -see-also
