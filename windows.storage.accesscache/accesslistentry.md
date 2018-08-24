---
-api-id: T:Windows.Storage.AccessCache.AccessListEntry
-api-type: winrt struct
---

<!-- Structure syntax.
public struct AccessListEntry 
-->

# AccessListEntry

## -description
Represents a list entry that contains the identifier and metadata for a [StorageFile](../windows.storage/storagefile.md) or [StorageFolder](../windows.storage/storagefolder.md) object in a list.

## -struct-fields

### -field Token
The identifier of the [StorageFile](../windows.storage/storagefile.md) or [StorageFolder](../windows.storage/storagefolder.md) in the list.
    

### -field Metadata
Optional app-specified metadata associated with the [StorageFile](../windows.storage/storagefile.md) or [StorageFolder](../windows.storage/storagefolder.md) in the list.
    

## -remarks
The fields of the [AccessListEntry](accesslistentry.md) structure are set by an app when it adds a [StorageFile](../windows.storage/storagefile.md) or [StorageFolder](../windows.storage/storagefolder.md) to the [StorageItemAccessList](storageitemaccesslist.md) or to the [StorageItemMostRecentlyUsedList](storageitemmostrecentlyusedlist.md).

The [AccessListEntry](accesslistentry.md) for an item in a list can be accessed from the [AccessListEntryView.First](accesslistentryview_first_1920739956.md) or [AccessListEntryView.GetAt](accesslistentryview_getat_496709656.md) methods, or from the [ItemRemovedEventArgs.RemovedEntry](itemremovedeventargs_removedentry.md) property.



## -examples

## -see-also
[AccessListEntryView.First](accesslistentryview_first_1920739956.md), [AccessListEntryView.GetAt](accesslistentryview_getat_496709656.md), [ItemRemovedEventArgs.RemovedEntry](itemremovedeventargs_removedentry.md), [StorageItemAccessList](storageitemaccesslist.md), [StorageItemAccessList.Add](storageitemaccesslist_add_118555710.md), [StorageItemAccessList.AddOrReplace](storageitemaccesslist_addorreplace_1991369802.md), [StorageItemMostRecentlyUsedList](storageitemmostrecentlyusedlist.md), [StorageItemMostRecentlyUsedList.Add](/uwp/api/windows.storage.accesscache.storageitemmostrecentlyusedlist.add), [StorageItemMostRecentlyUsedList.AddOrReplace](/uwp/api/windows.storage.accesscache.storageitemmostrecentlyusedlist.addorreplace)