---
-api-id: M:Windows.UI.Xaml.DependencyProperty.Register(System.String,Windows.UI.Xaml.Interop.TypeName,Windows.UI.Xaml.Interop.TypeName,Windows.UI.Xaml.PropertyMetadata)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.DependencyProperty Register(System.String name, Windows.UI.Xaml.Interop.TypeName propertyType, Windows.UI.Xaml.Interop.TypeName ownerType, Windows.UI.Xaml.PropertyMetadata typeMetadata)
-->

# Windows.UI.Xaml.DependencyProperty.Register

## -description
Registers a dependency property with the specified property name, property type, owner type, and property metadata for the property. Use this method when defining or initializing a [DependencyObject](dependencyobject.md) derived class that will own the registered dependency property.

## -parameters
### -param name
The name of the dependency property to register.

### -param propertyType
The type of the property, as a type reference ([System.Type](https://docs.microsoft.com/dotnet/api/system.type?redirectedfrom=MSDN) for Microsoft .NET, a [TypeName](../windows.ui.xaml.interop/typename.md) helper struct for Visual C++ component extensions (C++/CX)).

### -param ownerType
The owner type that is registering the dependency property, as a type reference ([System.Type](https://docs.microsoft.com/dotnet/api/system.type?redirectedfrom=MSDN) for Microsoft .NET, a [TypeName](../windows.ui.xaml.interop/typename.md) helper struct for Visual C++ component extensions (C++/CX)).

### -param typeMetadata
A property metadata instance. This can contain a [PropertyChangedCallback](propertychangedcallback.md) implementation reference.

## -returns
A dependency property identifier that typically is stored in a public static read-only field in your [DependencyObject](dependencyobject.md) derived class. The identifier is then used both by your own code and any third-party user code to reference the dependency property later, for operations such as setting its value programmatically or attaching a [Binding](../windows.ui.xaml.data/binding.md) in code.

## -remarks
How to register a custom dependency property is described in detail (with examples) in the topic [Custom dependency properties](https://docs.microsoft.com/windows/uwp/xaml-platform/custom-dependency-properties).

Registering a dependency property is typically something that you only do when an app first starts or [DependencyObject](dependencyobject.md) derived classes defined by your app code are first used. You need to register the dependency properties early in the app lifetime to assure that other code and XAML in your app don't try to use the dependency properties before they are registered and available. Exactly how and when to register varies, based on the programming language. For C# or Microsoft Visual Basic it's common to register dependency properties during the static class initialization of the class that owns the dependency property. That way any code or XAML that initializes the instance will invoke that static construction and register the dependency property. For Visual C++ component extensions (C++/CX)), static class initialization isn't an available technique, so you typically must define an app-wide helper method that registers all the custom dependency properties that your app intends to use, as part of the [Application](application.md) object initialization. For examples of how and when to register custom dependency properties, including some special techniques that are needed for Visual C++ component extensions (C++/CX), see [Custom dependency properties](https://docs.microsoft.com/windows/uwp/xaml-platform/custom-dependency-properties).

## -examples

## -see-also
[Custom dependency properties](https://docs.microsoft.com/windows/uwp/xaml-platform/custom-dependency-properties), [Dependency properties overview](https://docs.microsoft.com/windows/uwp/xaml-platform/dependency-properties-overview), [XAML user and custom controls sample](https://go.microsoft.com/fwlink/p/?linkid=238581)
