---
-api-id: T:Windows.UI.Xaml.Data.RelativeSourceMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Data.RelativeSourceMode : int
-->

# RelativeSourceMode

## -description
Defines constants that describe the location of the binding source relative to the position of the binding target.



## -xaml-syntax
```xaml
<objectproperty="enumMemberName" />
```


## -enum-fields
### -field None:0
Don't use this value of RelativeSourceMode; always use either **Self** or **TemplatedParent**.

### -field TemplatedParent:1
Refers to the element to which the template (in which the data-bound element exists) is applied. This is similar to setting a TemplateBinding Markup Extension and is only applicable if the [Binding](binding.md) is within a template.

### -field Self:2
Refers to the element on which you are setting the binding and allows you to bind one property of that element to another property on the same element.


## -remarks

## -examples

## -see-also
[Binding](binding.md), [XAML data binding sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlBind), [Data binding in depth](/windows/uwp/data-binding/data-binding-in-depth)
