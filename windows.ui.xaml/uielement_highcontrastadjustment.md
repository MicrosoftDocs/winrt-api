---
-api-id: P:Windows.UI.Xaml.UIElement.HighContrastAdjustment
-api-type: winrt property
---

<!-- Property syntax.
public ElementHighContrastAdjustment HighContrastAdjustment { get;  set; }
-->

# Windows.UI.Xaml.UIElement.HighContrastAdjustment

## -description
Gets or sets a value that indicates whether the framework automatically adjusts the element's visual properties when high contrast themes are enabled.



## -property-value
A value of the enumeration that indicates whether the framework automatically adjusts the element's visual properties when high contrast themes are enabled. The default is **Application**.

## -remarks
The value of the property is inherited.  When set to **Application** the adjustment will mirror what is set for the [Application](application.md)'s [HighContrastAdjustment](application_highcontrastadjustment.md) property.  Setting the [Application](application.md)'s [HighContrastAdjustment](application_highcontrastadjustment.md) property to **None** will effectively disable it for all UI in the application.  It can be selectively enabled for a UIElement by explicitly setting the value to **Auto**.   
When set to **Auto**, the framework automatically applies the following adjustments to XAML's text elements while a high contrast theme is enabled:
* The foreground color on text is ignored.  The text is colored using either the system’s high contrast text color or the disabled color when in a parent [Control](../windows.ui.xaml.controls/control.md) where [IsEnabled](../windows.ui.xaml.controls/control_isenabled.md) = "False".
* An opaque rectangle is rendered immediately behind the text to enforce a high contrast ratio.
* Non-zero values for [Opacity](uielement_opacity.md) are ignored.  The element and its children will appear as if they had an opacity of 1.0.

The following images show the difference between **Auto** (the default **Application** value) and **None**:

:::image type="content" source="images/HighContrastAdjustment_auto.png" alt-text="Example of buttons with HighContrastAdjustment set to auto.":::
:::image type="content" source="images/HighContrastAdjustment_none.png" alt-text="Example of buttons with HighContrastAdjustment set to none.":::

It is possible to set HighContrastAdjustment = None on a UIElement and then have HighContrastAdjustment = Auto on one of its descendants.  However, the framework does not guarantee that the descendent will be fully opaque if an opacity is applied on any of its ancestors.

## -see-also

## -examples

