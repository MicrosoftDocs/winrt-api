---
-api-id: T:Windows.Storage.AccessCache.AccessListEntryView
-api-type: winrt class
---

<!-- Class syntax.
public class AccessListEntryView : Windows.Foundation.Collections.IIterable<Windows.Storage.AccessCache.AccessListEntry>, Windows.Foundation.Collections.IVectorView<Windows.Storage.AccessCache.AccessListEntry>
-->

# Windows.Storage.AccessCache.AccessListEntryView

## -description
A list of the entries that are in your app's most recently used list (MRU) (obtained from the static [StorageApplicationPermissions.MostRecentlyUsedList](storageapplicationpermissions_mostrecentlyusedlist.md) property) and in your app's future-access list (obtained from the static [StorageApplicationPermissions.FutureAccessList](storageapplicationpermissions_futureaccesslist.md) property).

## -remarks
To see more code examples that use this class, see the [File access sample]( http://go.microsoft.com/fwlink/p/?linkid=231445).

### Collection member lists

For JavaScript, AccessListEntryView has the members shown in the member lists. In addition, AccessListEntryView supports a **length** property, members of **Array.prototype**, and using an index to access items.


<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

AccessListEntryView is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<AccessListEntry>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](https://docs.microsoft.com/dotnet/api/system.collections.ienumerable.getenumerator?redirectedfrom=MSDN#System_Collections_IEnumerable_GetEnumerator), cast to [IEnumerable&lt;T&gt;](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1?redirectedfrom=MSDN) with an [AccessListEntry](accesslistentry.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples
The [File access sample]( http://go.microsoft.com/fwlink/p/?linkid=231445) demonstrates how to enumerate entries in the [MostRecentlyUsedList](storageapplicationpermissions_mostrecentlyusedlist.md).

```csharp
AccessListEntryView entries = StorageApplicationPermissions.MostRecentlyUsedList.Entries;
if (entries.Count > 0)
{
    foreach (AccessListEntry entry in entries)
    {
        StringBuilder outputText = new StringBuilder("The MRU list contains the following item(s):" + Environment.NewLine + Environment.NewLine);
        outputText.AppendLine(entry.Metadata);
    }
}
else
{
    // Handle empty list
}
```

```javascript
var entries = Windows.Storage.AccessCache.StorageApplicationPermissions.mostRecentlyUsedList.entries;
if (entries.size > 0) {
    var outputText = "The MRU list contains the following item(s):<br/><br/>";
    mruEntries.forEach(function (entry) {
        mruOutputText += entry.metadata + "<br/>"; // Application previously chose to store sampleFile.name in this field
    });
} else {
    // Handle empty list
}
```



## -see-also
[StorageItemAccessList.Entries](storageitemaccesslist_entries.md), [StorageItemMostRecentlyUsedList](storageitemmostrecentlyusedlist.md), [StorageItemMostRecentlyUsedList.Entries](storageitemmostrecentlyusedlist_entries.md)
