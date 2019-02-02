---
-api-id: P:Windows.UI.Xaml.DependencyProperty.UnsetValue
-api-type: winrt property
---

<!-- Property syntax
public object UnsetValue { get; }
-->

# Windows.UI.Xaml.DependencyProperty.UnsetValue

## -description
Specifies a static value that is used by the property system rather than **null** to indicate that the property exists, but does not have its value set by the property system or by any app code.

## -property-value
The sentinel value for an unset value.

## -remarks
[UnsetValue](dependencyproperty_unsetvalue.md) is a sentinel value that is used for scenarios where the dependency property system is unable to determine a requested dependency property value. [UnsetValue](dependencyproperty_unsetvalue.md) is used rather than **null**, because **null** is a valid property value for most reference-type values, and is a frequently used [DefaultValue](propertymetadata_defaultvalue.md) in metadata for a dependency property.

[UnsetValue](dependencyproperty_unsetvalue.md) is never returned out of a [DependencyObject.GetValue](dependencyobject_getvalue_1188551207.md) call. When you call [DependencyObject.GetValue](dependencyobject_getvalue_1188551207.md) for a dependency property, one of these conditions is always true:
+ A dependency property has a default value established in metadata and that value is returned. This value might come from the property metadata's [DefaultValue](propertymetadata_defaultvalue.md). This might be **null**.
+ Some other value was established through value precedence (for example a style was applied, or a [Binding](../windows.ui.xaml.data/binding.md) was evaluated), and the default value is no longer relevant. Even though specifically set, this still might be **null**. For more info on value precedence, see [Dependency properties overview](https://msdn.microsoft.com/library/ad649e66-f71c-4daa-9994-617c886fda7e).


[DependencyObject.ReadLocalValue](dependencyobject_readlocalvalue_275037327.md) returns [UnsetValue](dependencyproperty_unsetvalue.md) when the requested property has not been locally set.



> [!NOTE]
> Do not register a dependency property with the default value of [UnsetValue](dependencyproperty_unsetvalue.md). This will be confusing for property consumers and will have unintended consequences within the property system.


<!--<rem  xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">Comment out don't think this applies. UnsetValue has a special meaning when used as the return value of a property changed callback.</rem>-->
[UnsetValue](dependencyproperty_unsetvalue.md) should be returned from an [IValueConverter](../windows.ui.xaml.data/ivalueconverter.md) implementation that provides conversion in a data binding to a dependency property, in any case where the converter is unable to convert a source value. Converters shouldn't throw exceptions for that case in [IValueConverter.Convert](../windows.ui.xaml.data/ivalueconverter_convert_101701969.md), these will surface as run-time exceptions that you'd need to add handling for in [UnhandledException](application_unhandledexception.md) or worse yet appear to users as actual run-time exceptions. Converter implementations should follow the general binding pattern that any failed binding does nothing and does not provide a value, and [UnsetValue](dependencyproperty_unsetvalue.md) rather than **null** is the sentinel value for that case that the binding engine understands. For more info, see [Data binding in depth](https://msdn.microsoft.com/library/41e1b4f1-6caf-4128-a61a-4e400b149011).

## -examples
This example checks for an existing local value with [ReadLocalValue](dependencyobject_readlocalvalue_275037327.md). If there is a local value, as indicated by not returning [UnsetValue](dependencyproperty_unsetvalue.md), then the existing local value is removed by calling [ClearValue](dependencyobject_clearvalue_1095854009.md).



[!code-csharp[DOCheckClear](../windows.ui.xaml/code/DOandDP/csharp/Class1.cs#SnippetDOCheckClear)]

[!code-vb[DOCheckClear](../windows.ui.xaml/code/DOandDP/vbnet/Class1.vb#SnippetDOCheckClear)]

## -see-also
[IValueConverter.Convert](../windows.ui.xaml.data/ivalueconverter_convert_101701969.md), [Custom dependency properties](https://msdn.microsoft.com/library/5adf7935-f2cf-4bb6-b1a5-f535c2ed8ef8), [Dependency properties overview](https://msdn.microsoft.com/library/ad649e66-f71c-4daa-9994-617c886fda7e), [Data binding in depth](https://msdn.microsoft.com/library/41e1b4f1-6caf-4128-a61a-4e400b149011)
b4f1-6caf-4128-a61a-4e400b149011)
