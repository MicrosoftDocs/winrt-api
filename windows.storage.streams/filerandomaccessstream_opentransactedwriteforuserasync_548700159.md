---
-api-id: M:Windows.Storage.Streams.FileRandomAccessStream.OpenTransactedWriteForUserAsync(Windows.System.User,System.String,Windows.Storage.StorageOpenOptions,Windows.Storage.Streams.FileOpenDisposition)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<StorageStreamTransaction> FileRandomAccessStream.OpenTransactedWriteForUserAsync(User user, String filePath, StorageOpenOptions openOptions, FileOpenDisposition openDisposition)
-->

# Windows.Storage.Streams.FileRandomAccessStream.OpenTransactedWriteForUserAsync

## -description
Opens a writable stream for a user to a file given a file path and the user's information. If the file does not exist, it can be created using FileOpenDisposition.

## -parameters
### -param user
The user account for opening the stream.

### -param filePath
A path to the file to be opened.

### -param openOptions
A bitwise combination of the enumeration values that specify options for opening the stream.

### -param openDisposition
An action to take on the file. 

## -returns
When this method completes, it returns a [StorageStreamTransaction](/uwp/api/windows.storage.storagestreamtransaction) containing the random-access stream and methods that can be used to complete transactions.

## -remarks

## -see-also

## -examples

