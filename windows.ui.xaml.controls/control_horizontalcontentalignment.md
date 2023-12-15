---
-api-id: P:Windows.UI.Xaml.Controls.Control.HorizontalContentAlignment
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.HorizontalAlignment HorizontalContentAlignment { get;  set; }
-->

# Windows.UI.Xaml.Controls.Control.HorizontalContentAlignment

## -description

Gets or sets the horizontal alignment of the control's content.

## -xaml-syntax

```xaml
<control HorizontalContentAlignment="horizontalAlignmentMemberName"/>
```

## -xaml-values

<dl><dt>horizontalAlignmentMemberName</dt><dd>horizontalAlignmentMemberNameA named constant of the HorizontalAlignment enumeration, such as Stretch.</dd>
</dl>

## -property-value
One of the [HorizontalAlignment](../windows.ui.xaml/horizontalalignment.md) values. The default is `Center`.

## -remarks

Each control might apply this property differently based on the [Style](../windows.ui.xaml/style.md) setters for the control's implicit style, and its visual template. Also, the apparent "default value" of each individual control used in UI can be different.

A value for the HorizontalContentAlignment property only affects layout behavior for a control when its template uses the HorizontalContentAlignment property as the source of a [HorizontalAlignment](../windows.ui.xaml/frameworkelement_horizontalalignment.md) value for presenters or content areas within. On other controls, setting HorizontalContentAlignment has no effect. For more info about visual templates for controls, see the reference for [Control.Template](control_template.md) and [Control templates](/windows/apps/design/style/xaml-control-templates)

## -examples

## -see-also

[VerticalContentAlignment](control_verticalcontentalignment.md), [FrameworkElement.HorizontalAlignment](../windows.ui.xaml/frameworkelement_horizontalalignment.md), [Alignment, margin, and padding](/windows/uwp/layout/alignment-margin-padding), [Control templates](/windows/apps/design/style/xaml-control-templates)
