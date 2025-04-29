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

This method will return **E_ILLEGAL_METHOD_CALL** if there are other async operations in progress on the same [IStorageItem](istorageitem.md) instance. Make sure that another thread isn't modifying the **IStorageItem** at the same time.

## -examples

This example shows you how to access basic properties of a file using the **GetBasicPropertiesAsync** method of a [StorageFile](storagefile.md) object:

```csharp
BasicProperties basicProperties = await storageFile.GetBasicPropertiesAsync();
ulong size = basicProperties.Size;
```

You must have a [StorageFile](storagefile.md) object (`storageFile` in the example) that represents your file in order to invoke the storageFile.GetBasicPropertiesAsync method.

## -see-also

[IStorageItem](istorageitem.md), [StorageFile](storagefile.md)