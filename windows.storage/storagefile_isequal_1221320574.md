---
-api-id: M:Windows.Storage.StorageFile.IsEqual(Windows.Storage.IStorageItem)
-api-type: winrt method
---

<!-- Method syntax
public bool IsEqual(Windows.Storage.IStorageItem item)
-->

# Windows.Storage.StorageFile.IsEqual

## -description
Indicates whether the current file is equal to the specified file.

## -parameters
### -param item
The [IStorageItem](istorageitem.md) object that represents a file to compare against.

## -returns
Returns true if the current file is equal to the specified file; otherwise false.

## -remarks
Use the IsEqual method to determine whether two storage items represent the same file or folder.

This method compares the [Path](storagefile_path.md) property of both items to determine if they are the same. If there is no [Path](storagefile_path.md) (if the item is a library for example), or if the paths do not match the items are compared using [IShellItem.Compare](/windows/desktop/api/shobjidl_core/nf-shobjidl_core-ishellitem-compare).

This example shows how to compare two storage files for equality.

```javascript
function openNewFile() {
    var picker = new Windows.Storage.Pickers.FileOpenPicker;
    picker.fileTypeFilter.replaceAll(["*"]);
    picker.pickSingleFileAsync().then(function (file) {
        var alreadyOpenedFile = null;
        _openFiles.some(function (openFile) {
            if (file.IsEqual(openFile.file)) {
                alreadyOpenedFile = openFile;
                return true;
            }
            return false;
        });

        if (alreadyOpenedFile != null) {
            alreadyOpenedFile.window.activate();
        } else {
            createNewFileViewerWindow(file);
        }
    });
}
```



## -examples

## -see-also
[StorageFolder.IsEqual](storagefolder_isequal_1221320574.md)
