---
-api-id: T:Windows.Storage.StorageItemTypes
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Storage.StorageItemTypes : uint
-->

# StorageItemTypes

## -description
Describes whether an item that implements the [IStorageItem](istorageitem.md) interface is a file or a folder.

## -enum-fields
### -field None:0
A storage item that is neither a file nor a folder.

### -field File:1
A file that is represented as a [StorageFile](storagefile.md) instance.

### -field Folder:2
A folder that is represented as a [StorageFolder](storagefolder.md) instance.


## -remarks
A value from this enumeration is returned by the [IStorageItem.IsOfType](istorageitem_isoftype_1417811226.md), [StorageFile.IsOfType](storagefile_isoftype_1417811226.md), and [StorageFolder.IsOfType](storagefolder_isoftype_1417811226.md) methods.

The **IsOfType** method is useful for processing the results from a method that returns [IStorageItem](istorageitem.md) instances that can be files or folders. For example, the [GetItemAsync](storagefolder_getitemasync_1847090456.md) and [GetItemsAsync](storagefolder_getitemsasync_1518547059.md) methods returns [IStorageItem](istorageitem.md) instances. To work with the returned items, call the [IsOfType](istorageitem_isoftype_1417811226.md) method of the [IStorageItem](istorageitem.md) interface to determine whether each item is a file or a folder. Then cast the item to a [StorageFolder](storagefolder.md) or [StorageFile](storagefile.md).

## -examples
The following example shows how to get the files and subfolders in the current folder by calling the [GetItemsAsync()](storagefolder_getitemsasync_1518547059.md) method. Then the example iterates over each [IStorageItem](istorageitem.md) and calls the [IStorageItem.IsOfType](istorageitem_isoftype_1417811226.md) method to determine whether each item is a file or a folder.

```csharp
using Windows.Storage;
using System.Threading.Tasks;
using System.Diagnostics; // For writing results to Output window.

// Get the app's installation folder.
StorageFolder appFolder = Windows.ApplicationModel.Package.Current.InstalledLocation;

// Get the files and folders in the current folder.
IReadOnlyList<IStorageItem> itemsInFolder = await appFolder.GetItemsAsync();

// Iterate over the results and print the list of items
// to the Visual Studio Output window.
foreach (IStorageItem item in itemsInFolder)
{
    if(item.IsOfType(StorageItemTypes.Folder))
        Debug.WriteLine("Folder: " + item.Name);
    else
        Debug.WriteLine("File: " + item.Name + ", " + item.DateCreated);
}
```



## -see-also