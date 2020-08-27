---
-api-id: T:Windows.Foundation.Collections.ValueSet
-api-type: winrt class
---

<!-- Class syntax.
public class ValueSet : Windows.Foundation.Collections.IIterable<Windows.Foundation.Collections.IKeyValuePair<System.String, System.Object>>, Windows.Foundation.Collections.IMap<System.String, System.Object>, Windows.Foundation.Collections.IObservableMap<System.String, System.Object>, Windows.Foundation.Collections.IPropertySet
-->

# Windows.Foundation.Collections.ValueSet

## -description
Implements a map with keys of type **String** and values of type [Object](https://docs.microsoft.com/dotnet/api/system.object?redirectedfrom=MSDN). Object must be a WinRT [https://docs.microsoft.com/en-us/windows/win32/api/windows.foundation/nn-windows-foundation-ipropertyvalue PropertyValue] or ValueSet. As a PropertyValue, it can be any type except [https://docs.microsoft.com/en-us/windows/win32/api/windows.foundation/ne-windows-foundation-propertytype PropertyType] **InspectableArray**. This limitation exists to ensure that the value can be serialized; passed by value accoss a process boundary. 

> [!NOTE]
> Some members are only available for the specified language.

## -remarks
Custom types must implement the [IInspectable](https://docs.microsoft.com/windows/desktop/api/inspectable/nn-inspectable-iinspectable) interface in order to be serializable.

## -examples

## -see-also
[IInspectable](https://docs.microsoft.com/windows/desktop/api/inspectable/nn-inspectable-iinspectable), [IPropertySet](ipropertyset.md), [IObservableMap(String, Object)](iobservablemap_2.md), [IMap(String, Object)](imap_2.md), [IIterable(IKeyValuePair)](iiterable_1.md), [How to: Determine if a .NET Standard object is serializable](https://docs.microsoft.com/dotnet/standard/serialization/how-to-determine-if-netstandard-object-is-serializable)
