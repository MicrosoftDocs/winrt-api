---
-api-id: T:Windows.UI.Xaml.Data.BindableAttribute
-api-type: winrt class
---

<!-- Class syntax.
public class BindableAttribute : System.Attribute
-->

# Windows.UI.Xaml.Data.BindableAttribute

## -description
Specifies that a type defined in C++ can be used for binding.

## -remarks
Apply this attribute to C++-based data classes to enable their use as binding sources. Common language runtime (CLR) types, including all types defined in C# and Microsoft Visual Basic, are bindable by default. You can also make a type bindable by implementing [ICustomPropertyProvider](icustompropertyprovider.md). For more info, see [Data binding in depth](http://msdn.microsoft.com/library/41e1b4f1-6caf-4128-a61a-4e400b149011).

## -examples
The following code example shows the typical usage pattern for this attribute. For the complete code listing, see the [XAML data binding sample](http://go.microsoft.com/fwlink/p/?linkid=226854).

```cpp
[Windows::UI::Xaml::Data::Bindable]
public ref class Employee sealed : Windows::UI::Xaml::Data::INotifyPropertyChanged
{
    // ...
}
```



## -see-also
[Attribute](https://msdn.microsoft.com/library/system.attribute.aspx), [Binding](binding.md), [ICustomPropertyProvider](icustompropertyprovider.md), [XAML data binding sample](http://go.microsoft.com/fwlink/p/?linkid=226854), [Data binding in depth](http://msdn.microsoft.com/library/41e1b4f1-6caf-4128-a61a-4e400b149011)