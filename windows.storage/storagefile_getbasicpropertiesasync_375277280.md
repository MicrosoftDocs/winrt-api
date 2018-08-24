---
-api-id: M:Windows.Storage.StorageFile.GetBasicPropertiesAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.FileProperties.BasicProperties> GetBasicPropertiesAsync()
-->

# Windows.Storage.StorageFile.GetBasicPropertiesAsync

## -description
Gets the basic properties of the current file.

## -returns
When this method completes successfully, it returns the basic properties of the current file as a [BasicProperties](../windows.storage.fileproperties/basicproperties.md) object.

## -remarks
This method will return E_ILLEGAL_METHOD_CALL if there are other async operations in progress on the same StorageItem instance. Make sure that another thread isn't modifying the StorageItem at the same time.  

## -examples
This example shows you how to access basic properties of a file using the [storageFile.getBasicPropertiesAsync](storagefile_getbasicpropertiesasync_375277280.md) method.

```javascript
storageFile.getBasicPropertiesAsync().then(
    function (basicProperties) {
        var size  = basicProperties.size;
    }
);
```

You must have a [StorageFile](storagefile.md) object (`storageFile` in the example) that represents your file in order to use the [storageFile.getBasicPropertiesAsync](storagefile_getbasicpropertiesasync_375277280.md) method.

## -see-also
