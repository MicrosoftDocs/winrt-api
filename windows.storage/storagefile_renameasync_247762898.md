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
If the name you specify is invalid, this method throws an exception. To handle all the ways the specified name could be invalid, you must catch all four of these exceptions:<table>
   <tr><td>E_INVALIDARG</td></tr>
   <tr><td>E_FAIL</td></tr>
   <tr><td>ERROR_FILENAME_EXCED_RANGE</td></tr>
   <tr><td>ERROR_INVALID_NAME</td></tr>
</table>

If the file is deleted before the rename finishes, this method throws the ERROR_FILE_NOT_FOUND exception. You must also catch and handle this exception when you use this method.

## -examples

## -see-also
[RenameAsync(String, NameCollisionOption)](storagefile_renameasync_831946424.md)