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
To see more code examples that use this class, see the [File access sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FileAccess).

<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

AccessListEntryView is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable<AccessListEntry>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast to [IEnumerable&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) with an [AccessListEntry](accesslistentry.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples
The [File access sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/FileAccess) demonstrates how to enumerate entries in the [MostRecentlyUsedList](storageapplicationpermissions_mostrecentlyusedlist.md).

```csharp
AccessListEntryView entries = StorageApplicationPermissions.MostRecentlyUsedList.Entries;
if (entries.Count > 0)
{
    StringBuilder outputText = new StringBuilder("The MRU list contains the following item(s):" + Environment.NewLine + Environment.NewLine);

    foreach (AccessListEntry entry in entries)
    {
        outputText.AppendLine(entry.Metadata);
    }
}
else
{
    // Handle empty list
}
```

```cppwinrt
#include <sstream>
#include <winrt/Windows.Storage.AccessCache.h>
using namespace winrt;
using namespace Windows::Storage::AccessCache;
...
AccessListEntryView entries { StorageApplicationPermissions::MostRecentlyUsedList().Entries() };
if (entries.Size() > 0)
{
    std::wostringstream outputText;
    outputText << L"The MRU list contains the following item(s):" << std::endl << std::endl;

    for(AccessListEntry const& entry: entries)
    {
        outputText << entry.Metadata.c_str() << std::endl;
    }

    std::wstring outputString { outputText.str() };
}
else
{
    // Handle empty list
}
```

## -see-also
[StorageItemAccessList.Entries](storageitemaccesslist_entries.md), [StorageItemMostRecentlyUsedList](storageitemmostrecentlyusedlist.md), [StorageItemMostRecentlyUsedList.Entries](storageitemmostrecentlyusedlist_entries.md)
