---
-api-id: T:Windows.UI.Xaml.TargetPropertyPath
-api-type: winrt class
---

<!-- Class syntax.
public class TargetPropertyPath : Windows.UI.Xaml.ITargetPropertyPath
-->

# Windows.UI.Xaml.TargetPropertyPath

## -description
Represents the path to a property on a target element.



## -remarks
TargetPropertyPath is used to create the simplified dotted [Setter.Target](setter_target.md) syntax in XAML.

## -examples
In this example, `myPanel.Orientation` is a TargetPropertyPath where `myPanel` is the [Target](setter_target.md) and `Orientation` is the [Property](setter_property.md).

```xaml
<Setter Target="myPanel.Orientation" Value="Horizontal"/>
```



## -see-also
[Setter](setter.md)
