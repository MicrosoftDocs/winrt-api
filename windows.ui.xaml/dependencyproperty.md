---
-api-id: T:Windows.UI.Xaml.DependencyProperty
-api-type: winrt class
---

<!-- Class syntax.
public class DependencyProperty : Windows.UI.Xaml.IDependencyProperty
-->

# Windows.UI.Xaml.DependencyProperty

## -description
Represents a dependency property that is registered with the dependency property system. Dependency properties provide support for value expressions, data binding, animation, and property change notification. For more info on how DependencyProperty values serve as identifiers for dependency properties, see [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview).



## -xaml-syntax
```xaml
See Remarks
```


## -remarks
Dependency property concepts are covered in detail in the topic [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview).

Instances of DependencyProperty are often referenced in the documentation as dependency property identifiers. The identifiers provide a way to refer to a dependency property that was registered to a particular [DependencyObject](dependencyobject.md) owner type. When the owner type registers the property, the owner type exposes the DependencyProperty instance as the identifier, which is a static member of the owner class.

The owner [DependencyObject](dependencyobject.md) provides the property store for the dependency property. When working with a dependency property in code, you might use a DependencyProperty identifiers as input for calls to property system methods such as [SetValue](dependencyobject_setvalue_52578133.md). However, in most cases, getting or setting a dependency property is simpler by getting or setting the *wrapper*; this concept is explained in [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview).

DependencyProperty supports a native conversion for XAML attribute syntax for filling values, which is used when a [Setter](setter.md) specifies its [Property](setter_property.md) value. This conversion uses an *ownerTypeName***.***propertyName* form for the input string.

> [!NOTE]
> A related syntax that can also be used to specify a property by name and is required by certain data and animation API is the *property path syntax*. A property path can be used to reference the structure of a class that has properties and the value of that property. For more info, see [Property-path syntax](/windows/uwp/xaml-platform/property-path-syntax).



> [!TIP]
> If you are programming using a Microsoft .NET language (C# or Microsoft Visual Basic), the [TypeName](../windows.ui.xaml.interop/typename.md) type projects as [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true). When programming using C#, it is common to use the **typeof** operator to get references to the [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) of a type. In Microsoft Visual Basic, use **GetType**. If you're using Visual C++ component extensions (C++/CX)), where you'll need to create a [TypeName](../windows.ui.xaml.interop/typename.md) helper struct, you can use the [typeid component extension](/cpp/windows/typeid-cpp-component-extensions).

The Windows Runtime implements the XAML attached property language feature with DependencyProperty identifiers and property storage on a [DependencyObject](dependencyobject.md). For more info, see [Attached properties overview](/windows/uwp/xaml-platform/attached-properties-overview).

### Custom dependency properties

If you want properties on your custom types to support value expressions, data binding, or animation, you should back the properties with a dependency property following these guidelines:

+ Register a dependency property using the [Register](dependencyproperty_register_1826645607.md) method, which returns a DependencyProperty. This is your dependency property identifier. You should expose this object as an accessible static read-only property in your class. By convention, the name of this DependencyProperty identifier field should end with "Property".
+ During registration, you can provide [PropertyMetadata](propertymetadata.md) for the property to further define the property's behaviors.
+ Provide **get** and **set** accessors for the property: these are the property wrappers, and will simplify access to your property for all callers.


### XAML references to a dependency property name

Some properties that are typically set in XAML markup use DependencyProperty as their value. For example, you set [Setter.Property](setter_property.md) in XAML. To set such a property in XAML, you specify the name of the dependency property as the attribute value.

For [Setter.Property](setter_property.md) the type from which you are referencing a dependency property name is already scoped by the [TargetType](style_targettype.md) of the [Style](style.md) where the [Setter](setter.md) exists. For a dependency property on the [TargetType](style_targettype.md) object, you can specify a [Setter.Property](setter_property.md) value using the simple name of the dependency property. For example, if you have a [Style](style.md) that targets a [Slider](../windows.ui.xaml.controls/slider.md), and you want to style the [Orientation](../windows.ui.xaml.controls/slider_orientation.md) property, the [Property](setter_property.md) attribute value can be just "Orientation". Simple names also work so long as the dependency property came from a class in the deeper inheritance of the target type. For example, to style the [Visibility](uielement_visibility.md) property in the [Style](style.md) for a [Slider](../windows.ui.xaml.controls/slider.md), a [Property](setter_property.md) attribute value of "Visibility" will work. In that case [Visibility](uielement_visibility.md) was defined by [UIElement](uielement.md), but inherits to [Slider](../windows.ui.xaml.controls/slider.md).

You can also use [Setter.Property](setter_property.md) to reference an attached property name. For the attribute value, use the form *AttachedPropertyOwner.AttachedPropertyName*, just like you'd use to set that attached property as an attribute in XAML. For example, here is a [Setter](setter.md) that sets the attached property [AutomationProperties.ItemType](/uwp/api/windows.ui.xaml.automation.automationproperties.itemtype) in a [Style](style.md): `<Setter Property="AutomationProperties.ItemType" Value="Navigation Button"/>`

> [!NOTE]
> The name of a dependency property is not the name of the DependencyProperty static property identifier. It's the name string that the property is registered with, and the name that's the typical usage name for that property in Windows Runtime programming when exposed by Microsoft IntelliSense and the reference documentation. In other words, you don't want the string you specify for [Setter.Property](setter_property.md) in XAML to end with "Property" (except for a few rare cases where the dependency property actually does contain the suffix "Property").

### Using a **DependencyProperty** (dependency property identifier) in code

There are several methods that are utility methods for the Windows Runtime property system that use a DependencyProperty value as an input parameter. These include:
+ [DependencyObject.ClearValue](dependencyobject_clearvalue_1095854009.md)
+ [DependencyObject.GetAnimationBaseValue](dependencyobject_getanimationbasevalue_1072186849.md)
+ [DependencyObject.GetValue](dependencyobject_getvalue_1188551207.md)
+ [DependencyObject.ReadLocalValue](dependencyobject_readlocalvalue_275037327.md)
+ [DependencyObject.SetValue](dependencyobject_setvalue_52578133.md)
+ [DependencyPropertyChangedEventArgs.Property](dependencypropertychangedeventargs_property.md)
+ [Setter(DependencyProperty,Object) constructor](setter_setter_592072496.md)


## -examples
This example shows a basic usage where a DependencyProperty is established as a public static member of a class. This is done by calling [Register](dependencyproperty_register_1826645607.md) and storing the return value as a member of the class. For more examples, see [Custom dependency properties](/windows/uwp/xaml-platform/custom-dependency-properties).



[!code-csharp[DOSimpleDP](../windows.ui.xaml/code/DOandDP/csharp/Class1.cs#SnippetDOSimpleDP)]

[!code-vb[DOSimpleDP](../windows.ui.xaml/code/DOandDP/vbnet/Class1.vb#SnippetDOSimpleDP)]
> A Visual C++ component extensions (C++/CX) example isn't shown here because it must be factored completely differently than the Microsoft .NET examples, and involves several different code files. See examples in [Custom dependency properties](/windows/uwp/xaml-platform/custom-dependency-properties).

## -see-also
[Custom dependency properties](/windows/uwp/xaml-platform/custom-dependency-properties), [Dependency properties overview](/windows/uwp/xaml-platform/dependency-properties-overview), [Custom attached properties](/windows/uwp/xaml-platform/custom-attached-properties), [XAML user and custom controls sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/XAML%20user%20and%20custom%20controls%20sample)
