---
-api-id: M:Windows.UI.Xaml.DependencyObject.SetValue(Windows.UI.Xaml.DependencyProperty,System.Object)
-api-type: winrt method
---

<!-- Method syntax
public void SetValue(Windows.UI.Xaml.DependencyProperty dp, System.Object value)
-->

# Windows.UI.Xaml.DependencyObject.SetValue

## -description
Sets the local value of a dependency property on a [DependencyObject](dependencyobject.md).



## -parameters
### -param dp
The identifier of the dependency property to set.

### -param value
The new local value.

## -remarks
If the provided *value* type does not match the type that is declared for the dependency property as it was originally registered, an exception is thrown.

Not all Windows Runtime properties as used by XAML are dependency properties. A [DependencyProperty](dependencyproperty.md) identifier needs to exist and it must be available as a public property of an owning object, typically the object that registered the property.

For app user-code, calling SetValue is not typically necessary. Usually, a Windows Runtime dependency property or a custom dependency property has a conventional property that wraps it, and you can just set the property value through a conventional dotted usage. Cases where you might still use SetValue are:
+ You are defining a custom dependency property. You will call SetValue as part of defining your own property set accessor for a conventional property usage. For more info, see [Custom dependency properties](/windows/uwp/xaml-platform/custom-dependency-properties).
+ You are defining a callback or are in some other scope where you are already being passed a [DependencyProperty](dependencyproperty.md) identifier, and it is possible that more than one dependency property exists that you might want to interact with in that scope. In these cases it is probably simpler to call SetValue, passing the identifier.


## -examples

## -see-also
[Custom dependency properties](/windows/uwp/xaml-platform/custom-dependency-properties), [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview), [XAML user and custom controls sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/XAML%20user%20and%20custom%20controls%20sample)
