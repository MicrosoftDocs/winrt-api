---
-api-id: P:Windows.UI.Xaml.Controls.Control.VerticalContentAlignment
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.VerticalAlignment VerticalContentAlignment { get;  set; }
-->

# Windows.UI.Xaml.Controls.Control.VerticalContentAlignment

## -description

Gets or sets the vertical alignment of the control's content.

## -xaml-syntax

```xaml
<control VerticalContentAlignment="verticalAlignmentValue"/>
```

## -xaml-values

<dl><dt>verticalAlignmentValue</dt><dd>verticalAlignmentValueA named constant of the VerticalAlignment enumeration, such as Stretch.</dd>
</dl>

## -property-value

One of the [VerticalAlignment](../windows.ui.xaml/verticalalignment.md) values. The default is `Center`.

## -remarks

Each control might apply this property differently based on the [Style](../windows.ui.xaml/style.md) setters for the control's implicit style, and its visual template. Also, the apparent "default value" of each individual control used in UI can be different.

A value for the VerticalContentAlignment property only affects layout behavior for a control when its template uses the VerticalContentAlignment property as the source of a [VerticalAlignment](../windows.ui.xaml/frameworkelement_verticalalignment.md) value for presenters or content areas within. On other controls, setting VerticalContentAlignment has no effect. For more info about visual templates for controls, see the reference for [Control.Template](control_template.md) and [Control templates](/windows/apps/design/style/xaml-control-templates).

## -examples

## -see-also

[HorizontalContentAlignment](control_horizontalcontentalignment.md), [FrameworkElement.VerticalAlignment](../windows.ui.xaml/frameworkelement_verticalalignment.md), [Alignment, margin, and padding](/windows/uwp/layout/alignment-margin-padding), [Control templates](/windows/apps/design/style/xaml-control-templates)
