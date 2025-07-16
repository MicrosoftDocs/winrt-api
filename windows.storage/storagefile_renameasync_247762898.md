---
-api-id: M:Windows.Storage.StorageFile.RenameAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction RenameAsync(System.String desiredName)
-->

# Windows.Storage.StorageFile.RenameAsync

## -description

Renames the current file.

## -parameters

### -param desiredName

The desired, new name of the current item.

## -returns

No object or value is returned by this method when it completes.

## -remarks

If the name you specify is invalid, this method throws an exception. To handle all the ways the specified name could be invalid, you must catch all of these exceptions:

- **E_INVALIDARG**
- **E_FAIL**
- **ERROR_FILENAME_EXCED_RANGE**
- **ERROR_INVALID_NAME**

If the file is deleted before the rename finishes, this method throws the **ERROR_FILE_NOT_FOUND** exception. You must also catch and handle this exception when you use this method.

If there's an existing item in the current file's location that already has the specified *desiredName*, the [RenameAsync(String, NameCollisionOption)](storagefile_renameasync_831946424.md) method should be used instead to specify how Windows responds to the conflict. This method doesn't allow you to specify a [NameCollisionOption](namecollisionoption.md) value, and the default behavior is to always throw an exception if there's a name conflict.

## -examples

## -see-also

[RenameAsync(String, NameCollisionOption)](storagefile_renameasync_831946424.md), [NameCollisionOption](namecollisionoption.md)