---
-api-id: T:Windows.Data.Json.JsonArray
-api-type: winrt class
---

<!-- Class syntax.
public class JsonArray : Windows.Data.Json.IJsonArray, Windows.Data.Json.IJsonValue, Windows.Foundation.Collections.IIterable<Windows.Data.Json.IJsonValue>, Windows.Foundation.Collections.IVector<Windows.Data.Json.IJsonValue>, Windows.Foundation.IStringable
-->

# Windows.Data.Json.JsonArray

## -description

Represents a JSON array.

[JsonArray](jsonarray_jsonarray_1221375020.md) inherits the [IVector(IJsonValue)](../windows.foundation.collections/ivector_1.md) and [IIterable(IJsonValue)](../windows.foundation.collections/iiterable_1.md) interfaces, which provide methods to iterate through the elements in the array and update its contents.

## -remarks

For an example of how these class methods are used to parse an array from a JSON string and convert it into a JsonArray object, update the values the array contains, and then serialize the updated JsonArray object as a JSON string, see [Using JavaScript Object Notation (JSON)](/previous-versions/windows/apps/hh770289(v=win.10)).

<!--Begin NET note for IEnumerable support-->

### Enumerating the collection in C# or Microsoft Visual Basic

A JsonArray is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<IJsonValue>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast to [IEnumerable&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) with an [IJsonValue](ijsonvalue.md) constraint.

<!--End NET note for IEnumerable support-->

## -examples

## -see-also

[Using JavaScript Object Notation (JSON)](/previous-versions/windows/apps/hh770289(v=win.10)), [JSON sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Json)
