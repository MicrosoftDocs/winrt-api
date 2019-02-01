---
-api-id: M:Windows.UI.Xaml.DependencyProperty.RegisterAttached(System.String,Windows.UI.Xaml.Interop.TypeName,Windows.UI.Xaml.Interop.TypeName,Windows.UI.Xaml.PropertyMetadata)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.DependencyProperty RegisterAttached(System.String name, Windows.UI.Xaml.Interop.TypeName propertyType, Windows.UI.Xaml.Interop.TypeName ownerType, Windows.UI.Xaml.PropertyMetadata defaultMetadata)
-->

# Windows.UI.Xaml.DependencyProperty.RegisterAttached

## -description
Registers an attached dependency property with the specified property name, property type, owner type, and property metadata for the property.

## -parameters
### -param name
The name of the dependency property to register.

### -param propertyType
The type of the property, as a type reference ([System.Type](https://msdn.microsoft.com/library/system.type.aspx) for Microsoft .NET, a [TypeName](../windows.ui.xaml.interop/typename.md) helper struct for Visual C++ component extensions (C++/CX)).

### -param ownerType
The owner type that is registering the dependency property, as a type reference ([System.Type](https://msdn.microsoft.com/library/system.type.aspx) for Microsoft .NET, a [TypeName](../windows.ui.xaml.interop/typename.md) helper struct for Visual C++ component extensions (C++/CX)).

### -param defaultMetadata
A property metadata instance. This can contain a [PropertyChangedCallback](propertychangedcallback.md) implementation reference.

## -returns
A dependency property identifier that should be used to set the value of a public static read-only field in your class. That identifier is then used to reference the attached property later, for operations such as setting its value programmatically or attaching a [Binding](../windows.ui.xaml.data/binding.md).

## -remarks

## -examples
This example defines a class that derives from [DependencyObject](dependencyobject.md), and defines an attached property along with the identifier field. The scenario for this class is that it is a service class that declares an attached property that other UI elements can set in XAML, and the service potentially acts on the attached property values on those UI elements at run time. For more examples, see [Custom attached properties](https://msdn.microsoft.com/library/e9c0c57e-6098-4875-aa3e-9d7b36e160e0).



[!code-csharp[DOMain](../windows.ui.xaml/code/DOandDP/csharp/Class1.cs#SnippetDOMain)]

[!code-vb[DOMain](../windows.ui.xaml/code/DOandDP/vbnet/Class1.vb#SnippetDOMain)]

## -see-also
[Custom attached properties](https://msdn.microsoft.com/library/e9c0c57e-6098-4875-aa3e-9d7b36e160e0), [Dependency properties overview](https://msdn.microsoft.com/library/ad649e66-f71c-4daa-9994-617c886fda7e), [Attached properties overview](https://msdn.microsoft.com/library/098c1de0-d640-48b1-9961-d0adf33266e2)
1de0-d640-48b1-9961-d0adf33266e2)
