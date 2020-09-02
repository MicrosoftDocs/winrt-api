---
-api-id: T:Windows.Devices.Enumeration.Pnp.PnpObjectCollection
-api-type: winrt class
---

<!-- Class syntax.
public class PnpObjectCollection : Windows.Foundation.Collections.IIterable<Windows.Devices.Enumeration.Pnp.PnpObject>, Windows.Foundation.Collections.IVectorView<Windows.Devices.Enumeration.Pnp.PnpObject>
-->

# Windows.Devices.Enumeration.Pnp.PnpObjectCollection

## -description
Represents an iterable collection of Pnp device objects.

## -remarks
### Collection member lists

For JavaScript, **PnpObjectCollection** has the members shown in the member lists. In addition, **PnpObjectCollection** supports a **length** property, members of **Array.prototype**, and using an index to access items.

<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

**PnpObjectCollection** is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<PnpObject>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator), cast to [IEnumerable<T>](/dotnet/api/system.collections.generic.ienumerable-1) with a [PnpObject](pnpobject.md) constraint.

<!--End NET note for IEnumerable support-->

### Enumerating the collection in C++/WinRT

```cppwinrt
...
using namespace Windows::Devices::Enumeration::Pnp;
...
void EnumerateCollection(PnpObjectCollection const& collection)
{
    for (PnpObject const& object : collection)
    {
        // ...
    }
}
```

Also see [Collections with C++/WinRT](/windows/uwp/cpp-and-winrt-apis/collections).

## -examples

## -see-also