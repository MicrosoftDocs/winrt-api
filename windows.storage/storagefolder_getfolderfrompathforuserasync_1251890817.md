---
-api-id: M:Windows.Storage.StorageFolder.GetFolderFromPathForUserAsync(Windows.System.User,System.String)
-api-type: winrt method
---

## -description
Gets the [StorageFolder](storagefolder.md) based on an absolute path in the file system for a given user.

## -parameters

### -param user
The User for which the [StorageFolder](storagefolder.md) is returned.

### -param path
The absolute path in the file system (not the Uri) of the folder to get.

## -returns
When this method completes successfully, it returns a [StorageFolder](storagefolder.md) that represents the specified folder for the user.

## -remarks
This method is Multi-User Aware (MUA).

## -see-also
[GetFolderFromPathAsync](storagefolder_getfolderfrompathasync_1337535799.md)

## -examples
```csharp
async Task<StorageFolder> GetStorageFolderAsync(User user, string path) {     
    // It is possible the folder no longer exists     
    // or permissions were changed so that the     
    // app no longer has access to the path.     
    try     
    {         
        return await StorageFolder.GetFolderFromPathForUserAsync(user, path);     
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
