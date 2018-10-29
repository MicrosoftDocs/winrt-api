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

For an example of how these class methods are used to parse an array from a JSON string and convert it into a [JsonArray](jsonarray.md) object, update the values the array contains, and then serialize the updated [JsonArray](jsonarray.md) object as a JSON string, see [Using JavaScript Object Notation (JSON)](http://msdn.microsoft.com/library/94875e43-4e0c-499f-b409-317bcd306d3e).

<!--Begin NET note for IEnumerable support-->

### Enumerating the collection in C# or Microsoft Visual Basic

A [JsonArray](jsonarray.md) is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<IJsonValue>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](https://docs.microsoft.com/dotnet/api/system.collections.ienumerable.getenumerator), cast to [IEnumerable<T>](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1) with an [IJsonValue](ijsonvalue.md) constraint.

<!--End NET note for IEnumerable support-->

## -examples

## -see-also

[Using JavaScript Object Notation (JSON)](http://msdn.microsoft.com/library/94875e43-4e0c-499f-b409-317bcd306d3e), [JSON sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620556)