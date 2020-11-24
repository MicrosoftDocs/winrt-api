---
-api-id: M:Windows.Storage.StorageFile.GetFileFromPathForUserAsync(Windows.System.User,System.String)
-api-type: winrt method
---

## -description
Gets a [StorageFile](storagefile.md) object based on an absolute path in the file system for a given user.

## -parameters

### -param user
The User for which the [StorageFile](storagefile.md) is returned.

### -param path
The path of the file to get a [StorageFile](storagefile.md) to represent.

If your path uses slashes, make sure you use backslashes (\\). Forward slashes (/) are not accepted by this method.

## -returns
When this method completes, it returns the file as a [StorageFile](storagefile.md).

## -remarks
This method is Multi-User Aware (MUA).

## -see-also
[GetFileFromPathAsync](storagefile_getfilefrompathasync_1252266672.md)

## -examples
```csharp

async Task<StorageFile> GetStorageFileAsync(User user, string path) {     
    // It is possible the file no longer exists     
    // or permissions were changed so that the     
    // app no longer has access to the path.     
    try     
    {         
        return await StorageFile.GetFileFromPathForUserAsync(user, path);     
    }     
    catch( System.IO.IOException ex )    
    {         
        // File, or path not found I/O Exceptions can happen         
        // notify user or implement fallback, etc...         
        string message = ex.Message;         
        return null;     
    }     
    catch(System.UnauthorizedAccessException ex)     
    {         
        // Access denied - notify user or implement fallback, etc...  
        string message = ex.Message;         
        return null; 
    }    
```
