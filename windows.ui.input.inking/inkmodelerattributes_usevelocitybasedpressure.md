---
-api-id: P:Windows.UI.Input.Inking.InkModelerAttributes.UseVelocityBasedPressure
-api-type: winrt property
---

<!-- Property syntax.
public bool UseVelocityBasedPressure { get;  set; }
-->

# Windows.UI.Input.Inking.InkModelerAttributes.UseVelocityBasedPressure

## -description

Gets or sets whether pen velocity is used in combination with pressure on the inking surface to calculate final pressure value.

## -property-value

True, if pen velocity is used. Otherwise, false.

## -remarks

This setting is valid for pencil and ballpoint pen brushes.

For the ballpoint pen brush, a faster velocity results in a thinner stroke, while a lower velocity results in a thicker stroke.

For the pencil brush, a faster velocity results in a thinner and lighter stroke, while a lower velocity results in a thicker and darker stroke.

When using the [InkToolbar](../windows.ui.xaml.controls/inktoolbar.md), [InkModelerAttributes](inkmodelerattributes.md) should be set in the [InkToolbar.ActiveToolChanged](../windows.ui.xaml.controls/inktoolbar_activetoolchanged.md) event as attributes are overwritten whenever the active tool is changed.

## -see-also

## -examples
