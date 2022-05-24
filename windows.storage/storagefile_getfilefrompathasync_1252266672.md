---
-api-id: M:Windows.Storage.StorageFile.GetFileFromPathAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFile> GetFileFromPathAsync(System.String path)
-->

# Windows.Storage.StorageFile.GetFileFromPathAsync

## -description
Gets a [StorageFile](storagefile.md) object to represent the file at the specified path.

## -parameters
### -param path
The path of the file to get a [StorageFile](storagefile.md) to represent.

If your path uses slashes, make sure you use backslashes (\\). Forward slashes (/) are not accepted by this method.

## -returns
When this method completes, it returns the file as a [StorageFile](storagefile.md).

## -exceptions
### T:System.IO.FileNotFoundException

The specified file does not exist. Check the value of *path*.

### T:System.UnauthorizedAccessException

You don't have permission to access the specified file. For more information, see [File access permissions](/windows/uwp/files/file-access-permissions).

### T:System.ArgumentException

The path cannot be a relative path or a Uri. Check the value of *path*.

## -remarks

## -examples

## -see-also
[File access permissions](/windows/uwp/files/file-access-permissions)
