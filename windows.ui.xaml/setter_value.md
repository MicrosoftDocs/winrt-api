---
-api-id: P:Windows.UI.Xaml.Setter.Value
-api-type: winrt property
---

<!-- Property syntax
public object Value { get;  set; }
-->

# Windows.UI.Xaml.Setter.Value

## -description
Gets or sets the value to apply to the property that is specified by the [Setter](setter.md).



## -xaml-syntax
```xaml
<Setter ...>
  <Setter.Value>
    objectValue
  </Setter.Value>
</Setter>
- or -
<Setter Value="attributeValue"/>
-or-
<Setter Value="extensionUsage"/>
```


## -xaml-values
<dl><dt>objectValue</dt><dd>objectValueAn object element that specifies the value of the property being set.</dd>
<dt>attributeValue</dt><dd>attributeValueA string that specifies the attribute value of the property being set. The format and interpretation of the string provided for the attribute value depends on the property being set.</dd>
<dt>extensionUsage</dt><dd>extensionUsageOne of several possible extension mechanisms that specify the property value to be obtained from an existing value. The most common of these is {StaticResource} markup extension.</dd>
</dl>
## -property-value
The value to apply to the property that is specified by the [Setter](setter.md).

## -remarks
As you can see from the XAML syntax, there are a variety of ways to specify the Value for a [Setter](setter.md) in XAML:
+ As an attribute, using a string value. Such a string value can be implicitly converted to a property-specific type for simple cases such as setting numeric values, named values from an enumeration, or a Uniform Resource Identifier (URI).
+ As a complete new object that's declared in XAML object element syntax, and the object element is nested within a property element usage.
+ As an attribute that has a [{StaticResource} markup extension](/windows/uwp/xaml-platform/staticresource-markup-extension) usage within the quotes.
Typically the value type of the property dictates which syntax is appropriate. For more info on XAML usages, see [XAML overview](/windows/uwp/xaml-platform/xaml-overview) or [XAML syntax guide](/windows/uwp/xaml-platform/xaml-syntax-guide). You can use attribute syntax for most XAML UI properties, and UI properties that specifically require a property element usage or a resource reference are less common. A [{StaticResource} markup extension](/windows/uwp/xaml-platform/staticresource-markup-extension) usage can be appropriate even for strings or numeric values if those values are shared by more than one style or property.

You must specify both the [Property](setter_property.md) and Value properties on a [Setter](setter.md). Otherwise an exception is thrown (either a parse exception or runtime error, depending on whether the [Setter](setter.md) is created in XAML or modified in code).

If you're accessing a [Setter](setter.md) instance using code, you cannot change the value of any property of a [Setter](setter.md) instance if the value of the [IsSealed](style_issealed.md) property on a parent [Style](style.md) is **true**. This is also reported by the [IsSealed](setterbase_issealed.md) property on an individual [Setter](setter.md). The system sets these properties to **true** when the runtime applies styles to UI elements and displays them in the UI. Attempting to change a sealed [Setter](setter.md) throws a runtime error.

### Styles and templates

You can use a [Setter](setter.md) in a [Style](style.md) to apply values to any dependency property. But it's the [Setter](setter.md) for the [Template](../windows.ui.xaml.controls/control_template.md) property of a [Control](../windows.ui.xaml.controls/control.md)-derived class that constitutes the majority of the XAML markup in a typical [Style](style.md). The Value for a [Setter](setter.md) with `Property="Template"` is almost always specified as a property element that contains a [ControlTemplate](../windows.ui.xaml.controls/controltemplate.md) object element.

When a [Style](style.md) is used to define a control template, the [TargetType](style_targettype.md) of the [Style](style.md) element and the [TargetType](../windows.ui.xaml.controls/controltemplate_targettype.md) of the [ControlTemplate](../windows.ui.xaml.controls/controltemplate.md) element for its [Control.Template](../windows.ui.xaml.controls/control_template.md) setter should always use the same value.

The [Template](../windows.ui.xaml.controls/control_template.md) setter defines the basic template UI definition for a control instance where that template is applied. It also contains the visual states for a control, and other state-based UI definitions such as default theme transitions. For a complex control such as [ListBox](../windows.ui.xaml.controls/listbox.md), the default template [Style](style.md) and the [ControlTemplate](../windows.ui.xaml.controls/controltemplate.md) within can have hundreds of lines of XAML. For more info on the role of [Style](style.md) in control templating scenarios, see [Quickstart: Control templates](/previous-versions/windows/apps/hh465374(v=win.10)).

## -examples

## -see-also
