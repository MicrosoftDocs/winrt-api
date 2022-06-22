---
-api-id: P:Windows.UI.Xaml.FrameworkElement.Tag
-api-type: winrt property
---

<!-- Property syntax
public object Tag { get;  set; }
-->

# Windows.UI.Xaml.FrameworkElement.Tag

## -description
Gets or sets an arbitrary object value that can be used to store custom information about this object.



## -xaml-syntax
```xaml
<frameworkElement>
  <frameworkElement.Tag>
    object*
  </frameworkElement.Tag>
</frameworkElement>
- or -
<frameworkElement Tag="string"/>
```


## -xaml-values
<dl><dt>object*</dt><dd>object*A object or a custom object that supports object element syntax (the backing type must be nonabstract and must support a public default constructor).</dd>
<dt>string</dt><dd>stringA string value (can be a true string or input for an object type that supports type conversion from string).</dd>
</dl>
## -property-value
The intended arbitrary object value. This property has no default value.

## -remarks
The scenario for the Tag property is to provide an general-purpose property on all [FrameworkElement](frameworkelement.md) classes that supports data binding, animation and styles for itself but where the property's value does not have any implicit meaning to platform subsystems like layout, app model, text, input and so on. For example, you might put a value in the Tag property that has no meaning to the [FrameworkElement](frameworkelement.md) where it is set, but which could be useful as an [ElementName](../windows.ui.xaml.data/binding_elementname.md) binding value to some other element that uses the [FrameworkElement](frameworkelement.md) as a [DataContext](frameworkelement_datacontext.md) and processes the Tag value in its own way. Or you might use Tag as a way for an applied style to get a value from an arbitrary [FrameworkElement](frameworkelement.md) parent into a specific applied template using [{TemplateBinding} markup extension](/windows/uwp/xaml-platform/templatebinding-markup-extension), without requiring XAML namespace mapping of a specific instance property in app XAML.

## -examples

## -see-also
