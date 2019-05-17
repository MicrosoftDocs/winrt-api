---
-api-id: M:Windows.Storage.IStorageItem2.GetParentAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFolder> GetParentAsync()
-->

# Windows.Storage.IStorageItem2.GetParentAsync

## -description
Gets the parent folder of the current storage item.

## -returns
When this method completes, it returns the parent folder as a [StorageFolder](storagefolder.md).

## -remarks
You must have access to the parent for the GetParentAsync method to succeed, either by declaring library capabilities or by persisting a higher-level folder in the Access List. Also, this method returns **null** if you can’t get to the parent, instead of raising an exception.

This example shows how to get the parent folder of a [StorageFile](storagefile.md).



```javascript
function openParentFolder(file) {
    file.GetParentAsync().done(function (folder) {
        if (folder != null) {
            folder.getItemsAsync(function (items) {
                var list = document.getElementById("parentFolderItemsList");
                items.forEach(function (item) {
                    var listItemElement = document.createElement("li");
                    if (item.isOfType(Windows.Storage.StorageItemTypes.folder)) {
                        listItemElement.textContent = item.name + "\\";
                    } else {
                        listItemElement.textContent = item.name;
                    }
                    list.appendChild(listItemElement);
                });
            });
        } else {
            // Unable to get parent folder
        }
    });
}

```



## -examples

## -see-also
