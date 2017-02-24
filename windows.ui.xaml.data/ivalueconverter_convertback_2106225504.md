---
-api-id: M:Windows.UI.Xaml.Data.IValueConverter.ConvertBack(System.Object,Windows.UI.Xaml.Interop.TypeName,System.Object,System.String)
-api-type: winrt method
---

<!-- Method syntax
public object ConvertBack(System.Object value, Windows.UI.Xaml.Interop.TypeName targetType, System.Object parameter, System.String language)
-->

# Windows.UI.Xaml.Data.IValueConverter.ConvertBack

## -description
Modifies the target data before passing it to the source object. This method is called only in **TwoWay** bindings.

## -parameters
### -param value
The target data being passed to the source.

### -param targetType
The type of the target property, as a type reference ([System.Type](https://msdn.microsoft.com/library/system.type.aspx) for Microsoft .NET, a [TypeName](../windows.ui.xaml.interop/typename.md) helper struct for Visual C++ component extensions (C++/CX)).

### -param parameter
An optional parameter to be used in the converter logic.

### -param language
The language of the conversion.

## -returns
The value to be passed to the source object.

## -remarks
If you don't use a converter for **TwoWay** bindings it's acceptable to leave [ConvertBack](ivalueconverter_convertback.md) unimplemented (uses the template default from Visual Studio where it returns a **NotImplementedException**).

## -examples

## -see-also
[Convert](ivalueconverter_convert.md), [XAML data binding sample](http://go.microsoft.com/fwlink/p/?linkid=226854), [Data binding in depth](http://msdn.microsoft.com/library/41e1b4f1-6caf-4128-a61a-4e400b149011)