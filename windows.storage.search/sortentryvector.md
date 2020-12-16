---
-api-id: T:Windows.Storage.Search.SortEntryVector
-api-type: winrt class
---

<!-- Class syntax.
public class SortEntryVector : Windows.Foundation.Collections.IIterable<Windows.Storage.Search.SortEntry>, Windows.Foundation.Collections.IVector<Windows.Storage.Search.SortEntry>
-->

# Windows.Storage.Search.SortEntryVector

## -description
Provides access to the sorting criteria of the query results as a collection of SortEntry objects.

## -remarks
> [!NOTE]
> Although it's not attributed with `marshalling_behavior(agile)`, this class can be treated as agile. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx).
<!--W8B 988884 v2-->

You can retrieve this object using [QueryOptions.SortOrder](queryoptions_sortorder.md).

### Collection member lists

For JavaScript, SortEntryVector has the members shown in the member lists. In addition, SortEntryVector supports a **length** property, members of **Array.prototype**, and using an index to access items.


<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

A SortEntryVector is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<SortEntry>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.generic.ienumerable-1.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast to [IEnumerable&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) with a [SortEntry](sortentry.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[QueryOptions.SortOrder Property](queryoptions_sortorder.md)
