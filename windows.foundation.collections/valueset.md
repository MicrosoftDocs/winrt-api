---
-api-id: T:Windows.Foundation.Collections.ValueSet
-api-type: winrt class
---

<!-- Class syntax.
public class ValueSet : Windows.Foundation.Collections.IIterable<Windows.Foundation.Collections.IKeyValuePair<System.String, System.Object>>, Windows.Foundation.Collections.IMap<System.String, System.Object>, Windows.Foundation.Collections.IObservableMap<System.String, System.Object>, Windows.Foundation.Collections.IPropertySet
-->

# Windows.Foundation.Collections.ValueSet

## -description
Implements a map with keys of type **String** and values of type [Object](https://msdn.microsoft.com/library/system.object.aspx). This class prevents non-serializable types from being put into the map.

> [!NOTE]
> Some members are only available for the specified language.

## -remarks
Custom types must implement the [IInspectable](https://msdn.microsoft.com/library/windows/desktop/br205821(v=vs.85).aspx) interface in order to be serializable.

## -examples

## -see-also
[IInspectable](https://msdn.microsoft.com/library/windows/desktop/br205821(v=vs.85).aspx), [IPropertySet](ipropertyset.md), [IObservableMap(String, Object)](iobservablemap_2.md), [IMap(String, Object)](imap_2.md), [IIterable(IKeyValuePair)](iiterable_1.md), [How to: Determine if a .NET Standard object is serializable](https://docs.microsoft.com/dotnet/standard/serialization/how-to-determine-if-netstandard-object-is-serializable)